using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPostCore;

namespace TorrentSoftAutoAddPost.Model
{
    public class DataBaseSoftController
    {
        public DataBaseSoftController()
        {
            Db = new autoParsingContext();
        }

        public autoParsingContext Db { get; private set; }

        /// <summary>
        /// Получает из бд уже опубликованные на torrentSoft посты
        /// </summary>
        /// <returns></returns>
        public List<TorrentSoftPost> GetPublisedPost()
        {
            autoParsingContext context = new autoParsingContext();

            var publishedQuery =
                from softPost in context.TorrentSoftPost
                select softPost;

            List<TorrentSoftPost> torrentSofts = publishedQuery.Take(Settings.PublishedCount).ToList();

            return torrentSofts;
        }

        /// <summary>
        /// Получает из бд только не опубликованные на торрент софт посты
        /// </summary>
        /// <returns></returns>
        public List<ReadyPost> GetNotPublishedPost()
        {
            autoParsingContext context = new autoParsingContext();

            //Получаем повторяющиеся id 
            var publishedQuery =
                from softPost in context.TorrentSoftPost
                from readyPost in context.ReadyPost
                where softPost.ReadyPost_idReadyPost == readyPost.idReadyPost
                orderby readyPost.idReadyPost descending
                select readyPost.idReadyPost;
            List<int> publishedId = publishedQuery.Take(Settings.NotPublishedCount).ToList();

            //Выбираем только те id, которые отсутвуют в повторяющихся
            List<ReadyPost> notPublishedPost = context.ReadyPost
                          .Where(i => !publishedId.Contains(i.idReadyPost))
                          .OrderByDescending(i => i.idReadyPost)
                          .Take(Settings.NotPublishedCount)
                          .ToList();

            return notPublishedPost;
        }

        /// <summary>
        /// Получает готовый пост по id
        /// </summary>
        /// <param name="idReadyPost">id поста который необходимо выложить</param>
        /// <returns>Готовый пост</returns>
        public ReadyPost GetBrowserPost(int idReadyPost)
        {
            var queryPost =
                from el in Db.ReadyPost
                where el.idReadyPost == idReadyPost
                select el;

            ReadyPost readyPost = queryPost.Single();

            return readyPost;
        }
    }
}
