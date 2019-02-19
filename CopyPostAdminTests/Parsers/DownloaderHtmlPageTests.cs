using Microsoft.VisualStudio.TestTools.UnitTesting;
using CopyPost.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Threading;

namespace CopyPost.Parsers.Tests
{
    [TestClass()]
    public class DownloaderHtmlPageTests
    {
        [TestMethod()]
        public void DownloaderPage()
        {
            DownloaderHtmlPage downloader = new DownloaderHtmlPage();
            HtmlDocument actual = null;

            bool eventCall = false;

            downloader.FinishDownload += delegate (object s, DownloaderHtmlPageArgs e)
            {
                actual = e.Page;
                eventCall = true;
            };
            downloader.StartDownload(ParserRutor.UriWork);

            //dw ждем 12 секунд, если событие выполниться, идем дальше
            for (int countCall = 0; countCall < 48 && !eventCall; countCall++)
            {
                Thread.Sleep(250);
            }

            Assert.IsNotNull(actual);
        }
    }
}