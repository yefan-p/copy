using System;

namespace TorrentSoftAutoAddPost
{
    public class PosterSelectedArgs : EventArgs
    {
        public PosterSelectedArgs(string value)
        {
            PosterUri = value;
        }

        public string PosterUri { get; private set; }
    }
}
