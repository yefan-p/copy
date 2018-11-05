using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyPost
{
    class MainFunc
    {
        public static string workDir = Application.StartupPath + @"\";
        public static string prefixTorrentFileName = "[storageTorrents]";

        public static string rutorWorkURL = @"http://mega-tor.org/soft";
        public static string rutorWorkURL1 = @"http://www.rutor.info/soft";

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
