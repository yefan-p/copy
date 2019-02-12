using Microsoft.VisualStudio.TestTools.UnitTesting;
using CopyPost.Trackers;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPost.Global;

namespace CopyPost.Trackers.Tests
{
    [TestClass()]
    public class RutorItemTests
    {
        private static RutorItem item;
        private static TestPage testedNowPage;

        struct TestPage
        {
            public string description;
            public int spoilers;
            public int pic;
            public string url;
        }

        [ClassInitialize()]
        public static void ClassInitialize(TestContext context)
        {
            TestPage testPage0 = new TestPage
            {
                url = @"http://rutor.is/torrent/541697/beloff-2019.2-minstall-vs-wpi-2019-pc-iso",
                description = @"<br><img src=""http://img15.lostpic.net/2019/01/02/12e0aa4792bfadadf135371c64e22316.jpg""><br>",
                spoilers = 6,
                pic = 1,
            };

            TestPage testPage1 = new TestPage
            {
                url = @"http://rutor.is/torrent/315024/gimp-2.10.8-final-2019-rs",
                description = @"<img src=""http://i5.imageban.ru/out/2015/12/19/805d48652ce568b6b6f9262d5d54028c.jpg"" style=""float:right;"">",
                spoilers = 3,
                pic = 7,
            };

            testedNowPage = testPage0;

            preposts pr = new preposts
            {
                href = testedNowPage.url,
            };
            bool flagCall = false;

            item = new RutorItem();
            item.OnPostMaked += delegate (object s, EventArgs e)
            {
                flagCall = true;
            };
            item.GetPost(pr);

            for (int callCount = 0; callCount < 48 && !flagCall; callCount++)
            {
                Thread.Sleep(250);
            }
        }

        [TestMethod()]
        public void RutorItem_GetDescription()
        {
            string actual = item.Description;
            string expected = testedNowPage.description;

            StringAssert.Contains(actual, expected);
        }

        [TestMethod()]
        public void RutorItem_GetSpoilers()
        {
            List<SpoilersItem> lst = item.Spoilers;

            int actual = lst.Count;
            int expected = testedNowPage.spoilers;

            Assert.IsNotNull(lst);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void RutorItem_GetImgs()
        {
            List<string> lst = item.Imgs;

            int actual = lst.Count;
            int expected = testedNowPage.pic;

            Assert.IsNotNull(lst);
            Assert.AreEqual(actual, expected);
        }
    }
}