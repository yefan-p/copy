using System;
using System.Collections.Generic;
using CopyPostCore;

namespace TorrentSoftAutoAddPost.Model
{
    public class TorrentSoftPostApp
    {
        public int IdReadyPost { get; set; }
        public DateTime WasAdded { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TorrentFile { get; set; }
        public List<string> Imgs { get; set; }
        public string Poster { get; set; }
        public ReadyPost ReadyPostDb { get; set; }
    }
}
