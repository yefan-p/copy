using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyPost
{
    public class MainFunc
    {
        public static string workDir = Application.StartupPath + @"\";
        public static string prefixTorrentFileName = "[storageTorrents]";

        public static string rutorURL_info = @"http://www.rutor.info/soft";
        public static string rutorURL_is = @"http://rutor.is/soft";
        public static string rutorURL_onion = @"http://rutorc6mqdinc4cz.onion/soft";
        public static string rutorWorkURL = rutorURL_is; //url, который используется в коде

        public static string torrentSoftWorkURLAdd = @"http://torrent-soft.net/admin-panel.php?mod=addnews&action=addnews";

        public static int countViewRecordPrPost = 100;
        public static int countViewRecordPost = 100;

        public static string MakeNameFile(string badName)
        {
            string goodName = badName.Replace("<", "");
            goodName = goodName.Replace(">", "");
            goodName = goodName.Replace(":", "");
            goodName = goodName.Replace("\"", "");
            goodName = goodName.Replace("/", "");
            goodName = goodName.Replace("\\", "");
            goodName = goodName.Replace("|", "");
            goodName = goodName.Replace("?", "");
            goodName = goodName.Replace("*", "");
            return goodName;
        }
    }
}
