using Microsoft.VisualStudio.TestTools.UnitTesting;
using TorrentSoftAutoAddPost.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPostCore;

namespace TorrentSoftAutoAddPost.Model.Tests
{
    [TestClass()]
    public class DataBaseSoftControllerTests
    {
        [TestMethod()]
        public void GetPublisedPostTest()
        {
            DataBaseSoftController dataBase = new DataBaseSoftController();
            List<TorrentSoftPost> list = dataBase.GetPublisedPost();
            Assert.Fail();
        }
    }
}