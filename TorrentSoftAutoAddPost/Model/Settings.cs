using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TorrentSoftAutoAddPost.Model
{
    public class Settings
    {
        /// <summary>
        /// Количество записей, которые будут отображатся на форме 
        /// в таблице не опубликованных постов
        /// </summary>
        public static int NotPublishedCount = 100;

        /// <summary>
        /// Количество записей, которые будут отображатся на форме 
        /// в таблице опубликованных постов
        /// </summary>
        public static int PublishedCount = 100;

        /// <summary>
        /// Директория пользовательского профиля Firefox для Selenium.
        /// В Firefox можно узнать в Справка > Информация для решения проблем > Папка профиля
        /// </summary>
        public static string FirefoxProfileDir = @"C:\Users\User\AppData\Roaming\Mozilla\Firefox\Profiles\gazt4y16.default";

        /// <summary>
        /// Url страницы, на которой производится добавление постов на сайт торрентСофт
        /// </summary>
        public static string TorrentSoftUri = @"http://torrent-soft.net/admin-panel.php?mod=addnews&action=addnews";

        /// <summary>
        /// Это строка при передачи ее в метод объекта Selenium SendKeys, 
        /// вставит текст из буфера обмена. Это используется, потому что если передавать просто строку
        /// текста, то Selenium будет набирать ее слишком долго.
        /// </summary>
        public static string PasteClipboardSelenium = $"{Keys.Control}v{Keys.Control}";
    }
}
