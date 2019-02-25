using System;

namespace TorrentSoftAutoAddPost
{
    public class ViewTorrentSoftPost
    {
        public int Id { get; set; }
        public int ReadyPostId { get; set; }
        public DateTime WasAdded { get; set; }
        public string Name { get; set; }
    }
}
