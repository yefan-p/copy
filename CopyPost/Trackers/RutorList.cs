using System;
using System.Collections.Generic;
using System.Linq;
using CopyPost.Global;
using HtmlAgilityPack;

namespace CopyPost.Trackers
{
    public class RutorList : ITrackersList
    {
        public RutorList()
        {
            //dw легаси
            //Browser browser = new Browser();
            //browser.Open();
            //browser.BrowserMan.Navigate().GoToUrl(MainFunc.rutorWorkURL);
            //IList<IWebElement> PostsRutor = browser.BrowserMan.FindElements(By.CssSelector(@"div[id=""index""] a[href*=""torrent""]"));
            //Posts = PostsRutor.Select((el, i) => new TrackersListItem { Name = el.Text, Href = el.GetAttribute("href"), Index = i }).Reverse().ToList();
            //browser.Close();
        }

        public void GetList()
        {
            HTMLPage page = new HTMLPage();
            page.OnPageDownload += Page_onPageDownload; //подписываемся на событие загрузки страницы
            page.SetPage(MainFunc.rutorWorkURL_2); //указываем, какую страницу хотим получить

            TrackerExpression = it => it.id == 1; //указываем с каким трекером работаем в БД
        }

        private void Page_onPageDownload(object sender, HTMLPageEventArgs e)
        {
            //dw получаем список раздач с загруженной страницы
            HtmlNodeCollection htmlNodes = e.Page.DocumentNode.SelectNodes(@"//div[@id=""index""]//tr[position()>1]/td[2]");
            //up если нужного узла не будет - null

            //dw если список раздач получен
            if (htmlNodes != null)
            {
                List<TrackersListItem> postLst;
                postLst = htmlNodes.Select((el, i) => new TrackersListItem
                {
                    Name = el.LastChild.InnerText,
                    Href = el.LastChild.GetAttributeValue("href", null),
                    Index = i,
                    Magnet = el.ChildNodes[1].GetAttributeValue("href", null),
                }).ToList();

                //подготавливаем аргументы для события
                RutorListEventArgs eventArgs = new RutorListEventArgs(postLst);
                //вызываем событие. аналог if(onPostReceived!=null)onPostReceived(arg);
                OnPostReceived?.Invoke(this, eventArgs);
            }
            else
            {
                Program.statusBarGlobal.Message = "Ошибка на этапе парсинга страницы";
            }
        }

        //dw событие после получения списка постов
        public event EventHandler<RutorListEventArgs> OnPostReceived;

        public List<TrackersListItem> Posts { get; private set; } //легаси
        public Func<tracker, bool> TrackerExpression { get; private set; }
    }
}
