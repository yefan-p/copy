using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPost.AddPost.ImgSwitch
{
    public class ImgItem
    {
        public string Poster { get; set; }
        public List<string> Views { get; set; }
        public List<string> Screens { get; set; }

        List<string> allCollection;

        public List<string> AllCollection
        {
            get
            {
                allCollection = new List<string>();
                if (Views != null)
                    allCollection.AddRange(Views);

                if (Screens != null)
                    allCollection.AddRange(Screens);

                return allCollection;
            }
            private set
            {
                allCollection = value;
            }
        }

        public bool ViewsAddOrDel(string img)
        {
            if (Views == null)
                Views = new List<string>();

            if (Views.Contains(img))
            {
                Views.Remove(img);
                return false;
            }
            else
            {
                Views.Add(img);
                return true;
            }
        }

        public bool ScreensAddOrDel(string img)
        {
            if (Screens == null)
                Screens = new List<string>();

            if (Screens.Contains(img))
            {
                Screens.Remove(img);
                return false;
            }
            else
            {
                Screens.Add(img);
                return true;
            }
        }
    }
}
