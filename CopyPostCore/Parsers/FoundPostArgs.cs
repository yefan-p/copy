using System;
using System.Collections.Generic;

namespace CopyPostCore.Parsers
{
    public class FoundPostArgs : EventArgs
    {
        public FoundPostArgs(List<FoundPost> foundPosts)
        {
            FoundPosts = foundPosts;
        }

        public List<FoundPost> FoundPosts { get; private set; }
    }
}
