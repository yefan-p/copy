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

            HTMLPage page = new HTMLPage();
            //dw подписываемся на событие при помощи анонимного делегата
            //если делать ассерты внутри делегата, то тест всегда проходит
            page.OnPageDownload +=
                delegate (object sender, HTMLPageEventArgs e)
                {
                    actual = e.PageStr;
                };
            page.SetPage(MainFunc.rutorWorkURL_2);

            //dw так как будет обращение к интернет, делаем паузу
            Thread.Sleep(2000);

            Assert.IsNotNull(actual);
            StringAssert.Contains(actual, expected);
        }
    }
}