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
        public event EventHandler<ItemListArgs> ListReceived;

        /// <summary>
        /// Вызывается, когда раздача сформирована
        /// </summary>
        public event EventHandler<ItemReadyArgs> ItemReceived;

        #region Работа со списком
        /// <summary>
        /// Возвращает список новых раздач
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
                List<ItemList> postsList;
                postsList = htmlNodes.Select((el, i) => new ItemList
                {
                    // HtmlDecode необходим чтобы привести HTML escape последовательности
                    // в нормальный вид
                    Name = HttpUtility.HtmlDecode(el.LastChild.InnerText),
                    Href = rutorMainUrl + el.LastChild.GetAttributeValue("href", null),
                    Index = i,
                    Magnet = el.ChildNodes[1].GetAttributeValue("href", null),
                }).Reverse().ToList();

                ItemListArgs eventArgs = new ItemListArgs(postsList);
                //вызываем событие. аналог if(onPostReceived!=null)onPostReceived(arg);
                ListReceived?.Invoke(this, eventArgs);
            }
            else
            {
                MessageService.ShowError("Ошибка на этапе парсинга списка раздач. htmlNodes = null");
            }
        }
        #endregion

        #region Работа с раздачей
        /// <summary>
        /// Возвращает готовый пост.
        /// </summary>
        /// <param name="item">Найденный пост, который необходимо распарсить</param>
        public void StartGetItem(ItemList item)
        {
            DownloaderHtmlPage downloaderItem = new DownloaderHtmlPage();
            downloaderItem.FinishDownload += DownloaderItem_FinishDownload;

            _itemList = item;

            Uri uri = new Uri(item.Href);
            downloaderItem.StartDownload(uri);
        }

        /// <summary>
        /// Приватное поле класса. Необходимо для передачи информации из какой найденной раздачи и 
        /// получился текущий пост.
        /// </summary>
        private ItemList _itemList;

        private void DownloaderItem_FinishDownload(object sender, DownloaderHtmlPageArgs e)
        {
            HtmlNode mainNode = e.Page.DocumentNode.SelectSingleNode(@"//table[@id=""details""]/tr[1]/td[2]");

            if (mainNode != null)
            {
                ItemReady item = new ItemReady();
                // Важен порядок вызова функций. 
                item.Spoilers = ParsingSpoilers(mainNode);
                item.Imgs = ParsingImgs(mainNode, item.Spoilers);
                item.Description = HttpUtility.HtmlDecode(mainNode.InnerHtml);
                item.Name = ParsingName(mainNode);
                item.TorrentUrl = ParsingTorrentUrl(mainNode);

                ItemReadyArgs eventArgs = new ItemReadyArgs(item);
                ItemReceived?.Invoke(this, eventArgs);
            }
            else
            {
                MessageService.ShowError("Ошибка на этапе парсинга раздачи. mainNode = null");
            }
        }

        private List<ItemSpoiler> ParsingSpoilers(HtmlNode mainNode)
        {
            // выбираем все спойлеры. В нодах оказывается храниться весь документ
            // вне зависимости от того, что и когда мы парсили
            // поэтому здесь поиск xpath опять идет от корня
            HtmlNodeCollection spoilersNode = mainNode.SelectNodes(@"//table[@id=""details""]/tr[1]/td[2]//div[@class=""hidewrap""]");

            if (spoilersNode != null)
            {
                List<ItemSpoiler> spoilers = new List<ItemSpoiler>();
                foreach (var item in spoilersNode)
                {
                    ItemSpoiler itemHtml = new ItemSpoiler()
                    {
                        Header = item.FirstChild.InnerText,
                        Body = item.LastChild.InnerHtml,
                    };

                    spoilers.Add(itemHtml);
                    // Чтобы корректно спарсить описание, необходимо удалить все спойлеры
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

        private List<ItemImg> ParsingImgs(HtmlNode mainNode, List<ItemSpoiler> spoilers)
        {
            // История следующая. На странице с раздачей могут быть вставлены полноразмерные копии изображений
            // по прямым ссылкам, в целях оформления внешнего вида (1). И также могут быть вставлены миниатюры изображений
            // - скриншоты программы, которые обернуты снаружи ссылкой (2). Так же мы изначально получаем страницу, 
            // в которой сверуты все спойлеры. Содержимое спойлера на странице - просто строка, поэтому мы не получаем
            // ссылки изображений, которые находяться под спойром. Этот случай нужно парсить отдельно (3).
            List<ItemImg> imgs;

            // Парсим изображения для внешнего вида (1)
            HtmlNodeCollection nodesImg = mainNode.SelectNodes(@"//table[@id=""details""]/tr[1]/td[2]//img[not(parent::a)]");
            imgs = GetImgs(nodesImg, TImg.View);

            // Парсим изображения миниатюры/скриншоты (2)
            nodesImg = mainNode.SelectNodes(@"//table[@id=""details""]//tr[1]//td[2]//img[(parent::a)]");
            //это необходимо чтобы после найдных скриншотов лист полностью не перезаписывался
            var tmpImg = GetImgs(nodesImg, TImg.Screenshot);
            imgs.AddRange(tmpImg);

            // Парсим изображения из спойлеров (3)
            tmpImg = GetImgsFromSpoilers(spoilers);
            imgs.AddRange(tmpImg);

            return imgs;            
        }

        /// <summary>
        /// Получаем изображения, из указанной ноды
        /// </summary>
        /// <param name="nodesImg">Выбранные ноды, в которых должны быть эти изображения</param>
        /// <param name="tImg">Тип изображения, котороый необходимо найти</param>
        /// <param name="messageExclamation">Сообщение пользователю, если изображения не найдены</param>
        /// <returns>Возвращает список с изображениями</returns>
        private List<ItemImg> GetImgs(HtmlNodeCollection nodesImg, TImg tImg)
        {
            List<ItemImg> imgs = new List<ItemImg>();

            if (nodesImg != null)
            {
                foreach (var item in nodesImg)
                {
                    HtmlNode parentUrl = item.ParentNode;

                    ItemImg itemImg = new ItemImg()
                    {
                        Type = tImg,
                        Href = item.GetAttributeValue("src", "0"),
                        ParentHref = parentUrl.GetAttributeValue("href", "0"),
                    };
                    imgs.Add(itemImg);
                }
            }

            return imgs;
        }

        /// <summary>
        /// Получаем скриншоты из указанных спойлеров
        /// </summary>
        /// <param name="spoilers">Спойлеры, из которых нужно взять скриншоты</param>
        /// <returns></returns>
        private List<ItemImg> GetImgsFromSpoilers(List<ItemSpoiler> spoilers)
        {
            List<ItemImg> imgs = new List<ItemImg>();

            foreach (var item in spoilers)
            {
                HtmlDocument document = new HtmlDocument();
                document.LoadHtml(item.Body);

                HtmlNodeCollection nodes = document.DocumentNode.SelectNodes(@"//img[(parent::a)]");

                var imgsTmp = GetImgs(nodes, TImg.Screenshot);
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
