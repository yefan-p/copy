using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CopyPostCore.Parsers
{
    public class ParserImgs
    {
        public static string RadikalXPath = @"/html/body/div[3]/div[1]/div/div[1]/div[1]/div[2]/div[2]/div[1]/img";
        public static string RadikalXPath2 = @"/html/body/div[2]/div[1]/div/div[1]/div[1]/div[2]/div[2]/div[1]/img";
        public static string ImagebanXPath = @"/html/body/table//td/center/table//tr/td[2]/center[2]/div[1]/ul/li/img";
        public static string LostpicXPath = @"/html/body/div[2]/div[2]/div[1]/a/img";
        public static string FastpicXPath = @"//*[@id=""image""]";

        /// <summary>
        /// Возвращает прямые ссылки на изображения, по списку объектов изображений из бд
        /// </summary>
        /// <returns></returns>
        public List<string> DirectListManager(List<Img> imgs)
        {
            List<string> imgsList = new List<string>();
            foreach (var item in imgs)
            {
                string result = DirectUriManager(item);
                imgsList.Add(result);
            }

            return imgsList;
        }

        /// <summary>
        /// Возвращает прямую ссылку на изображение, по объекту изображения из бд
        /// </summary>
        /// <param name="img">Объект изображения из бд</param>
        /// <returns>Возвращает пустую строку, если хостинг незнакомый</returns>
        public string DirectUriManager(Img img)
        {
            string result = "";
            string uriImg = img.Uri_Parent;

            // условия расставлены в порядке убывания количества упоминаний хостинга в бд
            if (uriImg.Contains("radikal"))
                result = GetDirectUri(img.Uri_Parent, RadikalXPath2);
            else if (uriImg.Contains("imageban"))
                result = GetUriImageban(img.Uri_Parent, img.Uri);
            else if (uriImg.Contains("lostpic"))
                result = GetUriLostpic(img.Uri);
            else if (uriImg.Contains("lostpix"))
                result = GetUriLostpix(img.Uri);
            else if (uriImg.Contains("fastpic"))
                result = GetDirectUri(img.Uri_Parent, FastpicXPath);

            return result;
        }

        /// <summary>
        /// Возвращает прямую ссылку на изображение со страницы изображения на хостинге.
        /// Происходит парсинг сайта.
        /// </summary>
        /// <param name="uri">Страница с изображением</param>
        /// <param name="xPath">Какой хостинг</param>
        /// <returns></returns>
        public string GetDirectUri(string uri, string xPath)
        {
            DownloaderThroughTor downloader = new DownloaderThroughTor();
            HtmlDocument document = downloader.Page(new Uri(uri));

            HtmlNode node = document.DocumentNode.SelectSingleNode(xPath);
            string result = uri;

            if (node != null)
            {
                result = node.GetAttributeValue("src", null);
            }
            return result;
        }

        /// <summary>
        /// Получает прямую ссылку на изображение на сервере lostpix, без обращения к серверу
        /// </summary>
        /// <param name="uri">Страница с изображением, дочерняя ссылка из бд</param>
        /// <returns>Прямая ссылка</returns>
        public string GetUriLostpix(string uri)
        {
            string directUri = uri.Replace(@"/lostpix.com/thumbs/", @"/lostpix.com/img/");
            return directUri;
        }

        /// <summary>
        /// Получает прямую ссылку на изображение на сервере lostpic, без обращения к серверу
        /// </summary>
        /// <param name="uri">Страница с изображением, дочерняя ссылка из бд</param>
        /// <returns>Прямая ссылка</returns>
        public string GetUriLostpic(string uri)
        {
            string directUri = uri.Replace(@".th.", @".");
            return directUri;
        }

        /// <summary>
        /// Получает прямую ссылку на изображение на сервере imageban, без обращения к серверу
        /// </summary>
        /// <param name="parentUri">Родительская ссылка</param>
        /// <param name="childUri">Дочерняя ссылка</param>
        /// <returns>Прямая ссылка</returns>
        public string GetUriImageban(string parentUri, string childUri)
        {
            /* Например:	
             * Родительская ссылка - http://imageban.ru/show/2017/11/24/17ee7666e89fe523f17fb3e1da83334d/png
	         * Дочерняя ссылка - http://i1.imageban.ru/thumbs/2017.11.24/17ee7666e89fe523f17fb3e1da83334d.png
	         * Тогда прямая ссылка будет иметь следующий вид - http://i1.imageban.ru/out/2017/11/24/17ee7666e89fe523f17fb3e1da83334d.png
             * Отсюда следует, что нужно взять у дочерний ссылки первую часть до thumbs,
             * у родительской - вторую часть после show, а посередине получишвейся ссылке поставить out и заменить
             * последний слеш на точку
             * 
             */

            //Родительская ссылка может уже быть прямой ссылкой на изображение
            if (parentUri.Contains("/out/"))
            {
                return parentUri;
            }

            int thumbs = childUri.IndexOf("thumbs");
            childUri = childUri.Substring(0, thumbs);

            int show = parentUri.IndexOf("show") + 4; //для того чтобы в строке не дублировалось слово show
            parentUri = parentUri.Substring(show, parentUri.Length - show);

            string direct = childUri + "out" + parentUri;
            int lastPoint = direct.LastIndexOf(@"/");
            direct = direct.Remove(lastPoint, 1);
            direct = direct.Insert(lastPoint, ".");

            return direct;
        }
    }
}
