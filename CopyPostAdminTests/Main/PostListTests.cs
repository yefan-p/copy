using Microsoft.VisualStudio.TestTools.UnitTesting;
using CopyPost;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPost.Trackers;

namespace CopyPost.Tests
{
    [TestClass()]
    public class PostListTests
    {

        [TestMethod()]
        public void AddAddInDB()
        {
            //dw плохой тест, нужно переписать
            //событие так и не наступает
            RutorList rutorList = new RutorList();
            PostList postList = new PostList();
            bool callFlag = false;

            postList.OnAfterAdd += delegate (object sender, EventArgs e)
                {
                    callFlag = true;
                };

            for (int countCall = 0; countCall < 48 && !callFlag; countCall++)
            {
                Thread.Sleep(250);
            }

            postList.Add(rutorList);
            Assert.AreEqual(true, callFlag);
        }
    }
}