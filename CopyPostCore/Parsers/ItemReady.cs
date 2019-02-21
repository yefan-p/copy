using System.Collections.Generic;

namespace CopyPostCore.Parsers
{
    public class ItemReady
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ItemSpoiler> Spoilers { get; set; }
        public List<ItemImg> Imgs { get; set; }
        public  string TorrentUrl { get; set; }

        /// <summary>
        /// Содержит информацию о том, из какого найденного поста получился текущий пост
        /// Необходим для заполнения бд
        /// </summary>
        public ItemList FoundedItem { get; set; }
    }
}
