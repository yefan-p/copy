using OpenQA.Selenium;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using CopyPost.Global;

namespace CopyPost.Trackers
{
    class RutorItem : ITrackersItem
    {
        Browser browser;

        // Автосвойство не используется, так как необходимо добавлять в лист, нет возможнсти
        // сразу инициализировать весь лист. Возможность есть, но код будет менее читаемым.
        List<SpoilersItem> spoilers = new List<SpoilersItem>();  
        public List<SpoilersItem> Spoilers                      
        {
            get { return spoilers; }
            private set { spoilers = value; }
        }                   

        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<string> Imgs { get; private set; }
        public string TorrentPath { get; private set; }

        public RutorItem(preposts prPost)
        {
            Name = prPost.name;
            string url = prPost.href;

            browser = new Browser();
            browser.Open();
            browser.BrowserMan.Navigate().GoToUrl(url);

            SetDescription();
            SetImgs();
            SetSpoilers();
            SetTorrentFile();

            browser.Close();

            if(Description != null) CleanDescription();
            CleanSpoilers();
        }

        public void GetPost(preposts prPost)
        {
            HTMLPage page = new HTMLPage();
            page.OnPageDownload += Page_OnPageDownload;
            page.SetPage(prPost.href);
        }

        private void Page_OnPageDownload(object sender, HTMLPageEventArgs e)
        {
            throw new NotImplementedException();
        }

        #region Получаем информацию о посте с Web-страницы. Парсинг.
        private void SetDescription()
        {
            IWebElement bodyPost = browser.BrowserMan.FindElement(By.CssSelector(@"[style=""vertical-align:top;""]~td"));
            string dirtyDescript = bodyPost.GetAttribute("innerHTML");

            int divExistsBegin = dirtyDescript.IndexOf(@"<div class=""hidewrap""");
            int divExistsEnd = dirtyDescript.LastIndexOf(@"</div>");

            if (divExistsBegin != -1 && divExistsEnd != -1)
            {
                dirtyDescript = dirtyDescript.Remove(divExistsBegin, divExistsEnd - divExistsBegin + 6); // + 6 потому что LastIndexOf(@"</div>") возвращает начало вхождения
            }

            string[] arrayDescription = dirtyDescript.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            bool flag = false;
            string spoilerContent = "";

            foreach (string item in arrayDescription)
            {
                if ((item.Contains("Описание") || item.Contains("описание")) && flag == false)
                    flag = true;
                else if (flag)
                    Description += item + System.Environment.NewLine;
                else
                    spoilerContent += item + System.Environment.NewLine;
            }

            SpoilersItem spoilersItem = new SpoilersItem();
            spoilersItem.name = "Системные требования и дополнительное описание:";
            spoilersItem.content = spoilerContent;
            spoilers.Add(spoilersItem);
        }

        private void SetImgs()
        {
            By locator = By.XPath(@"//div[@class='hidewrap']/div[contains(text(), 'Скрин')][@class='hidehead']");
            if (browser.isElementExists(locator))
            {
                IWebElement blockScreen = browser.BrowserMan.FindElement(locator);
                blockScreen.Click();
            }

            locator = By.CssSelector(@"[style='vertical-align:top;']~td img");
            if (browser.isElementExists(locator))
            {
                IList<IWebElement> imgsWeb = browser.BrowserMan.FindElements(locator);
                Imgs = imgsWeb.Select(i => i.GetAttribute("src")).ToList();
            }
        }

        private void SetSpoilers()
        {
            By locator = By.CssSelector(@"[style='vertical-align:top;']~td div[class='hidewrap']");

            List<string> spoilersName = new List<string>();
            List<string> spoilersContent = new List<string>();

            if (browser.isElementExists(locator))
            {
                IList<IWebElement> elements = browser.BrowserMan.FindElements(By.CssSelector(@"[style='vertical-align:top;']~td div[class='hidewrap'] div[class='hidehead']"));
                spoilersName = elements.Select(i => i.Text).ToList();

                elements = browser.BrowserMan.FindElements(By.CssSelector(@"[style='vertical-align:top;']~td div[class='hidewrap'] textarea[class='hidearea']"));
                spoilersContent = elements.Select(i => i.GetAttribute("defaultValue")).ToList();
            }

            for (int i = 0; i < spoilersName.Count(); i++)
            {
                SpoilersItem itemSpoiler = new SpoilersItem();
                itemSpoiler.name = spoilersName.ElementAt(i);
                itemSpoiler.content = spoilersContent.ElementAt(i);
                spoilers.Add(itemSpoiler);
            }
        }

        private void SetTorrentFile()
        {
            By locator1 = By.CssSelector(@"div[id ='download'] a[href^='http']");
            By locator = By.CssSelector(@"div[id ='download'] a[href^='/download/']");

            if (browser.isElementExists(locator))
            {
                Program.statusBarGlobal.Description = "Загрузка торрент файла с рутор.";
                Program.statusBarGlobal.Message = "Получили ссылку, подготовка к загрузке.";

                IWebElement urlWebElemet = browser.BrowserMan.FindElement(locator);
                string urlDirectly = urlWebElemet.GetAttribute("href");

                string saveDir = MainFunc.workDir + "TorrentStorage\\";
                Directory.CreateDirectory(saveDir);

                string shortName = MainFunc.prefixTorrentFileName + MainFunc.MakeNameFile(Name) + ".torrent";
                string fullName = saveDir + shortName;

                Downloader downloader = new Downloader(urlDirectly, fullName);
                TorrentPath = fullName;
            }
            else
            {
                Program.statusBarGlobal.Description = "Загрузка торрент файла с рутор.";
                Program.statusBarGlobal.Message = "Не удалось получить ссылку для загрузки.";
            }
        }
        #endregion

        #region Удаление мусора. Дополнительный опциональный парсинг.
        private void CleanDescription()
        {
            while (Description.Contains("<br><br>") || Description.Contains("<br>\r\n<br>"))
            {
                Description = Description.Replace("<br><br>", "<br>");
                Description = Description.Replace("<br>\r\n<br>", "<br>");
            }   
        }

        private void CleanSpoilers()
        {
            string sp = spoilers.First().content;

            int divExistsBegin = sp.IndexOf(@"<a href=""http://zarunet.org/""");
            int divExistsEnd = sp.IndexOf(@"</a>");

            if (divExistsBegin != -1 && divExistsEnd != -1)
            {
                sp = sp.Remove(divExistsBegin, divExistsEnd - divExistsBegin + 4); // + 4 потому что IndexOf(@"</a>") возвращает начало вхождения

                SpoilersItem itemNew = new SpoilersItem
                {
                    name = spoilers.First().name,
                    content = sp
                };

                SpoilersItem itemDel = spoilers.First();
                spoilers.Remove(itemDel);

                spoilers.Insert(0, itemNew);
            }
        }
        #endregion
    }
}
