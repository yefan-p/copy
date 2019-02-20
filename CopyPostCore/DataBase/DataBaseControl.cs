using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPostCore.Parsers;

namespace CopyPostCore.DataBase
{
    public class DataBaseControl
    {
        public List<ItemList> GetLastRecordList(TTrakers trakers)
        {
            autoParsingContext mydb = new autoParsingContext();

            var prepostsQuery =
                from el in mydb.FoundPost
                where el.TorrentTracker.idTorrentTracker == (int)trakers
                orderby el.idFoundPost descending
                select new ItemList
                {
                    Href = el.Uri,
                    Magnet = el.Magnet,
                    Name = el.Name,
                };

            List<ItemList> lastPrepost = prepostsQuery.Take(Settings.NumbersRowsSelect).ToList();
            return lastPrepost;
        }

        public void AddNewRecordList(List<ItemList> foundedPost, TTrakers traker)
        {
            autoParsingContext db = new autoParsingContext();

            foreach (var item in foundedPost)
            {
                FoundPost fPost = new FoundPost
                {
                    Name = item.Name,
                    Magnet = item.Magnet,
                    Uri = item.Href,
                    FoundedTime = DateTime.Now,
                    TorrentTracker_idTorrentTracker = (int)traker,
                };
                db.FoundPost.Add(fPost);
            }
            db.SaveChanges();
        }
    }
}
