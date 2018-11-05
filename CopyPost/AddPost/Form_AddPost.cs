using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CopyPost
{
    public partial class Form_AddPost : Form
    {
        Slider<string> imgsSlider;
        Slider<SpoilersItem> spoilerSlider;
        SearchStr searchStr;
        Post post;

        public Form_AddPost(preposts prPost)
        {
            InitializeComponent();

            Program.statusBarGlobal.onChangeDescription += StatusBarGlobal_onChangeDescription;
            Program.statusBarGlobal.onChangeMessage += StatusBarGlobal_onChangeMessage;
            Program.statusBarGlobal.onChangeProgress += StatusBarGlobal_onChangeProgress;

            post = new Post(prPost);

            textBox_NamePost.Text = post.Name;

            textBox_TorrentFile.Text = post.TorrentPath;
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(post.TorrentPath);

            imgsSlider = new Slider<string>(post.Imgs);
            imgsSlider.onChangeSlide += ImgsSlider_onChangeImg;
            imgsSlider.Initialize();

            textBox_Description.Text = post.Description;

            spoilerSlider = new Slider<SpoilersItem>(post.Spoilers);
            spoilerSlider.onChangeSlide += SpoilerSlider_onChangeSlide;
            spoilerSlider.Initialize();

            searchStr = new SearchStr(post.Name);
            searchStr.onChangeName += SearchStr_onChangeName;
            textBox_SearchProgram.Text = searchStr.ShortName;

            dataGridView_Search.DataSource = SearchList.UpdateProgramsGrid(textBox_SearchProgram.Text);
            dataGridView_Search.Columns[0].Visible = false;
        }

        private void SearchStr_onChangeName(object sender, EventArgs e)
        {
            textBox_SearchProgram.Text = searchStr.ShortName;
            dataGridView_Search.DataSource = SearchList.UpdateProgramsGrid(textBox_SearchProgram.Text);
        }

        #region Слайдер со спойлерами
        private void SpoilerSlider_onChangeSlide(object sender, EventArgs e)
        {
            if (spoilerSlider.CurrentSlide.name != null)
            {
                SpoilersItem item = spoilerSlider.CurrentSlide;
                textBox_NameSpoiler.Text = item.name;
                textBox_SpoilerContent.Text = item.content;
                label_NumberSpoiler.Text = string.Format("{0}//{1}", spoilerSlider.IndexSlides + 1, spoilerSlider.SlidesCount);
            }
            else
            {
                textBox_NameSpoiler.Text = "";
                textBox_SpoilerContent.Text = "";
                label_NumberSpoiler.Text = string.Format("{0}//{1}", spoilerSlider.IndexSlides, spoilerSlider.SlidesCount);
            }
        }

        private void SpoilerSlider_SaveChange()
        {
            if (spoilerSlider.CurrentSlide.name != null)
            {
                SpoilersItem item = new SpoilersItem();
                item.name = textBox_NameSpoiler.Text;
                item.content = textBox_SpoilerContent.Text;
                spoilerSlider.CurrentSlide = item;
            }
        }

        private void button_NextSpoiler_Click(object sender, EventArgs e)
        {
            spoilerSlider.NextSlide();
        }

        private void button_preSpoiler_Click(object sender, EventArgs e)
        {
            spoilerSlider.PreviewSlide();
        }

        private void button_DeleteSpoiler_Click(object sender, EventArgs e)
        {
            spoilerSlider.DeleteSlide();
        }

        private void textBox_NameSpoiler_TextChanged(object sender, EventArgs e)
        {
            SpoilerSlider_SaveChange();
        }

        private void textBox_SpoilerContent_TextChanged(object sender, EventArgs e)
        {
            SpoilerSlider_SaveChange();
        }
        #endregion

        #region Слайдер с изображениями
        private void ImgsSlider_onChangeImg(object sender, EventArgs e)
        {
            if (imgsSlider.CurrentSlide != null)
            {
                textBox_ImgUrl.Text = imgsSlider.CurrentSlide;
                groupBox_ImgSlider.Text = string.Format("Изображения ({0} из {1})", imgsSlider.IndexSlides + 1, imgsSlider.SlidesCount);
            }
            else
            {
                pictureBox1.ImageLocation = "";
                textBox_ImgUrl.Text = "";
                groupBox_ImgSlider.Text = string.Format("Изображения ({0} из {1})", imgsSlider.IndexSlides, imgsSlider.SlidesCount);
            }
        }

        private void button_imgPreview_Click(object sender, EventArgs e)
        {
            imgsSlider.PreviewSlide();
        }

        private void button_imgNext_Click(object sender, EventArgs e)
        {
            imgsSlider.NextSlide();
        }

        private void button_imgDelete_Click(object sender, EventArgs e)
        {
            imgsSlider.DeleteSlide();
        }

        private void textBox_ImgUrl_TextChanged(object sender, EventArgs e)
        {
            if (imgsSlider.CurrentSlide != null)
            {
                imgsSlider.CurrentSlide = textBox_ImgUrl.Text;
                pictureBox1.ImageLocation = textBox_ImgUrl.Text;
            }
        }
        #endregion

        #region Глобальный статус бар
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
        #endregion

        #region Название программы, строка поиска
        private void button_AddWord_Click(object sender, EventArgs e)
        {
            searchStr.AddWord();
        }

        private void button_deleteWord_Click(object sender, EventArgs e)
        {
            searchStr.DeleteWord();
        }

        private void textBox_NamePost_TextChanged(object sender, EventArgs e)
        {
            searchStr = new SearchStr(textBox_NamePost.Text);
            textBox_SearchProgram.Text = searchStr.ShortName;
        }
        #endregion

        #region Диалог выбора торрент файла
        private void button_SelectTorrentFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                post.TorrentPath = openFileDialog1.FileName;
                textBox_TorrentFile.Text = openFileDialog1.FileName;
            }
        }
        #endregion

        #region Открытие формы добавления программы.
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddProgram form_AddProgram = new Form_AddProgram(true, searchStr.ShortName);
            form_AddProgram.FormClosed += Form_AddProgram_FormClosed;
            form_AddProgram.Show();
        }

        private void Form_AddProgram_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView_Search.DataSource = SearchList.UpdateProgramsGrid(textBox_SearchProgram.Text);
        }
        #endregion

        private void опубликоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            post.Name = textBox_NamePost.Text;
            post.Description = textBox_Description.Text;

            int selectedRows = dataGridView_Search.SelectedRows[0].Index;
            string idProgramString = dataGridView_Search.Rows[selectedRows].Cells[0].Value.ToString();
            int idProgram = int.Parse(idProgramString);

            post.ProgramID = idProgram;
            post.DatePublic = dateTimePicker1.Value;
            post.Imgs = imgsSlider.Slides;
            post.Spoilers = spoilerSlider.Slides;
            post.Add();

            Close();
        }
    }
}
