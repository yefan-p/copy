using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPostCore;
using CopyPostCore.DataBase;
using CopyPostCore.Parsers;

namespace UpdateDatabase
{
    class MainPresenter
    {
        public MainPresenter()
        {
            counter = 0;
            readyPosts = new List<ReadyPost>();

            ParserRutor parserRutor = new ParserRutor();
            parserRutor.FoundPostsReceived += ParserRutor_FoundPostsReceived;
            parserRutor.StartGetList();
        }

        private void ParserRutor_FoundPostsReceived(object sender, FoundPostArgs e)
        {
            DataBaseControl db = new DataBaseControl();
            List<FoundPost> oldPosts = db.GetLastFounded(TTrakers.Rutor);

            ParserRutor parserRutor = new ParserRutor();

            List<FoundPost> newPosts = e.FoundPosts;
            newPosts = parserRutor.DeleteDuplicateFromList(oldPosts, newPosts);
            foundPosts = newPosts;

            foreach (var item in newPosts)
            {
                parserRutor.ReadyPostsReceived += ParserRutor_ReadyPostsReceived;
                parserRutor.StartGetItem(item);
            }
        }

        private List<FoundPost> foundPosts;
        private List<ReadyPost> readyPosts;
        private int counter;

        private void ParserRutor_ReadyPostsReceived(object sender, ReadyPostArgs e)
        {
            readyPosts.Add(e.ReadyPostRecieved);
            counter++;
            if (foundPosts.Count() == counter)
            {
                AddInDb();
            }
        }

        private void AddInDb()
        {
            DataBaseControl db = new DataBaseControl();
            db.AddFoundeds(foundPosts);
            db.Db.ReadyPost.AddRange(readyPosts);
            db.Db.SaveChanges();
        }
    }
}
