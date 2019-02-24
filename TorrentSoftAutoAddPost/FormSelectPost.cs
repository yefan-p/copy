using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyPostCore;
using TorrentSoftAutoAddPost.Model;

namespace TorrentSoftAutoAddPost
{
    public interface IFormSelectPost
    {
        void SetNotPublishedPost(List<ReadyPostView> listPost);
        void SetPublishedPost(List<TorrentSoftPostView> listPost);
        event EventHandler<GridNotPublishedClickArgs> GridNotPublishedClick;
    }

    public partial class FormSelectPost : Form, IFormSelectPost
    {
        public FormSelectPost()
        {
            InitializeComponent();
            grid_NotPublished.CellDoubleClick += Grid_NotPublished_CellDoubleClick;
        }

        private void Grid_NotPublished_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // получаем выделенную строку
            int selectedRows = grid_NotPublished.SelectedRows[0].Index;
            // получаем значение из первой колонки этой строки
            string value = grid_NotPublished.Rows[selectedRows].Cells[0].Value.ToString();

            GridNotPublishedClickArgs args = new GridNotPublishedClickArgs(value);
            GridNotPublishedClick?.Invoke(this, args);
        }

        public void SetNotPublishedPost(List<ReadyPostView> listPost)
        {
            grid_NotPublished.DataSource = listPost;
        }

        public void SetPublishedPost(List<TorrentSoftPostView> listPost)
        {
            grid_Published.DataSource = listPost;
        }

        public event EventHandler<GridNotPublishedClickArgs> GridNotPublishedClick;
    }
}
