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
        public List<FoundPost> GetLastRecordList(TTrakers trakers, int numberRows = Settings.NumbersRowsSelect)
        {
            autoParsingContext mydb = new autoParsingContext();

            var foundPostsQuery =
                (from el in mydb.FoundPost
                where el.TorrentTracker.idTorrentTracker == (int)trakers
                orderby el.idFoundPost descending
                select el as FoundPost);

            List<FoundPost> lastPrepost = foundPostsQuery.Take(numberRows).ToList();
            return lastPrepost;
        }

        /// <summary>
        /// Добавляет новые записи предварительных раздач в бд
        /// </summary>
        /// <param name="foundedPost">Список добавляемых раздач</param>
        /// <returns>Возвращает количество записей, которые добавили в бд</returns>
        public int AddNewRecordList(List<FoundPost> foundedPost)
        {
            autoParsingContext db = new autoParsingContext();
            db.FoundPost.AddRange(foundedPost);

            int result = db.SaveChanges();
            return result;
        }
    }
}
