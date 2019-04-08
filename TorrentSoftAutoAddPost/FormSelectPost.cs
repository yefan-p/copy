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
        void SetNotPublishedPost(List<ViewReadyPost> listPost);
        void SetPublishedPost(List<ViewTorrentSoftPost> listPost);
        event EventHandler<GridNotPublishedClickArgs> GridNotPublishedClick;
    }

    public partial class FormSelectPost : Form, IFormSelectPost
    {
        public FormSelectPost()
        {
            InitializeComponent();
            grid_NotPublished.CellDoubleClick += Grid_NotPublished_CellDoubleClick;
            grid_Published.SelectionChanged += Grid_Published_MultiSelectChanged;
        }

        private void Grid_Published_MultiSelectChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int count = dataGrid.SelectedRows.Count;
            ToolTip toolTip = new ToolTip();
            IWin32Window win = this;
            toolTip.Show(count.ToString(), win, Cursor.Position, 2500);
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

        public void SetNotPublishedPost(List<ViewReadyPost> listPost)
        {
            grid_NotPublished.DataSource = listPost;
        }

        public void SetPublishedPost(List<ViewTorrentSoftPost> listPost)
        {
            grid_Published.DataSource = listPost;
        }

        public event EventHandler<GridNotPublishedClickArgs> GridNotPublishedClick;
    }
}
