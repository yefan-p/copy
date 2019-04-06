using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorrentSoftAutoAddPost
{

    public partial class FormSelectPoster : Form
    {
        public FormSelectPoster(List<string> imgs)
        {
            InitializeComponent();
            SetImgs(imgs);
        }

        private void SetImgs(List<string> imgs)
        {
            foreach (string item in imgs)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Size = new Size(200, 281);

                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(188, 219),
                    Location = new Point(6, 19),
                    ImageLocation = item,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                groupBox.Controls.Add(pictureBox);

                Button buttonPoster = new Button
                {
                    Size = new Size(188, 23),
                    Location = new Point(6, 244),
                    Text = "Постер",
                    Tag = item
                };
                buttonPoster.Click += ButtonPoster_Click;
                groupBox.Controls.Add(buttonPoster);

                Controls.Add(groupBox);
            }
            Resize += FromSelectPoster_Resize;
        }

        private void FromSelectPoster_Resize(object sender, EventArgs e)
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

        private void ButtonPoster_Click(object sender, EventArgs e)
        {
            string uri = (sender as Button).Tag.ToString();
            PosterSelectedArgs args = new PosterSelectedArgs(uri);
            PosterSelected?.Invoke(this, args);
            Close();
        }

        public event EventHandler<PosterSelectedArgs> PosterSelected;
    }
}
