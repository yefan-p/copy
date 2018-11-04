using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyPost.Trackers;

namespace CopyPost
{
    public partial class Form_Main : Form
    {
        PostList postList;

        public Form_Main()
        {
            InitializeComponent();

            Program.statusBarGlobal.onChangeDescription += StatusBarGlobal_onChangeDescription;
            Program.statusBarGlobal.onChangeMessage += StatusBarGlobal_onChangeMessage;
            Program.statusBarGlobal.onChangeProgress += StatusBarGlobal_onChangeProgress;

            postList = new PostList();
            postList.onAfterAdd += PostList_onAfterAdd;
            postList.Initialize();
        }

        private void PostList_onAfterAdd(object sender, EventArgs e)
        {
            mydbContext mydb = new mydbContext();

            var preposts =
                from el in mydb.preposts
                where el.itpublic == 0
                orderby el.id descending
                select new
                {
                    id = el.id,
                    date = el.date,
                    trackerName = el.tracker1.name,
                    name = el.name
                };

            dataGridView_NewPost.DataSource = preposts.ToList();
        }

        private void StatusBarGlobal_onChangeProgress(object sender, EventArgs e)
        {
            Status_ProgressBar.Value = Program.statusBarGlobal.Progress;
            Status_ProgressBar.Visible = Program.statusBarGlobal.VisibleProgress;
        }

        private void StatusBarGlobal_onChangeMessage(object sender, EventArgs e)
        {
            StatusLabel_Message.Text = Program.statusBarGlobal.Message;
        }

        private void StatusBarGlobal_onChangeDescription(object sender, EventArgs e)
        {
            StatusLabel_Descript.Text = Program.statusBarGlobal.Description;
        }

        private void rutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RutorList rutorList = new RutorList();
            postList.Add(rutorList);
        }

        private void опубликоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRows = dataGridView_NewPost.SelectedRows[0].Index;          // получаем значение из выделенной строки первой колонки.
            string idPrepost = dataGridView_NewPost.Rows[selectedRows].Cells[0].Value.ToString();

            mydbContext mydb = new mydbContext();
            preposts prPost = mydb.preposts.Single(n => n.id.ToString() == idPrepost);

            Form_AddPost form_AddPost = new Form_AddPost(prPost);
            form_AddPost.ShowDialog();
        }
    }
}
