using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyPost
{
    public partial class Form_AddProgram : Form
    {
        bool addProgram;

        public Form_AddProgram(bool programAdd, string name)
        {
            InitializeComponent();
            GetCategories();
            GetPlatforms();

            textBox_Name.Text = name;

            dataGridView_Categories.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView_Platforms.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void GetCategories()
        {
            DataBase dataBase = new DataBase();
            string sql =
                        @"SELECT 
                            ru_name
                        FROM
                            categories";
            DataTable dataTable = dataBase.SendReqest(sql);
            dataGridView_Categories.DataSource = dataTable;
        }

        private void GetPlatforms()
        {
            DataBase dataBase = new DataBase();
            string sql =
                        @"SELECT 
                            platforms.name
                        FROM
                            platforms";
            DataTable dataTable = dataBase.SendReqest(sql);
            dataGridView_Platforms.DataSource = dataTable;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int platformsId = dataGridView_Platforms.CurrentRow.Index + 1;
            DataGridViewSelectedRowCollection selectedRowsCategories = dataGridView_Categories.SelectedRows;

            addingPrograms.NewProgram(textBox_Name.Text, textBox_Suit.Text, platformsId.ToString(), selectedRowsCategories);
            Close();
        }
    }
}
