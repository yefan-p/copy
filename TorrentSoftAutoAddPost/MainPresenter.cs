using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorrentSoftAutoAddPost.Model;
using CopyPostCore;

namespace TorrentSoftAutoAddPost
{
    public class MainPresenter
    {
        /// <summary>
        /// Интрефейс формы выбора поста для публикации
        /// </summary>
        private readonly IFormSelectPost _formSelectPost;

        private readonly BrowserManager browser = new BrowserManager();

        public MainPresenter(IFormSelectPost formSelectPost)
        {
            _formSelectPost = formSelectPost;
            _formSelectPost.GridNotPublishedClick += _formSelectPost_GridNotPublishedClick;
            browser.Open();

            RefreshGridsForm();
        }

        private void _formSelectPost_GridNotPublishedClick(object sender, GridNotPublishedClickArgs e)
        {
            DataBaseSoftController dataBase = new DataBaseSoftController();
            ReadyPost readyPost = dataBase.GetBrowserPost(e.IdReadyPost);

            PostController postController = new PostController();
            postController.PostComplete += PostController_PostComplete;
            postController.GetBrowserPost(readyPost);
        }

        private void PostController_PostComplete(object sender, EventArgs e)
        {
            BrowserPost browserPost = (sender as PostController).BrowserPostReady;
            browser.FillPost(browserPost);

            DataBaseSoftController dataBase = new DataBaseSoftController();
            dataBase.AddTorrentSoftPost(browserPost.IdReadyPost);

            RefreshGridsForm();
        }

        /// <summary>
        /// Устанавливает значение для таблиц формы
        /// </summary>
        private void RefreshGridsForm()
        {
            DataBaseSoftController dataBase = new DataBaseSoftController();

            List<ReadyPost> readyPosts = dataBase.GetNotPublishedPost();
            List<ViewReadyPost> viewReadyPosts = ConvertReadyToView(readyPosts);
            _formSelectPost.SetNotPublishedPost(viewReadyPosts);

            List<TorrentSoftPost> torrentSoftPosts = dataBase.GetPublisedPost();
            List<ViewTorrentSoftPost> viewTorrentSoftPosts = ConvertTorrentSoftToView(torrentSoftPosts);
            _formSelectPost.SetPublishedPost(viewTorrentSoftPosts);
        }

        /// <summary>
        /// Превращает данные из базы данных в данные для формы.
        /// </summary>
        /// <param name="readyPosts">Готовые посты из бд.</param>
        /// <returns>Список для формы</returns>
        private List<ViewReadyPost> ConvertReadyToView(List<ReadyPost> readyPosts)
        {
            var viewQuery =
                from el in readyPosts
                select new ViewReadyPost
                {
                    Id = el.idReadyPost,
                    WasFounded = el.FoundedTime ?? DateTime.MinValue,
                    Name = el.Name,
                };

            List<ViewReadyPost> viewReadyPosts = viewQuery.ToList();
            return viewReadyPosts;
        }

        /// <summary>
        /// Превращает данные из базы данных в данные для формы.
        /// </summary>
        /// <param name="readyPosts">Торрент софт посты из бд.</param>
        /// <returns>Список для формы</returns>
        private List<ViewTorrentSoftPost> ConvertTorrentSoftToView(List<TorrentSoftPost> torrentSoftPosts)
        {
            var viewQuery =
                from el in torrentSoftPosts
                select new ViewTorrentSoftPost
                {
                    Id = el.idTorrentSoftPost,
                    ReadyPostId = el.ReadyPost_idReadyPost,
                    WasAdded = el.WasAdded ?? DateTime.MinValue,
                    Name = el.ReadyPost.Name,
                };

            List<ViewTorrentSoftPost> viewTorrentSoftPosts = viewQuery.ToList();
            return viewTorrentSoftPosts;
        }
    }
}
