using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPost.Trackers;

namespace CopyPost
{
    public struct SpoilersItem
    {
        public string name;
        public string content;
    }

    class Post
    {
        ITrackersItem item;

        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Imgs { get; set; }
        public List<SpoilersItem> Spoilers { get; set; }
        public string TorrentPath { get; set; }
        public DateTime DatePublic { get; set; }
        public int Program { get; set; }
        public preposts Prepost { get; set; }

        public Post(preposts prPost)
        {
            switch (prPost.tracker)
            {
                case 1:
                    item = new RutorItem(prPost);
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }

            Name = item.Name;
            Description = item.Description;
            Spoilers = item.Spoilers;
            Imgs = item.Imgs;
            TorrentPath = item.TorrentPath;
            Prepost = prPost;
        }
    }
}
