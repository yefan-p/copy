using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPost.TorrentSoftExtensions
{
    class TorrentSoftPost
    {
        string description;
        List<SpoilersItem> spoilers;
        List<string> imgs;

        public string Name { get; set; }
        public string ImgPoster { get; private set; }
        public string SpoilersStr { get; set; }
        public string TorrentPath { get; set; }
        public DateTime DatePublic { get; set; }

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                description = "[justify]" + description + "[/justify]";
            }
        }

        public List<SpoilersItem> Spoilers
        {
            private get { return spoilers; }
            set
            {
                spoilers = value;

                foreach (var item in spoilers)
                {
                    string str = string.Format("[spoiler={0}]{1}[/spoiler]", item.name, item.content);
                    description += str;
                }
            }
        }

        public List<string> Imgs
        {
            get { return imgs; }
            set
            {
                imgs = value;
                if (imgs.Count != 0)
                {
                    ImgPoster = imgs.First();
                    imgs.Remove(ImgPoster);

                    List<string> onlyScreen = new List<string>();
                    for (int i = 0; i < 8 && i < imgs.Count; i++)
                        onlyScreen.Add(imgs[i]);

                    imgs = onlyScreen;
                }
            }
        }
    }
}
