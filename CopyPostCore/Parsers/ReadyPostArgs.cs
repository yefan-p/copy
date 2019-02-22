using System;

namespace CopyPostCore.Parsers
{
    public class ReadyPostArgs : EventArgs
    {
        public ReadyPostArgs(ReadyPost readyPost)
        {
            ReadyPostRecieved = readyPost;
        }

        public ReadyPost ReadyPostRecieved { get; private set; }
    }
}
