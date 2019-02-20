using System;
using HtmlAgilityPack;

namespace CopyPostCore.Parsers
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
