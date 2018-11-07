using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyPost.Trackers;

namespace CopyPost.AddPost.ImgSwitch
{
    public partial class Form_ImgSwitch : Form
    {
        ITrackersItem prPost;
        ImgItem imgItem = new ImgItem();
        System.Single littleFont = 8.25F;
        System.Single bigFont = 10.75F;

        public string Description { get; set; }
        public ImgItem Imgs { get; set; }
        public List<SpoilersItem> Spoilers { get; set; }

        public Form_ImgSwitch(ITrackersItem _prPost)
        {
            InitializeComponent();

            prPost = _prPost;
            Description = _prPost.Description;
            Spoilers = _prPost.Spoilers;

            CreateComponent();
        }

        #region Созадие и расположение компонентов формы
        private void CreateComponent()
        {
            foreach (string item in prPost.Imgs)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Size = new Size(200, 281);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(188, 161);
                pictureBox.Location = new Point(6, 19);
                pictureBox.ImageLocation = item;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                groupBox.Controls.Add(pictureBox);

                Button buttonPoster = new Button();
                buttonPoster.Size = new Size(188, 23);
                buttonPoster.Location = new Point(6, 186);
                buttonPoster.Text = "Постер";
                buttonPoster.Tag = item;
                buttonPoster.Click += ButtonPoster_Click;
                groupBox.Controls.Add(buttonPoster);

                Button buttonView = new Button();
                buttonView.Size = new Size(188, 23);
                buttonView.Location = new Point(6, 215);
                buttonView.Text = "Вид";
                buttonView.Tag = item;
                buttonView.Click += ButtonView_Click;
                groupBox.Controls.Add(buttonView);

                Button buttonScreen = new Button();
                buttonScreen.Size = new Size(188, 23);
                buttonScreen.Location = new Point(6, 244);
                buttonScreen.Text = "Скрин";
                buttonScreen.Tag = item;
                buttonScreen.Click += ButtonScreen_Click;
                groupBox.Controls.Add(buttonScreen);

                Controls.Add(groupBox);
            }
            this.Resize += LocationComponent;
        }

        private void LocationComponent(object sender, EventArgs e)
        {
            int WidthPadding = 212; // ширина группы с отсутом
            int HeightPadding = 293; // высота группы с отсутом

            int MaxCountCol = Width / 212;
            int CurrentCol = 0;
            int CurrentRow = 0;

            foreach (GroupBox item in Controls.OfType<GroupBox>())
            {
                item.Location = new Point(CurrentCol * WidthPadding, CurrentRow * HeightPadding);
                CurrentCol++;
                if (CurrentCol == MaxCountCol)
                {
                    CurrentCol = 0;
                    CurrentRow++;
                }
            }
        }
        #endregion

        #region Обработчики кнопок
        private void ButtonScreen_Click(object sender, EventArgs e)
        {
            string img = (sender as Button).Tag.ToString();
            if (imgItem.ScreensAddOrDel(img))
                (sender as Button).Font = new Font((sender as Button).Font.FontFamily, bigFont, FontStyle.Bold);
            else
                (sender as Button).Font = new Font((sender as Button).Font.FontFamily, littleFont);
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            string img = (sender as Button).Tag.ToString();
            if (imgItem.ViewsAddOrDel(img))
                (sender as Button).Font = new Font((sender as Button).Font.FontFamily, bigFont, FontStyle.Bold);
            else
                (sender as Button).Font = new Font((sender as Button).Font.FontFamily, littleFont);
        }

        private void ButtonPoster_Click(object sender, EventArgs e)
        {
            string img = (sender as Button).Tag.ToString();
            if (imgItem.Poster == img)
            {
                (sender as Button).Font = new Font((sender as Button).Font.FontFamily, littleFont);
                imgItem.Poster = null;
            }                
            else if (imgItem.Poster == null)
            {
                (sender as Button).Font = new Font((sender as Button).Font.FontFamily, bigFont, FontStyle.Bold);
                imgItem.Poster = img;
            }
            else
                MessageBox.Show("Не может быть выбрано два постера! Сначала удалите выбранный!");
        }
        #endregion

        private void фильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imgs = imgItem;

            foreach (string item in prPost.Imgs)
            {
                if (!imgItem.AllCollection.Contains(item))
                {
                    Description = Description.Replace(item, "");

                    foreach (SpoilersItem sp in Spoilers)
                        sp.content = sp.content.Replace(item, "");
                }
            }
            Close();
        }
    }
}
