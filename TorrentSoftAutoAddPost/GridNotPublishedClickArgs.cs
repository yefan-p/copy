using System;

namespace TorrentSoftAutoAddPost
{
    public class GridNotPublishedClickArgs : EventArgs
    {
        public  GridNotPublishedClickArgs(string value)
        {
            IdReadyPost = int.Parse(value);
        }

        public int IdReadyPost { get; private set; }
    }
}
