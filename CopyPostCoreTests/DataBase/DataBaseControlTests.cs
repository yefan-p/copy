using Microsoft.VisualStudio.TestTools.UnitTesting;
using CopyPostCore.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPostCore.Parsers;
using System.Threading;
using CopyPostCoreTests;

namespace CopyPostCore.DataBase.Tests
{
    [TestClass()]
    public class DataBaseControlTests
    {
        [TestMethod()]
        public void GetLastFoundedTest()
        {
            DataBaseControl db = new DataBaseControl();
            List<FoundPost> list = db.GetLastFounded(TTrakers.Rutor);

            Assert.AreEqual(100, list.Count());
        }

        [TestMethod()]
        public void AddFoundedsTest()
        {
            List<FoundPost> listFound = null;
            bool eventCall = false;

            ParserRutor parser = new ParserRutor();
            parser.FoundPostsReceived += delegate (object s, FoundPostArgs e)
                {
                    listFound = e.FoundPosts;
                    eventCall = true;
                };
            parser.StartGetList();
            CommonFunction.SleepTimer(12, ref eventCall);

            DataBaseControl db = new DataBaseControl();
            int actual = db.AddFoundeds(listFound);

            Assert.IsNotNull(listFound);
            Assert.AreEqual(listFound.Count(), actual);
        }

        [TestMethod()]
        public void AddReadyTest()
        {
            autoParsingContext db = new autoParsingContext();
            FoundPost foundPost = db.FoundPost.First();
            ReadyPost readyPost = null;
            bool eventCall = false;

            ParserRutor parserRutor = new ParserRutor();
            parserRutor.ReadyPostsReceived += delegate (object s, ReadyPostArgs e)
            {
                readyPost = e.ReadyPostRecieved;
                eventCall = true;
            };
            parserRutor.StartGetItem(foundPost);
            CommonFunction.SleepTimer(12, ref eventCall);

            DataBaseControl dataBaseControl = new DataBaseControl();
            Assert.IsNotNull(readyPost);
            int actual = dataBaseControl.AddReady(readyPost);

            Assert.AreEqual(9, actual);
        }

    }
}