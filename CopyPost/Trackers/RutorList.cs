using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

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

            TrackerExpression = it => it.id == 1;
        }

        public List<TrackersListItem> Posts { get; }
        public Func<tracker, bool> TrackerExpression { get; }
    }
}
