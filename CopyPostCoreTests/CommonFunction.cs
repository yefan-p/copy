using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CopyPostCoreTests
{
    public class CommonFunction
    {
        /// <summary>
        /// Останавливает выполнение текущего потока на указанное количество секунд.
        /// Можно прервать сон, присвоив значению по ссылке истину
        /// </summary>
        /// <param name="maxWait">Максимальное время ождания в секундах</param>
        /// <param name="flag">Переменная для прерывания "сна"</param>
        public static void SleepTimer(int maxWait, ref bool flag)
        {
            int sleepTime = 250;
            int sleepCount = (maxWait * 1000) / sleepTime;
            for (int countCall = 0; countCall < sleepCount && !flag; countCall++)
            {
                Thread.Sleep(sleepTime);
            }
        }
    }
}
