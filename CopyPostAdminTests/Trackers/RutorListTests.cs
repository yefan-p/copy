using Microsoft.VisualStudio.TestTools.UnitTesting;
using CopyPost.Trackers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CopyPost.Trackers.Tests
{
    [TestClass()]
    public class RutorListTests
    {
        [TestMethod()]
        public void RutorListTest()
        {
            //dw переменая для записи в событии
            List<TrackersListItem> actual = null;
            bool flagCall = false;

            //dw создаем тестируемый класс
            RutorList itemList = new RutorList();
            //dw подписываемся на событие
            itemList.OnPostReceived += delegate (object sender, RutorListEventArgs e)
                {
                    actual = e.Posts;
                    flagCall = true;
                };
            //dw начинаем получать лист
            itemList.GetList();

            //dw ждем 12 секунд, если событие наступит раньше, то выполнение пойдет
            for (int countCall = 0; countCall < 48 && !flagCall; countCall++)
            {
                //dw ждем когда событие настанет
                Thread.Sleep(250);
            }

            //dw проверяем, что объект не null
            Assert.IsNotNull(actual);
            //dw на странице с rutor размещаются только 100 раздач
            Assert.AreEqual(actual.Count(), 100);
        }
    }
}