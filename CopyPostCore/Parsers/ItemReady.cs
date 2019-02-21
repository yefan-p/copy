using System.Collections.Generic;

namespace CopyPostCore.Parsers
{
    public class ItemReady
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ItemSpoiler> Spoilers { get; set; }
        public List<ItemImg> Imgs { get; set; }
    }
}
