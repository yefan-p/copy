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

        /// <summary>
        /// Ссылки на изображения, которые используются при оформлении поста для указания
        /// системных требований
        /// </summary>
        public static List<string> WhiteListImgs = new List<string>(new string[] 
            {
                @"http://img11.lostpic.net/2017/01/17/71bd8a93f3303507e1c026261abf7ab4.png",
                @"http://s013.radikal.ru/i324/1508/b3/bd532b0f09a3.png",
                @"https://d.radikal.ru/d25/1809/4b/ba5f44c921c2.png",
                @"https://d.radikal.ru/d00/1806/0a/77b025f85e94.png",
                @"http://s011.radikal.ru/i316/1508/ec/e0232836c69c.png",
                @"http://img11.lostpic.net/2016/12/07/f9c17412fb839c9f812edf427434fe3e.png",
                @"https://a.radikal.ru/a21/1812/26/6655f0fcef27.png",
            });
    }
}
