using System.Collections.Generic;

namespace CopyPost.Trackers
{
    public interface ITrackersItem
    {
        string Name { get; }
        string Description { get; }
        List<SpoilersItem> Spoilers { get; }
        List<string> Imgs { get; }
        string TorrentPath { get; }
    }
}
