using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPostCore;
using CopyPostCore.DataBase;
using CopyPostCore.Parsers;
using HtmlAgilityPack;
using System.IO;

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

        public event EventHandler PostComplete;

        public void GetBrowserPost(ReadyPost readyPost)
        {
            string description = DeleteImgs(readyPost.Description);
            description = DeleteSpace(description);
            //description = FormatImg(description);

            BrowserPostReady.IdReadyPost = readyPost.idReadyPost;
            BrowserPostReady.Name = readyPost.Name;
            BrowserPostReady.Description = description;

            SetSpoilers(readyPost);
            SetPoster(readyPost.Imgs.ToList());
            SetScreens(readyPost.Imgs.ToList());
            SetTorrentFile(readyPost);
        }

        /// <summary>
        /// Вызывает форму выбора постера для поста
        /// </summary>
        /// <param name="imgs">Возвращает выбранные uri постера</param>
        private void SetPoster(List<Img> imgs)
        {
            var viewsImgs = from el in imgs
                            where el.TypeImg.idTypeImg == (int)TImg.View 
                                && !Settings.WhiteListImgs.Contains(el.Uri)
                            select el.Uri;

            if (viewsImgs.Count() > 1)
            {
                FormSelectPoster formSelectPoster = new FormSelectPoster(viewsImgs.ToList());
                formSelectPoster.PosterSelected += FormSelectPoster_PosterSelected;
                formSelectPoster.ShowDialog();
            }
            else
            {
                BrowserPostReady.Poster = viewsImgs.First();
            }
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

        private void SetTorrentFile(ReadyPost readyPost)
        {
            string today = DateTime.Today.ToShortDateString();
            string folderName = Environment.CurrentDirectory + $"\\storage\\{today}";
            Directory.CreateDirectory(folderName);

            string fileName = GetSafeFilename(readyPost.Name);
            DownloaderThroughTor downloader = new DownloaderThroughTor();

            Uri uriFile = new Uri(ParserRutor.Main.OriginalString + readyPost.TorrentUrl);
            downloader.FinishedDownoadFile += Downloader_FinishedDownoadFile;
            downloader.FileAsync(uriFile, $"{folderName}\\{fileName}.torrent");

            BrowserPostReady.TorrentFile = $"{folderName}\\{fileName}.torrent";
        }

        private void Downloader_FinishedDownoadFile(object sender, EventArgs e)
        {
            PostComplete?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Возвращает строку, котора может быть использована для имени файла win
        /// </summary>
        /// <param name="filename">Строка в которой могут содержаться недопустимые символы в имени файла</param>
        /// <returns></returns>
        public string GetSafeFilename(string filename)
        {
            string[] stringArr = filename.Split(Path.GetInvalidFileNameChars());
            return string.Join("", stringArr);
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
        /// Удаляет лишние пробелы из описания
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        private string DeleteSpace(string description)
        {
            description = description.Replace("<div></div>", "");

            description = description.Replace("<hr>", "");
            description = description.Replace("<br>", "");

            while (description.Contains(Environment.NewLine + Environment.NewLine))
            {
                description = description.Replace(Environment.NewLine + Environment.NewLine, Environment.NewLine);
            }
            return description;
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

            if (BrowserPostReady.Description.EndsWith(Environment.NewLine))
            {
                BrowserPostReady.Description += Environment.NewLine;
            }
            else
            {
                BrowserPostReady.Description += Environment.NewLine + Environment.NewLine;
            }

            BrowserPostReady.Description += spoilersResult;
        }

        /// <summary>
        /// Находит изображения и форматирует их
        /// </summary>
        /// <param name="description">Описание с возможными изображениями</param>
        /// <returns></returns>
        private string FormatImg(string description)
        {
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(description);

            HtmlNode htmlNode = htmlDocument.DocumentNode;
            HtmlNodeCollection nodesImg = htmlNode.SelectNodes(@"//img");

            HtmlNode brElement = HtmlNode.CreateNode("<br>");

            if (nodesImg != null && nodesImg.Count() == 1)
            {
                htmlNode.InsertAfter(brElement, nodesImg.First());
            }

            return htmlNode.OuterHtml;
        }
    }
}
