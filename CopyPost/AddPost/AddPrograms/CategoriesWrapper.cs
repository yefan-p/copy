using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyPost.AddPost.AddPrograms
{
    class CategoriesWrapper
    {
        public BindingSource Get()
        {
            BindingSource bs = new BindingSource();
            mydbContext mydb = new mydbContext();

            var query =
                from el in mydb.categories
                select new
                {
                    category = el.ru_name
                };

            bs.DataSource = query.ToList();
            return bs;
        }
    }
}
