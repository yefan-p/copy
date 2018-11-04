using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPost.Trackers
{
    public class TrackersListItem
    {
        public string Name { get; set; }
        public string Href { get; set; }
        public int Index { get; set; }
    }

    public interface ITrackersList
    {
        List<TrackersListItem> Posts { get; }
        Func<tracker, bool> TrackerExpression { get; }
    }
}
