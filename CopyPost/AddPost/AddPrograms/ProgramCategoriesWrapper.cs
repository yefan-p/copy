using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyPost.AddPost.AddPrograms
{
    class ProgramCategoriesWrapper
    {
        public void Add(DataGridViewSelectedRowCollection CategorsSelected)
        {
            mydbContext mydb = new mydbContext();
            programs prog = mydb.programs
                                    .OrderByDescending(el => el.id)
                                    .First();

            foreach (DataGridViewRow item in CategorsSelected)
            {
                int idCategory = int.Parse(item.Cells[0].Value.ToString());
                categories category = mydb.categories.Single(el => el.id == idCategory);

                program_categories program_Categories = new program_categories
                {
                    programs = prog,
                    categories = category
                };
                mydb.program_categories.Add(program_Categories);
            }
            mydb.SaveChanges();
        }
    }
}
