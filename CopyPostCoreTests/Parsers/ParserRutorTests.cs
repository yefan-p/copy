using Microsoft.VisualStudio.TestTools.UnitTesting;
using CopyPostCore.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CopyPostCore.Parsers.Tests
{
    [TestClass()]
    public class ParserRutorTests
    {
        [TestMethod()]
        public void StartGetListTest()
        {
            ParserRutor parser = new ParserRutor();
            List<ItemList> actual = null;
            bool eventCall = false;

            parser.ListReceived += delegate (object s, ItemListArgs e)
            {
                actual = e.Posts;
                eventCall = true;
            };
            parser.StartGetList();

            // ждем 12 секунд, если событие выполниться, идем дальше
            for (int countCall = 0; countCall < 48 && !eventCall; countCall++)
            {
                Thread.Sleep(250);
            }

            Assert.IsNotNull(actual);
        }
    }
}