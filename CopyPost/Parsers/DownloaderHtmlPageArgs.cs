using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CopyPost.Parsers
{
    public class DownloaderHtmlPageArgs : EventArgs
    {
        public DownloaderHtmlPageArgs(HtmlDocument doc)
        {
            Page = doc;
        }

        public HtmlDocument Page { get; private set; }
    }
}
