using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyPost.TorrentSoftExtensions
{
    class TorrentSoftManager
    {
        TorrentSoftPost post;
        Browser browser;

        public TorrentSoftManager(TorrentSoftPost _post)
        {
            post = _post;
            browser = new Browser();
        }

        public void Add()
        {
            browser.Open();
            browser.BrowserMan.Navigate().GoToUrl(MainFunc.torrentSoftWorkURLAdd);

            PasteName();
            PasteDate();
            PasteDescription();
            PasteImgPoster();
            PasteScreen();
            PasteFile();
            
        }

        private void PasteName()
        {
            By locator = By.CssSelector("input[class='form-control width-550 position-left']");
            if (browser.isElementExists(locator))
            {
                IWebElement el = browser.BrowserMan.FindElement(locator);
                Clipboard.SetText(post.Name);
                el.SendKeys(OpenQA.Selenium.Keys.Control + "v" + OpenQA.Selenium.Keys.Control);
            }
        }

        private void PasteDate()
        {
            By locator = By.CssSelector("input[name='newdate']");
            if (browser.isElementExists(locator))
            {
                IWebElement el = browser.BrowserMan.FindElement(locator);
                Clipboard.SetText(post.DatePublic.ToString("yyyy-MM-dd HH:mm:ss"));
                el.SendKeys(OpenQA.Selenium.Keys.Control + "v" + OpenQA.Selenium.Keys.Control);
            }
        }

        private void PasteDescription()
        {
            By locator = By.CssSelector("textarea[name='full_story']");
            if (browser.isElementExists(locator))
            {
                IWebElement el = browser.BrowserMan.FindElement(locator);
                Clipboard.SetText(post.Description.ToString());
                el.SendKeys(OpenQA.Selenium.Keys.Control + "v" + OpenQA.Selenium.Keys.Control);
            }
        }

        private void PasteImgPoster()
        {
            By locator = By.CssSelector("input[name='xfield[poster]']");
            if (browser.isElementExists(locator))
            {
                IWebElement el = browser.BrowserMan.FindElement(locator);
                Clipboard.SetText(post.ImgPoster);
                el.SendKeys(OpenQA.Selenium.Keys.Control + "v" + OpenQA.Selenium.Keys.Control);
            }
        }

        private void PasteScreen()
        {
            int i = 1;
            foreach (string item in post.Imgs)
            {
                string preLocator = string.Format("input[name='xfield[images-{0}]']", i);
                By locator = By.CssSelector(preLocator);
                if (browser.isElementExists(locator))
                {
                    IWebElement el = browser.BrowserMan.FindElement(locator);
                    Clipboard.SetText(item);
                    el.SendKeys(OpenQA.Selenium.Keys.Control + "v" + OpenQA.Selenium.Keys.Control);
                }
                i++;
            }
        }

        private void PasteFile()
        {
            Thread.Sleep(300);

            By locator = By.CssSelector("button[data-original-title='Загрузка изображений и файлов на сервер']");
            IWebElement elButton = browser.BrowserMan.FindElement(locator);

            Thread.Sleep(800);
            elButton.Click();

            locator = By.CssSelector("iframe[name='mediauploadframe']");
            IWebElement elFrame = browser.BrowserMan.FindElement(locator);

            browser.BrowserMan.SwitchTo().Frame(elFrame);

            locator = By.CssSelector("input[multiple='multiple']");
            IWebElement elLoadFile = browser.BrowserMan.FindElement(locator);
            elLoadFile.SendKeys(post.TorrentPath);

            browser.BrowserMan.SwitchTo().DefaultContent();
        }
    }
}
