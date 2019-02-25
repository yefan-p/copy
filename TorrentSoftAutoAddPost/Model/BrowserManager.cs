using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TorrentSoftAutoAddPost.Model
{
    public class BrowserManager
    {
        private IWebDriver Browser;

        /// <summary>
        /// Открывает браузер. Неожиданно, правда?
        /// </summary>
        public void Open()
        {
            FirefoxOptions options = new FirefoxOptions();
            FirefoxProfile profile = new FirefoxProfile(Settings.FirefoxProfileDir);
            options.Profile = profile;
            Browser = new FirefoxDriver(options);
        }

        /// <summary>
        /// Закрывает браузер. Вот этого ты наверное вообще не ожидал.
        /// </summary>
        public void Close()
        {
            Browser.Close();
        }

        /// <summary>
        /// Заполняет страницу для добавления поста на сайте торрент софт.
        /// </summary>
        /// <param name="post"></param>
        public void FillPost(BrowserPost post)
        {
            Browser.Navigate().GoToUrl(Settings.TorrentSoftUri);

            FillMainInput(post);
            FillScreenshot(post.Screenshot);
            FillTorrentFile(post);

        }

        /// <summary>
        /// Заполняет основную информацию о посте на странице - 
        /// Имя, описание, постер
        /// </summary>
        /// <param name="post"></param>
        private void FillMainInput(BrowserPost post)
        {
            By selector = By.CssSelector(@"[name=""title""]");
            IWebElement namePost = Browser.FindElement(selector);
            Clipboard.SetText(post.Name);
            namePost.SendKeys(Settings.PasteClipboardSelenium);

            selector = By.CssSelector(@"[name=""title""]~button");
            IWebElement buttonClone = Browser.FindElement(selector);
            buttonClone.Click();

            selector = By.CssSelector(@"[name=""full_story""]");
            IWebElement bodyPost = Browser.FindElement(selector);
            Clipboard.SetText(post.Description);
            bodyPost.SendKeys(Settings.PasteClipboardSelenium);

            selector = By.CssSelector(@"[name=""xfield[poster]""]");
            IWebElement inputPoster = Browser.FindElement(selector);
            Clipboard.SetText(post.Poster);
            inputPoster.SendKeys(Settings.PasteClipboardSelenium);
        }

        /// <summary>
        /// Заполняет инпуты на страницы со скриншотами.
        /// </summary>
        /// <param name="list"></param>
        private void FillScreenshot(List<string> list)
        {
            // Потому что полей для скриншотов на сайте всего 8
            // и их атрибут name меняется от 1 до 8
            int maxCount = 9;
            if (list.Count < maxCount)
            {
                // +1 - чтобы не отрезался последний элемент в листе
                maxCount = list.Count + 1;
            }

            for (int i = 1; i < maxCount; i++)
            {
                By selector = By.CssSelector($"[name=\"xfield[images-{i}]\"]");
                IWebElement inputScreen = Browser.FindElement(selector);
                Clipboard.SetText(list[i - 1]);
                inputScreen.SendKeys(Settings.PasteClipboardSelenium);
            }
        }

        /// <summary>
        /// Прикрепляет торрент файл к посту
        /// </summary>
        /// <param name="post"></param>
        private void FillTorrentFile(BrowserPost post)
        {
            Thread.Sleep(300);
            By selector = By.CssSelector(@"[data-original-title=""Загрузка изображений и файлов на сервер""]");
            IWebElement ButtonDownloadTorrent = Browser.FindElement(selector);
            Thread.Sleep(800);
            ButtonDownloadTorrent.Click();

            selector = By.CssSelector(@"iframe");
            IWebElement WindowFrame = Browser.FindElement(selector);
            Browser.SwitchTo().Frame(WindowFrame);
            selector = By.CssSelector(@"input[multiple=""multiple""]");
            IWebElement ButtonLoadTorrentFile = Browser.FindElement(selector);
            Thread.Sleep(250);
            ButtonLoadTorrentFile.SendKeys(post.TorrentFile);

            Browser.SwitchTo().DefaultContent();
        }
    }
}
