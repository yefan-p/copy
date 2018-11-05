using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyPost
{
    class SearchList
    {
        public static BindingSource UpdateProgramsGrid(string searchName)
        {
            mydbContext mydb = new mydbContext();
            var query =
                from el in mydb.programs
                where el.name.Contains(searchName)
                orderby el.name
                select new
                {
                    el.id,
                    el.name,
                    platform = el.platforms.name
                };

            BindingSource binding = new BindingSource();
            binding.DataSource = query.ToList();
            return binding;
        }
    }
}
