using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPost.Trackers;
using CopyPost.AddPost.ImgSwitch;

namespace CopyPost
{
    public class SpoilersItem
    {
        public string name;
        public string content;
    }

    class Post
    {
        ITrackersItem item;

        public string Name { get; set; }
        public string Description { get; set; }
        public ImgItem Imgs { get; set; }
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
                    item = new RutorItem();
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }

            Name = item.Name;
            Description = item.Description;
            Spoilers = item.Spoilers;
            TorrentPath = item.TorrentPath;
            PrepostID = prPost.id;

            SwithcAndFilterImg(item);
        }

        private void SwithcAndFilterImg(ITrackersItem item)
        {
            Form_ImgSwitch form_ImgSwitch = new Form_ImgSwitch(item);
            form_ImgSwitch.ShowDialog();

            Description = form_ImgSwitch.Description;
            Spoilers = form_ImgSwitch.Spoilers;
            Imgs = form_ImgSwitch.Imgs;
        }

        #region Добавление в БД
        public void Add()
        {
            mydbContext mydb = new mydbContext();

            AddPost(mydb);

            posts post = mydb.posts
                    .OrderByDescending(el => el.id)
                    .First();

            AddScreen(mydb, post);
            AddSpoilers(mydb, post);

            preposts prPost = mydb.preposts.Single(el => el.id == PrepostID);
            prPost.itpublic = 1;
            mydb.SaveChanges();

            Program.statusBarGlobal.Message = "Добавление поста";
            Program.statusBarGlobal.Description = "Пост успешно добавлен.";
        }
        
        private void AddPost(mydbContext mydb)
        {
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
        }

        private void AddScreen(mydbContext mydb, posts post)
        {
            images img = new images
            {
                href = Imgs.Poster,
                type = "post",
                posts = post
            };
            mydb.images.Add(img);

            if (Imgs.Screens != null)
            foreach (string item in Imgs.Screens)
            {
                img = new images
                {
                    href = item,
                    type = "screen",
                    posts = post
                };
                mydb.images.Add(img);
            }

            if (Imgs.Views != null)
            foreach (string item in Imgs.Views)
            {
                img = new images
                {
                    href = item,
                    type = "view",
                    posts = post
                };
                mydb.images.Add(img);
            }
            mydb.SaveChanges();
        }

        private void AddSpoilers(mydbContext mydb, posts post)
        {
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
        }
        #endregion
    }
}
