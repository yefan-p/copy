using System;

namespace CopyPostCore.Parsers
{
    public class ItemReadyArgs : EventArgs
    {
        public ItemReadyArgs(ItemReady item)
        {
            ReadyPost = item;
        }

        public ItemReady ReadyPost { get; private set; }
    }
}
