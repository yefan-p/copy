using System;
using HtmlAgilityPack;

namespace ParsingTrackerCore.Parsers
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
