using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyPost.AddPost.AddPrograms;

namespace CopyPost
{
    public partial class Form_AddProgram : Form
    {
        public Form_AddProgram(bool programAdd, string name)
        {
            InitializeComponent();
            CategoriesWrapper categoriesWrapper = new CategoriesWrapper();
            PlatformsWrapper platformsWrapper = new PlatformsWrapper();

            dataGridView_Categories.DataSource = categoriesWrapper.Get();
            dataGridView_Platforms.DataSource = platformsWrapper.Get();

            dataGridView_Categories.Columns[0].Visible = false;
            dataGridView_Platforms.Columns[0].Visible = false;

            textBox_Name.Text = name;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRows = dataGridView_Platforms.SelectedRows[0].Index;
            string idPlatformString = dataGridView_Platforms.Rows[selectedRows].Cells[0].Value.ToString();
            int idPlatform = int.Parse(idPlatformString);

            ProgramWrapper programWrapper = new ProgramWrapper();
            programWrapper.Name = textBox_Name.Text;
            programWrapper.Site = textBox_Suit.Text;
            programWrapper.PlatformsID = idPlatform;
            programWrapper.Add();

            DataGridViewSelectedRowCollection selectedRowsCategories = dataGridView_Categories.SelectedRows;
            ProgramCategoriesWrapper programCategoriesWrapper = new ProgramCategoriesWrapper();
            programCategoriesWrapper.Add(selectedRowsCategories);            
            
            Close();
        }
    }
}
