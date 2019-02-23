using Microsoft.VisualStudio.TestTools.UnitTesting;
using CopyPostCore.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CopyPostCore.DataBase;
using CopyPostCoreTests;

namespace CopyPostCore.Parsers.Tests
{
    [TestClass()]
    public class ParserRutorTests
    {
        [TestMethod()]
        public void StartGetListTest()
        {
            ParserRutor parser = new ParserRutor();
            List<FoundPost> actual = null;
            bool eventCall = false;

            parser.FoundPostsReceived += delegate (object s, FoundPostArgs e)
            {
                actual = e.FoundPosts;
                eventCall = true;
            };
            parser.StartGetList();
            CommonFunction.SleepTimer(12, ref eventCall);

            Assert.IsNotNull(actual);
        }

        [TestMethod()]
        public void StartGetItemTest()
        {
            ParserRutor parser = new ParserRutor();
            ReadyPost actual = null;
            bool eventCall = false;

            DataBaseControl db = new DataBaseControl();
            List<FoundPost> list = db.GetLastFounded(TTrakers.Rutor, 10);
            FoundPost itemList = list.First();

            parser.ReadyPostsReceived += delegate (object s, ReadyPostArgs e)
            {
                actual = e.ReadyPostRecieved;
                eventCall = true;
            };
            parser.StartGetItem(itemList);
            CommonFunction.SleepTimer(12, ref eventCall);

            Assert.IsNotNull(actual);
        }

        [TestMethod()]
        public void DeleteDuplicateFromListTest()
        {
            ParserRutor parser = new ParserRutor();
            List<FoundPost> newPost = null;
            bool eventCall = false;

            parser.FoundPostsReceived += delegate (object s, FoundPostArgs e)
            {
                newPost = e.FoundPosts;
                eventCall = true;
            };
            parser.StartGetList();
            CommonFunction.SleepTimer(12, ref eventCall);

            Assert.IsNotNull(newPost);

            DataBaseControl dataBase = new DataBaseControl();
            List<FoundPost> oldPost = dataBase.GetLastFounded(TTrakers.Rutor);

            List<FoundPost> actual = parser.DeleteDuplicateFromList(oldPost, newPost);
            Assert.Fail();
        }
    }
}