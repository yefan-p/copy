using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPostCore
{
    public static class Settings
    {
        /// <summary>
        /// Количество строк, которые мы берем при запросе к бд когда хотим получить 
        /// последние добавленные записи
        /// </summary>
        public static int NumbersRowsSelect = 100;
    }
}
