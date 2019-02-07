using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using CopyPost.Global;

namespace CopyPost.Trackers
{
    class RutorList : ITrackersList
    {
        public RutorList()
        {
            Browser browser = new Browser();
            browser.Open();
            browser.BrowserMan.Navigate().GoToUrl(MainFunc.rutorWorkURL);
            IList<IWebElement> PostsRutor = browser.BrowserMan.FindElements(By.CssSelector(@"div[id=""index""] a[href*=""torrent""]"));
            Posts = PostsRutor.Select((el, i) => new TrackersListItem { Name = el.Text, Href = el.GetAttribute("href"), Index = i }).Reverse().ToList();
            browser.Close();

            HTMLPage page = new HTMLPage();
            page.onPageDownload += Page_onPageDownload; //подписываемся на событие загрузки страницы
            page.SetPage(MainFunc.rutorWorkURL_2); //указываем, какую страницу хотим получить

            TrackerExpression = it => it.id == 1; //указываем с каким трекером работаем в БД
        }

        private void Page_onPageDownload(object sender, HTMLPageEventArgs e)
        {
            throw new NotImplementedException();
        }

        public List<TrackersListItem> Posts { get; }
        public Func<tracker, bool> TrackerExpression { get; }
    }
}
