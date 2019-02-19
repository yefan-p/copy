using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using HtmlAgilityPack;

namespace CopyPost.Parsers
{
    public class ParserRutor
    {
        private static readonly Uri UriDotInfo = new Uri(@"http://www.rutor.info/soft");
        private static readonly Uri UriDotIs = new Uri(@"http://rutor.is/soft");
        private static readonly Uri UriDotOnion = new Uri(@"http://rutorc6mqdinc4cz.onion/soft");
        public static readonly Uri UriWork = UriDotIs;

        public event EventHandler<ItemListArgs> ListReceived;

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
                }).ToList();

                ItemListArgs eventArgs = new ItemListArgs(postsList);
                //вызываем событие. аналог if(onPostReceived!=null)onPostReceived(arg);
                ListReceived?.Invoke(this, eventArgs);
            }
            else
            {
                Program.statusBarGlobal.Message = "Ошибка на этапе парсинга страницы";
            }
        }
    }
}
