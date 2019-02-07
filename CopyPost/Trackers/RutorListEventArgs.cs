using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPost.Trackers
{
    public class RutorListEventArgs : EventArgs
    {
        public RutorListEventArgs(List<TrackersListItem> posts)
        {
            Posts = posts;
        }

        public List<TrackersListItem> Posts { get; private set; }
    }
}
