using System.Collections.Generic;

namespace TorrentSoftAutoAddPost.Model
{
    /// <summary>
    /// Предназначен для заполнения текстовых полей непосредственно в браузере.
    /// </summary>
    public class BrowserPost
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string TorrentFile { get; set; }
        public List<string> Screenshot { get; set; }
        public string Poster { get; set; }
    }
}
