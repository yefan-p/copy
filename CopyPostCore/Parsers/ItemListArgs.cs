using System;
using System.Collections.Generic;

namespace CopyPostCore.Parsers
{
    public class ItemListArgs : EventArgs
    {
        public ItemListArgs(List<ItemList> list)
        {
            Posts = list;
        }

        public List<ItemList> Posts { get; private set; }
    }
}
