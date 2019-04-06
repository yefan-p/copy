using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPostCore;
using CopyPostCore.DataBase;
using CopyPostCore.Parsers;
using HtmlAgilityPack;

namespace TorrentSoftAutoAddPost.Model
{
    /// <summary>
    /// Превращает объект поста из базы данных в объект поста для заполнения
    /// </summary>
    public class PostController
    {
        /// <summary>
        /// Содержит отфоматированный готовый к добавлению пост
        /// </summary>
        public BrowserPost BrowserPostReady { get; private set; } = new BrowserPost();

        public PostController(ReadyPost readyPost)
        {
            string description = DeleteImgs(readyPost.Description);
            description = description.Replace("<br>", "");
            description = description.Replace("<div></div>", "");

            BrowserPostReady.Name = readyPost.Name;
            BrowserPostReady.Description = description;
            SetSpoilers(readyPost);
            SetScreens(readyPost.Imgs.ToList());
            SetPoster(readyPost.Imgs.ToList());
        }

        /// <summary>
        /// Вызывает форму выбора постера для поста
        /// </summary>
        /// <param name="imgs">Возвращает выбранные uri постера</param>
        private void SetPoster(List<Img> imgs)
        {
            var viewsImgs = from el in imgs
                            where el.TypeImg.idTypeImg == (int)TImg.View
                            select el.Uri;

            FormSelectPoster formSelectPoster = new FormSelectPoster(viewsImgs.ToList());
            formSelectPoster.PosterSelected += FormSelectPoster_PosterSelected;
            formSelectPoster.ShowDialog();
        }

        private void FormSelectPoster_PosterSelected(object sender, PosterSelectedArgs e)
        {
            BrowserPostReady.Poster = e.PosterUri;
        }

        private void SetScreens(List<Img> imgs)
        {
            var result = from el in imgs
                         where el.TypeImg_idTypeImg == (int)TImg.Screenshot
                         select el;

            ParserImgs parserImgs = new ParserImgs();
            BrowserPostReady.Screenshot = parserImgs.DirectListManager(result.ToList());
        }

        /// <summary>
        /// Удаляет все изображения из описания, ссылки которые отсутсвуют в white листе
        /// </summary>
        /// <param name="description">Изначальная строка описания</param>
        /// <returns>Новая строка описания</returns>
        private string DeleteImgs(string description)
        {
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(description);

            HtmlNode htmlNode = htmlDocument.DocumentNode;
            HtmlNodeCollection nodesImg = htmlNode.SelectNodes(@"//img");

            if (nodesImg != null)
            {
                foreach (var item in nodesImg)
                {
                    string src = item.GetAttributeValue("src", "");
                    if (!Settings.WhiteListImgs.Contains(src))
                    {
                        item.Remove();
                    }
                }
            }

            return htmlNode.OuterHtml;
        }

        /// <summary>
        /// Добавляет спойлеры к описанию
        /// </summary>
        /// <param name="readyPost">Пост из базы данных</param>
        private void SetSpoilers(ReadyPost readyPost)
        {
            string spoilersResult = "";

            foreach (var item in readyPost.Spoilers)
            {
                spoilersResult += $"[spoiler={item.Header}]{item.Body}[/spoiler]";
            }

            BrowserPostReady.Description += spoilersResult;
        }
    }
}
