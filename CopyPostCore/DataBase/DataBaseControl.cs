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
        public DataBaseControl()
        {
            Db = new autoParsingContext();
        }

        public autoParsingContext Db { get; private set; }

        /// <summary>
        /// Возвращает указанное количество последних найденных записей с указанным трекером из бд
        /// </summary>
        /// <param name="trakers">Выбранный трекер</param>
        /// <param name="numberRows">Необходимое количество записей. По умолчанию 100.</param>
        /// <returns></returns>
        public List<FoundPost> GetLastFounded(TTrakers trakers, int numberRows = Settings.NumbersRowsSelect)
        {
            var foundPostsQuery =
                (from el in Db.FoundPost
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
        public int AddFoundeds(List<FoundPost> foundedPost)
        {
            Db.FoundPost.AddRange(foundedPost);
            int result = Db.SaveChanges();
            return result;
        }

        /// <summary>
        /// Добавляет новую запись готового поста в бд
        /// </summary>
        /// <param name="readyPost">Готовый пост, который нужно добавить</param>
        /// <returns></returns>
        public int AddReady(ReadyPost readyPost)
        {
            Db.ReadyPost.Add(readyPost);
            int result = Db.SaveChanges();
            return result;
        }

        /// <summary>
        /// Добавляет несколько новых записей готовых постов в бд
        /// </summary>
        /// <param name="readyPost"></param>
        /// <returns></returns>
        public int AddReady(List<ReadyPost> readyPost)
        {
            Db.ReadyPost.AddRange(readyPost);
            int result = Db.SaveChanges();
            return result;
        }
    }
}
