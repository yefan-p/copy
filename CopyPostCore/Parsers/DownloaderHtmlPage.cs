using System;
using System.Net;
using System.Text;
using MihaZupan;
using HtmlAgilityPack;
using System.Collections.Specialized;

namespace CopyPostCore.Parsers
{
    public class DownloaderThroughTor
    {
        /// <summary>
        /// Начинает загрузку HTML страницы асинхронно
        /// </summary>
        /// <param name="uri">Указывает, какую страницу загружать</param>
        public void StartDownloadAsync(Uri uri)
        {
            // Стандартный способ загрузки страниц из AgilityPack не подходит
            // так как он не может скачивать через Tor прокси
            WebClient client = new WebClient();
            HttpToSocks5Proxy proxy = new HttpToSocks5Proxy("127.0.0.1", 9050);
            client.Proxy = proxy;

            client.DownloadDataCompleted += Client_DownloadDataCompleted;
            client.DownloadDataAsync(uri);
        }

        /// <summary>
        /// Возникает после окончания загрузки страницы
        /// </summary>
        public event EventHandler<DownloaderHtmlPageArgs> FinishDownload;

        private void Client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                byte[] dataArray = e.Result; //ставим правильную кодировку для данных, инчае будут
                string page = Encoding.UTF8.GetString(dataArray); //корикозябры вместо кириллицы

                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(page); //делаем страницу из string

                DownloaderHtmlPageArgs args = new DownloaderHtmlPageArgs(doc);
                FinishDownload?.Invoke(this, args); //вызываем событие, аналог if(OnPageDow!=null)
            }
            else
            {
                MessageService.ShowError("Ошибка подключения при запросе списка торрентов.");
            }
        }

        public HtmlDocument Page(Uri uri)
        {
            WebClient client = new WebClient();
            HttpToSocks5Proxy proxy = new HttpToSocks5Proxy("127.0.0.1", 9050);
            client.Proxy = proxy;

            byte[] dataArray = client.DownloadData(uri);
            string page = Encoding.UTF8.GetString(dataArray);

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(page);

            return doc;
        }

        /// <summary>
        /// Начинает загружать файл через прокси тор асинхронно
        /// </summary>
        /// <param name="uri">Откуда необходимо скачать файл</param>
        /// <param name="fileName">Куда необходимо сохранить файл</param>
        public void FileAsync(Uri uri, string fileName)
        {
            WebClient client = new WebClient();
            HttpToSocks5Proxy proxy = new HttpToSocks5Proxy("127.0.0.1", 9050);
            client.Proxy = proxy;

            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            client.DownloadFileAsync(uri, fileName);
        }

        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                MessageService.ShowMessage("Файл успешно загружен");
            }
            else
            {
                MessageService.ShowError($"При загрузке файла произошла ошибка. {e.Error.Message}");
            }
        }
    }
}
