using Microsoft.VisualStudio.TestTools.UnitTesting;
using CopyPostCore.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPostCore.Parsers.Tests
{
    [TestClass()]
    public class ParserImgsTests
    {
        [TestMethod()]
        public void GetDirectUriFastpicTest()
        {
            ParserImgs parserImgs = new ParserImgs();
            string uri = @"https://fastpic.ru/view/106/2018/1130/f342c2e15a17554ed37a5247248f4804.png.html";
            string expected = @"https://i106.fastpic.ru/big/2018/1130/04/f342c2e15a17554ed37a5247248f4804.png";
            string actual = null;

            actual = parserImgs.GetDirectUri(uri, ParserImgs.FastpicXPath);
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetDirectUriRadikalTest()
        {
            ParserImgs parserImgs = new ParserImgs();
            string uri = @"http://radikal.ru/fp/bhiuxvzk0bf9x";
            string expected = @"https://d.radikal.ru/d17/1902/c3/04c80b2db3bb.png";
            string actual = null;

            actual = parserImgs.GetDirectUri(uri, ParserImgs.RadikalXPath);
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetUriImagebanTest()
        {
            string actual = null;
            string expected = @"http://i1.imageban.ru/out/2017/11/24/17ee7666e89fe523f17fb3e1da83334d.png";

            string parentUri = @"http://imageban.ru/show/2017/11/24/17ee7666e89fe523f17fb3e1da83334d/png";
            string childUri = @"http://i1.imageban.ru/thumbs/2017.11.24/17ee7666e89fe523f17fb3e1da83334d.png";

            ParserImgs parser = new ParserImgs();
            actual = parser.GetUriImageban(parentUri, childUri);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetUriLostpicTest()
        {
            string uri = @"http://img11.lostpic.net/2017/05/16/6c010b0db51842aaf9dc61d5eeb63ef5.th.jpg";
            string actual = null;
            string expected = @"http://img11.lostpic.net/2017/05/16/6c010b0db51842aaf9dc61d5eeb63ef5.jpg";

            ParserImgs parser = new ParserImgs();
            actual = parser.GetUriLostpic(uri);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetUriLostpixTest()
        {
            string uri = @"http://lostpix.com/thumbs/2018-05/18/g28vmvlei36tj28tqf4lr4x3x.jpg";
            string actual = null;
            string expected = @"http://lostpix.com/img/2018-05/18/g28vmvlei36tj28tqf4lr4x3x.jpg";

            ParserImgs parser = new ParserImgs();
            actual = parser.GetUriLostpix(uri);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }
    }
}