using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace CopyPost.Global.Tests
{
    [TestClass()]
    public class HTMLPageTests
    {
        [TestMethod()]
        public void HTMLPageTest_RutorIs()
        {
            string expected = "<title>зеркало rutor.info :: Софт</title>";
            string actual = null;
            bool flagCall = false;

            HTMLPage page = new HTMLPage();
            //dw подписываемся на событие при помощи анонимного делегата
            //если делать ассерты внутри делегата, то тест всегда проходит
            page.OnPageDownload +=
                delegate (object sender, HTMLPageEventArgs e)
                {
                    actual = e.PageStr;
                    flagCall = true;
                };
            page.SetPage(MainFunc.rutorWorkURL_2);

            //dw ждем 12 секунд, если событие выполниться, идем дальше
            for (int countCall = 0; countCall < 48 && !flagCall; countCall++)
            {
                Thread.Sleep(250);
            }

            Assert.IsNotNull(actual);
            StringAssert.Contains(actual, expected);
        }
    }
}