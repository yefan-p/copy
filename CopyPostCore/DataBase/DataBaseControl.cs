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
        /// <summary>
        /// Возвращает указанное количество последних найденных записей с указанным трекером из бд
        /// </summary>
        /// <param name="trakers">Выбранный трекер</param>
        /// <param name="numberRows">Необходимое количество записей. По умолчанию 100.</param>
        /// <returns></returns>
        public List<ItemList> GetLastRecordList(TTrakers trakers, int numberRows = Settings.NumbersRowsSelect)
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
                    Index = el.idFoundPost,
                };

            List<ItemList> lastPrepost = prepostsQuery.Take(numberRows).ToList();
            return lastPrepost;
        }

        /// <summary>
        /// Добавляет новые записи предварительных раздач в бд
        /// </summary>
        /// <param name="foundedPost">Список добавляемых раздач</param>
        /// <param name="traker">В какой трекер добавлять</param>
        /// <returns>Возвращает количество записей, которые добавили в бд</returns>
        public int AddNewRecordList(List<ItemList> foundedPost, TTrakers traker)
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

            int result = db.SaveChanges();
            return result;
        }
    }
}
