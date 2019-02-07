using System;
using HtmlAgilityPack;

namespace CopyPost.Global
{
    public class HTMLPageEventArgs : EventArgs
    {
        public HTMLPageEventArgs(HtmlDocument doc, string strPage)
        {
            Page = doc;
            PageStr = strPage;
        }

        public HtmlDocument Page { get; private set; }
        public string PageStr { get; private set; }
    }
}
