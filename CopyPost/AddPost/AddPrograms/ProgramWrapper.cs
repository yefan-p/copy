using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPost.AddPost.AddPrograms
{
    class ProgramWrapper
    {
        public string Name { get; set; }
        public string Site { get; set; }
        public int PlatformsID { get; set; }

        public void Add()
        {
            if (Name == null || Site == null || PlatformsID <= 0) { return; }

            mydbContext mydb = new mydbContext();
            platforms platform = mydb.platforms.Single(el => el.id == PlatformsID);

            programs prog = new programs
            {
                name = Name,
                off_site = Site,
                platforms = platform
            };

            mydb.programs.Add(prog);
            mydb.SaveChanges();
        }
    }
}
