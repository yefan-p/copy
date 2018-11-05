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
        public int ProgramID { get; set; }
        public int PrepostID { get; set; }

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
            PrepostID = prPost.id;
        }

        public void Add()
        {
            mydbContext mydb = new mydbContext();
            posts post = new posts
            {
                name = Name,
                description = Description,
                date_public = DatePublic,
                file = TorrentPath,
                pre_post = PrepostID,
                program_id = ProgramID,
                visible = 1,
                count_view = 0
            };
            mydb.posts.Add(post);
            mydb.SaveChanges();

            post = mydb.posts
                    .OrderByDescending(el => el.id)
                    .First();

            foreach (string item in Imgs)
            {
                images img = new images
                {
                    href = item,
                    posts = post
                };
                mydb.images.Add(img);
            }
            mydb.SaveChanges();

            foreach (SpoilersItem item in Spoilers)
            {
                spoilers spoiler = new spoilers
                {
                    name = item.name,
                    content = item.content,
                    posts = post
                };
                mydb.spoilers.Add(spoiler);
            }
            mydb.SaveChanges();

            preposts prPost = mydb.preposts.Single(el => el.id == PrepostID);
            prPost.itpublic = 1;
            mydb.SaveChanges();

            Program.statusBarGlobal.Message = "Добавление поста";
            Program.statusBarGlobal.Description = "Пост успешно добавлен.";
        }
    }
}
