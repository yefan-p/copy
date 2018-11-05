using System;
using System.Net;

namespace CopyPost
{
    class Downloader
    {

        public Downloader(string url, string fileName)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
            webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
            Program.statusBarGlobal.Message = "Начинаем загружать файл.";
            webClient.DownloadFileAsync(new Uri(url), fileName);
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Program.statusBarGlobal.SetProgress(e.ProgressPercentage, e.ProgressPercentage);
        }

        private void WebClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Program.statusBarGlobal.Description = "Загрузка файла завершилась ошибкой!";
                Program.statusBarGlobal.Message = e.Error.Message;
            }
            else
                Program.statusBarGlobal.Message = "Загрузка файла завершена успешно!";
        }
    }
}
