using Microsoft.VisualStudio.TestTools.UnitTesting;
using CopyPostCore.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPostCore.Parsers;
using System.Threading;

namespace CopyPostCore.DataBase.Tests
{
    [TestClass()]
    public class DataBaseControlTests
    {
        [TestMethod()]
        public void GetLastRecordListTest()
        {
            DataBaseControl db = new DataBaseControl();
            List<FoundPost> list = db.GetLastRecordList(TTrakers.Rutor);

            Assert.AreEqual(100, list.Count());
        }

        [TestMethod()]
        public void AddNewRecordListTest()
        {
            List<FoundPost> listFound = null;
            bool eventCall = false;

            ParserRutor parser = new ParserRutor();
            parser.FoundPostsReceived += delegate(object s, FoundPostArgs e)
                {
                    listFound = e.FoundPosts;
                    eventCall = true;
                };
            parser.StartGetList();

            // ждем 12 секунд, если событие выполниться, идем дальше
            for (int countCall = 0; countCall < 48 && !eventCall; countCall++)
            {
                Thread.Sleep(250);
            }

            DataBaseControl db = new DataBaseControl();
            int actual = db.AddNewRecordList(listFound);

            Assert.IsNotNull(listFound);
            Assert.AreEqual(listFound.Count(), actual);
        }
    }
}