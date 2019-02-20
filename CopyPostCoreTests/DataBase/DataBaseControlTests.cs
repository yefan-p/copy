using Microsoft.VisualStudio.TestTools.UnitTesting;
using CopyPostCore.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPostCore.Parsers;

namespace CopyPostCore.DataBase.Tests
{
    [TestClass()]
    public class DataBaseControlTests
    {
        [TestMethod()]
        public void GetLastRecordListRutorTest()
        {
            DataBaseControl db = new DataBaseControl();
            List<ItemList> list =  db.GetLastRecordList(TTrakers.Rutor);

            Assert.AreEqual(100, list.Count());
        }
    }
}