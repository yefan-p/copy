using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using HtmlAgilityPack;
using CopyPostCore.DataBase;

namespace CopyPostCore.Parsers
{
    public class ParserRutor
    {
        private static readonly Uri UriDotInfo = new Uri(@"http://www.rutor.info/soft");
        private static readonly Uri UriDotIs = new Uri(@"http://rutor.is/soft");
        private static readonly Uri UriDotOnion = new Uri(@"http://rutorc6mqdinc4cz.onion/soft");
        public static readonly Uri UriWork = UriDotIs;

        /// <summary>
        /// Вызывается, когда лист с найденными разадачи сформирован
        /// </summary>
        public event EventHandler<FoundPostArgs> FoundPostsReceived;

        /// <summary>
        /// Вызывается, когда раздача сформирована
        /// </summary>
        public event EventHandler<ReadyPostArgs> ReadyPostsReceived;

        #region Работа со списком
        /// <summary>
        /// Возвращает список всех найденных раздач
        /// </summary>
        public void StartGetList()
        {
            DownloaderHtmlPage downloader = new DownloaderHtmlPage();
            downloader.FinishDownload += Downloader_FinishDownload;
            downloader.StartDownload(UriWork);
        }

        private void Downloader_FinishDownload(object sender, DownloaderHtmlPageArgs e)
        {
            // если нужного узла не будет - null
            HtmlNodeCollection htmlNodes = e.Page.DocumentNode.SelectNodes(@"//div[@id=""index""]//tr[position()>1]/td[2]");

            // необходимо для добавления корректной ссылки на страницу раздачи
            // по умолчанию ссылка парситься без домена первого уровня
            string rutorMainUrl = UriWork.OriginalString.Replace(@"/soft", "");

            if (htmlNodes != null)
            {
                var foundQuery = 
                    from el in htmlNodes
                    select new FoundPost
                    {
                        Name = HttpUtility.HtmlDecode(el.LastChild.InnerText),
                        Uri = rutorMainUrl + el.LastChild.GetAttributeValue("href", null),
                        Magnet = el.ChildNodes[1].GetAttributeValue("href", null),
                        FoundedTime = DateTime.Now,
                        TorrentTracker_idTorrentTracker = (int)TTrakers.Rutor,
                    };
                List<FoundPost> foundPosts = foundQuery.Reverse().ToList();

                FoundPostArgs eventArgs = new FoundPostArgs(foundPosts);
                FoundPostsReceived?.Invoke(this, eventArgs);
            }
            else
            {
                MessageService.ShowError("Ошибка на этапе парсинга списка раздач. htmlNodes = null");
            }
        }

        /// <summary>
        /// Удаляет повторяющиеся записи из списка найденных постов.
        /// </summary>
        /// <param name="oldPost">Посты, которые уже есть в базе</param>
        /// <param name="newPost">Посты, в которых могут быть дубликаты</param>
        /// <returns></returns>
        public List<FoundPost> DeleteDuplicateFromList(List<FoundPost> oldPost, List<FoundPost> newPost)
        {
            //Получаем повторяющиеся магнет ссылки
            var magnetQuery =
                from left in oldPost
                from right in newPost 
                where right.Magnet == left.Magnet
                select right.Magnet;
            List<string> magnetList = magnetQuery.ToList();

            //Выбираем только те ссылки, которые отсутвуют в повторяющихся
            List<FoundPost> filteredList = newPost.Where(i => !magnetList.Contains(i.Magnet)).ToList();

            return filteredList;
        }
        #endregion

        #region Работа с раздачей
        /// <summary>
        /// Возвращает готовый пост.
        /// </summary>
        /// <param name="item">Найденный пост, который необходимо распарсить</param>
        public void StartGetItem(FoundPost item)
        {
            DownloaderHtmlPage downloaderItem = new DownloaderHtmlPage();
            downloaderItem.FinishDownload += DownloaderItem_FinishDownload;

            _parentItem = item;

            Uri uri = new Uri(item.Uri);
            downloaderItem.StartDownload(uri);
        }

        /// <summary>
        /// Приватное поле класса. Необходимо для передачи информации из какой найденной раздачи и 
        /// получился текущий пост.
        /// </summary>
        private FoundPost _parentItem;

        private void DownloaderItem_FinishDownload(object sender, DownloaderHtmlPageArgs e)
        {
            HtmlNode mainNode = e.Page.DocumentNode.SelectSingleNode(@"//table[@id=""details""]/tr[1]/td[2]");

            if (mainNode != null)
            {
                // Важно чтобы сначала вызывался парсинг спойлеров, а затем только парсинг описание
                // Порядок вызова остальных функций не важен. Читай комментарий в функции со спойлерами 
                ReadyPost readyPost = new ReadyPost();
                readyPost.Spoilers = ParsingSpoilers(mainNode, readyPost);
                readyPost.Imgs = ParsingImgs(mainNode, readyPost);
                readyPost.Description = HttpUtility.HtmlDecode(mainNode.InnerHtml);
                readyPost.Name = ParsingName(mainNode);
                readyPost.TorrentUrl = ParsingTorrentUrl(mainNode);
                readyPost.FoundPost = _parentItem;
                readyPost.FoundedTime = DateTime.Now;

                ReadyPostArgs eventArgs = new ReadyPostArgs(readyPost);
                ReadyPostsReceived?.Invoke(this, eventArgs);
            }
            else
            {
                MessageService.ShowError("Ошибка на этапе парсинга раздачи. mainNode = null");
            }
        }

        /// <summary>
        /// Выдергивает спойлеры со страницы
        /// </summary>
        /// <param name="mainNode">Кусок html, в которм будет производится поиск</param>
        /// <param name="readyPost">Пост, к которому будет относится спойлер</param>
        /// <returns></returns>
        private List<Spoiler> ParsingSpoilers(HtmlNode mainNode, ReadyPost readyPost)
        {
            // выбираем все спойлеры. В нодах оказывается храниться весь документ
            // вне зависимости от того, что и когда мы парсили
            // поэтому здесь поиск xpath опять идет от корня
            HtmlNodeCollection spoilersNode = mainNode.SelectNodes(@"//table[@id=""details""]/tr[1]/td[2]//div[@class=""hidewrap""]");

            if (spoilersNode != null)
            {
                List<Spoiler> spoilers = new List<Spoiler>();

                foreach (var item in spoilersNode)
                {
                    Spoiler itemHtml = new Spoiler()
                    {
                        Header = item.FirstChild.InnerText,
                        Body = item.LastChild.InnerHtml,
                        ReadyPost = readyPost,
                    };

                    spoilers.Add(itemHtml);
                    // Чтобы корректно спарсить описание, необходимо удалить все спойлеры
                    // По этой же причине не используется linq
                    item.RemoveAll();
                }
                return spoilers;
            }
            else
            {
                MessageService.ShowError("Ошибка при парсинге спойлеров раздачи");
                return null;
            }
        }

        private List<Img> ParsingImgs(HtmlNode mainNode, ReadyPost readyPost)
        {
            // История следующая. На странице с раздачей могут быть вставлены полноразмерные копии изображений
            // по прямым ссылкам, в целях оформления внешнего вида (1). И также могут быть вставлены миниатюры изображений
            // - скриншоты программы, которые обернуты снаружи ссылкой (2). Так же мы изначально получаем страницу, 
            // в которой сверуты все спойлеры. Содержимое спойлера на странице - просто строка, поэтому мы не получаем
            // ссылки изображений, которые находяться под спойром. Этот случай нужно парсить отдельно (3).
            List<Img> imgs;

            // Парсим изображения для внешнего вида (1)
            HtmlNodeCollection nodesImg = mainNode.SelectNodes(@"//table[@id=""details""]/tr[1]/td[2]//img[not(parent::a)]");
            imgs = GetImgs(nodesImg, TImg.View, readyPost);

            // Парсим изображения миниатюры/скриншоты (2)
            nodesImg = mainNode.SelectNodes(@"//table[@id=""details""]//tr[1]//td[2]//img[(parent::a)]");
            var tmpImg = GetImgs(nodesImg, TImg.Screenshot, readyPost);
            imgs.AddRange(tmpImg);

            // Парсим изображения из спойлеров (3)
            tmpImg = GetImgsFromSpoilers(readyPost);
            imgs.AddRange(tmpImg);

            return imgs;            
        }

        /// <summary>
        /// Получаем изображения, из указанной ноды
        /// </summary>
        /// <param name="nodesImg">Выбранные ноды, в которых должны быть эти изображения</param>
        /// <param name="tImg">Тип изображения, котороый необходимо найти</param>
        /// <param name="readyPost">Пост, к которому необходимо добавить изображение</param>
        /// <returns>Возвращает список с изображениями</returns>
        private List<Img> GetImgs(HtmlNodeCollection nodesImg, TImg tImg, ReadyPost readyPost)
        {
            List<Img> imgs = new List<Img>();

            if (nodesImg != null)
            {
                var imgQuery =
                    from el in nodesImg
                    select new Img
                    {
                        TypeImg_idTypeImg = (int)tImg,
                        Uri = el.GetAttributeValue("src", null),
                        Uri_Parent = el.ParentNode.GetAttributeValue("href", null),
                        ReadyPost = readyPost,
                    };
                imgs = imgQuery.ToList();
            }
            return imgs;
        }

        /// <summary>
        /// Получаем скриншоты из указанных спойлеров
        /// </summary>
        /// <param name="spoilers">Спойлеры, из которых нужно взять скриншоты</param>
        /// <returns></returns>
        private List<Img> GetImgsFromSpoilers(ReadyPost readyPost)
        {
            List<Img> imgs = new List<Img>();

            foreach (var item in readyPost.Spoilers)
            {
                HtmlDocument document = new HtmlDocument();
                document.LoadHtml(item.Body);

                HtmlNodeCollection nodes = document.DocumentNode.SelectNodes(@"//img[(parent::a)]");
                var imgsTmp = GetImgs(nodes, TImg.Screenshot, readyPost);
                imgs.AddRange(imgsTmp);
            }

            return imgs;
        }

        /// <summary>
        /// Получаем имя раздачи
        /// </summary>
        /// <param name="mainNode"></param>
        /// <returns></returns>
        private string ParsingName(HtmlNode mainNode)
        {
            HtmlNode nameNode = mainNode.SelectSingleNode(@"/html/body/div[1]/h1");

            if (nameNode != null)
            {
                return HttpUtility.HtmlDecode(nameNode.InnerText);
            }
            else
            {
                MessageService.ShowError("Не удалось получить имя раздачи");
                return "";
            }
        }

        /// <summary>
        /// Получаем адрес торрент файла
        /// </summary>
        /// <param name="mainNode"></param>
        /// <returns></returns>
        private string ParsingTorrentUrl(HtmlNode mainNode)
        {
            HtmlNode torrentUrl = mainNode.SelectSingleNode("/html/body/div[2]/div[1]/div[2]/a[2]");

            if (torrentUrl != null)
            {
                return torrentUrl.GetAttributeValue("href", "0");
            }
            else
            {
                MessageService.ShowError("Не удалось получить адрес торрент файла");
                return "";
            }
        }
        #endregion
    }
}
