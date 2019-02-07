using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MihaZupan;
using HtmlAgilityPack;

namespace CopyPost.Global
{
    public class HTMLPage
    {
        public void SetPage(string URL)
        {
            WebClient client = new WebClient();
            //up необходимо для загрузки страницы с помощью socks5 proxy
            //стандратный метод из agility pack использует только http proxy
            HttpToSocks5Proxy proxy = new HttpToSocks5Proxy("127.0.0.1", 9050);
            //up тип из MihaZupan
            //необходим для использования socks5 прокси
            client.Proxy = proxy;

            Uri uri = new Uri(URL);
            client.DownloadDataCompleted += Client_DownloadDataCompleted;
            //up подписываемся на событие после окончания загрузки
            client.DownloadDataAsync(uri); //начинаем загрузку асинхронно
        }

        private void Client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            if (e.Error == null) //если все скачалось без ошибок
            {
                byte[] dataArray = e.Result; //ставим правильную кодировку для данных, инчае будут
                string page = Encoding.UTF8.GetString(dataArray); //корикозябры вместо кириллицы

                HtmlDocument doc = new HtmlDocument(); //тип из agility pack
                doc.LoadHtml(page); //делаем страницу из string

                HTMLPageEventArgs args = new HTMLPageEventArgs(doc, page); //делаем аргументы для события
                if (onPageDownload != null)
                {
                    onPageDownload(this, args); //вызываем событие
                }
            }
            else
            {
                Program.statusBarGlobal.Message = "Ошибка подключения при запросе списка торрентов";
            }
        }

        public event EventHandler<HTMLPageEventArgs> onPageDownload;
    }
}
