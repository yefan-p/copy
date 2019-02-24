using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorrentSoftAutoAddPost.Model
{
    public class Settings
    {
        /// <summary>
        /// Количество записей, которые будут отображатся на форме 
        /// в таблице не опубликованных постов
        /// </summary>
        public static int NotPublishedCount = 100;

        public static int PublishedCount = 100;
    }
}
