using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPost.Parsers;

namespace CopyPost.DataBase
{
    public class DataBaseControl
    {
        /// <summary>
        /// Возвращает последение 100 предварительных раздач
        /// </summary>
        /// <returns></returns>
        public List<ItemList> GetLastRecordListRutor()
        {
            dbParsingContext mydb = new dbParsingContext();

            var prepostsQuery =
                from el in mydb.FoundPost
                where el.TorrentTracker.idTorrentTracker == (int)TTrakers.Rutor
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
    }
}
