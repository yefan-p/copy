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
        /// <summary>
        /// Получает из бд уже опубликованные на torrentSoft посты
        /// </summary>
        /// <returns></returns>
        public List<TorrentSoftPostApp> GetPublisedPost()
        {
            autoParsingContext context = new autoParsingContext();

            var publishedQuery =
                from softPost in context.TorrentSoftPost
                join readyPost in context.ReadyPost
                    on softPost.ReadyPost_idReadyPost equals readyPost.idReadyPost
                select new TorrentSoftPostApp
                {
                    IdReadyPost = readyPost.idReadyPost,
                    WasAdded = softPost.WasAdded ?? DateTime.Now,
                    Name = readyPost.Name,
                    ReadyPostDb = readyPost,
                };

            List<TorrentSoftPostApp> torrentSofts = publishedQuery.Take(Settings.PublishedCount).ToList();

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
                select readyPost.idReadyPost;
            List<int> publishedId = publishedQuery.Take(Settings.NotPublishedCount).ToList();

            //Выбираем только те id, которые отсутвуют в повторяющихся
            List<ReadyPost> notPublishedPost = context.ReadyPost
                          .Where(i => !publishedId.Contains(i.idReadyPost))
                          .Take(Settings.NotPublishedCount)
                          .ToList();

            return notPublishedPost;
        }
    }
}
