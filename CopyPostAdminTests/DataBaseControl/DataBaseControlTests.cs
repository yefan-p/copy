using Microsoft.VisualStudio.TestTools.UnitTesting;
using CopyPost.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPost.Parsers;
using CopyPost;

namespace CopyPost.DataBase.Tests
{
    [TestClass()]
    public class DataBaseControlTests
    {
        [TestMethod()]
        public void GetLastRecordListRutorTest()
        {
            DataBaseControl db = new DataBaseControl();
            List<ItemList> lastPreposts = db.GetLastRecordListRutor();

            Assert.AreEqual(100, lastPreposts.Count());
        }
    }
}