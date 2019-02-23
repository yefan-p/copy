using CopyPostCore.Parsers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HtmlAgilityPack;
using System.Threading;
using CopyPostCoreTests;

namespace CopyPostCore.Parsers.Tests
{
    [TestClass()]
    public class DownloaderHtmlPageTests
    {
        [TestMethod()]
        public void StartDownloadTest()
        {
            DownloaderHtmlPage downloader = new DownloaderHtmlPage();
            HtmlDocument actual = null;

            bool eventCall = false;

            downloader.FinishDownload += delegate (object s, DownloaderHtmlPageArgs e)
            {
                actual = e.Page;
                eventCall = true;
            };
            downloader.StartDownloadAsync(ParserRutor.UriWork);
            CommonFunction.SleepTimer(12, ref eventCall);

            Assert.IsNotNull(actual);
        }

        [TestMethod()]
        public void DownloadPageTest()
        {
            DownloaderHtmlPage downloader = new DownloaderHtmlPage();
            HtmlDocument actual = null;

            actual = downloader.DownloadPage(ParserRutor.UriWork);

            StringAssert.Contains(actual.ParsedText, @"<meta http-equiv=""content-type"" content=""text/html; charset=utf-8"" />");
            StringAssert.Contains(actual.ParsedText, @"<link rel=""shortcut icon"" href=""/s/favicon.ico"" />");
            StringAssert.Contains(actual.ParsedText, @"<title>зеркало rutor.info :: Софт</title>");
            StringAssert.Contains(actual.ParsedText, @"Файлы для обмена предоставлены пользователями сайта. Администрация не несёт ответственности за их содержание.");
            StringAssert.Contains(actual.ParsedText, @"На сервере хранятся только торрент-файлы. Это значит, что мы не храним никаких нелегальных материалов. <a href=""/advertise.php"">Реклама</a>. ");
        }
    }
}