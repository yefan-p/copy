namespace CopyPost
{
    partial class Form_AddPost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.опубликоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torrentSoftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опубликоватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_ImgSlider = new System.Windows.Forms.GroupBox();
            this.textBox_ImgUrl = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_imgNext = new System.Windows.Forms.Button();
            this.button_imgDelete = new System.Windows.Forms.Button();
            this.button_imgPreview = new System.Windows.Forms.Button();
            this.button_SelectTorrentFile = new System.Windows.Forms.Button();
            this.textBox_TorrentFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NamePost = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.button_NextSpoiler = new System.Windows.Forms.Button();
            this.button_DeleteSpoiler = new System.Windows.Forms.Button();
            this.button_preSpoiler = new System.Windows.Forms.Button();
            this.textBox_NameSpoiler = new System.Windows.Forms.TextBox();
            this.label_NumberSpoiler = new System.Windows.Forms.Label();
            this.textBox_SpoilerContent = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.button_deleteWord = new System.Windows.Forms.Button();
            this.button_AddWord = new System.Windows.Forms.Button();
            this.textBox_SearchProgram = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_Search = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_SearchProgram = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel_Descript = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel_Message = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_ImgSlider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Search)).BeginInit();
            this.contextMenuStrip_SearchProgram.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опубликоватьToolStripMenuItem,
            this.torrentSoftToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1473, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // опубликоватьToolStripMenuItem
            // 
            this.опубликоватьToolStripMenuItem.Name = "опубликоватьToolStripMenuItem";
            this.опубликоватьToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.опубликоватьToolStripMenuItem.Text = "Опубликовать";
            this.опубликоватьToolStripMenuItem.Click += new System.EventHandler(this.опубликоватьToolStripMenuItem_Click);
            // 
            // torrentSoftToolStripMenuItem
            // 
            this.torrentSoftToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опубликоватьToolStripMenuItem1});
            this.torrentSoftToolStripMenuItem.Name = "torrentSoftToolStripMenuItem";
            this.torrentSoftToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.torrentSoftToolStripMenuItem.Text = "TorrentSoft";
            // 
            // опубликоватьToolStripMenuItem1
            // 
            this.опубликоватьToolStripMenuItem1.Name = "опубликоватьToolStripMenuItem1";
            this.опубликоватьToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.опубликоватьToolStripMenuItem1.Text = "Опубликовать";
            this.опубликоватьToolStripMenuItem1.Click += new System.EventHandler(this.опубликоватьToolStripMenuItem1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_ImgSlider);
            this.splitContainer1.Panel1.Controls.Add(this.button_SelectTorrentFile);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_TorrentFile);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_NamePost);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1473, 715);
            this.splitContainer1.SplitterDistance = 363;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox_ImgSlider
            // 
            this.groupBox_ImgSlider.Controls.Add(this.textBox_ImgUrl);
            this.groupBox_ImgSlider.Controls.Add(this.pictureBox1);
            this.groupBox_ImgSlider.Controls.Add(this.button_imgNext);
            this.groupBox_ImgSlider.Controls.Add(this.button_imgDelete);
            this.groupBox_ImgSlider.Controls.Add(this.button_imgPreview);
            this.groupBox_ImgSlider.Location = new System.Drawing.Point(10, 167);
            this.groupBox_ImgSlider.Name = "groupBox_ImgSlider";
            this.groupBox_ImgSlider.Size = new System.Drawing.Size(343, 486);
            this.groupBox_ImgSlider.TabIndex = 13;
            this.groupBox_ImgSlider.TabStop = false;
            this.groupBox_ImgSlider.Text = "Изображения";
            // 
            // textBox_ImgUrl
            // 
            this.textBox_ImgUrl.Location = new System.Drawing.Point(13, 378);
            this.textBox_ImgUrl.Multiline = true;
            this.textBox_ImgUrl.Name = "textBox_ImgUrl";
            this.textBox_ImgUrl.Size = new System.Drawing.Size(317, 91);
            this.textBox_ImgUrl.TabIndex = 17;
            this.textBox_ImgUrl.TextChanged += new System.EventHandler(this.textBox_ImgUrl_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button_imgNext
            // 
            this.button_imgNext.Location = new System.Drawing.Point(207, 19);
            this.button_imgNext.Name = "button_imgNext";
            this.button_imgNext.Size = new System.Drawing.Size(75, 23);
            this.button_imgNext.TabIndex = 15;
            this.button_imgNext.Text = ">>";
            this.button_imgNext.UseVisualStyleBackColor = true;
            this.button_imgNext.Click += new System.EventHandler(this.button_imgNext_Click);
            // 
            // button_imgDelete
            // 
            this.button_imgDelete.Location = new System.Drawing.Point(126, 19);
            this.button_imgDelete.Name = "button_imgDelete";
            this.button_imgDelete.Size = new System.Drawing.Size(75, 23);
            this.button_imgDelete.TabIndex = 14;
            this.button_imgDelete.Text = "X";
            this.button_imgDelete.UseVisualStyleBackColor = true;
            this.button_imgDelete.Click += new System.EventHandler(this.button_imgDelete_Click);
            // 
            // button_imgPreview
            // 
            this.button_imgPreview.Location = new System.Drawing.Point(45, 19);
            this.button_imgPreview.Name = "button_imgPreview";
            this.button_imgPreview.Size = new System.Drawing.Size(75, 23);
            this.button_imgPreview.TabIndex = 13;
            this.button_imgPreview.Text = "<<";
            this.button_imgPreview.UseVisualStyleBackColor = true;
            this.button_imgPreview.Click += new System.EventHandler(this.button_imgPreview_Click);
            // 
            // button_SelectTorrentFile
            // 
            this.button_SelectTorrentFile.Location = new System.Drawing.Point(290, 139);
            this.button_SelectTorrentFile.Name = "button_SelectTorrentFile";
            this.button_SelectTorrentFile.Size = new System.Drawing.Size(60, 23);
            this.button_SelectTorrentFile.TabIndex = 6;
            this.button_SelectTorrentFile.Text = "Выбрать";
            this.button_SelectTorrentFile.UseVisualStyleBackColor = true;
            this.button_SelectTorrentFile.Click += new System.EventHandler(this.button_SelectTorrentFile_Click);
            // 
            // textBox_TorrentFile
            // 
            this.textBox_TorrentFile.Location = new System.Drawing.Point(12, 141);
            this.textBox_TorrentFile.Name = "textBox_TorrentFile";
            this.textBox_TorrentFile.Size = new System.Drawing.Size(272, 20);
            this.textBox_TorrentFile.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Файл .torrent";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(338, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата публикации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование";
            // 
            // textBox_NamePost
            // 
            this.textBox_NamePost.Location = new System.Drawing.Point(12, 25);
            this.textBox_NamePost.Multiline = true;
            this.textBox_NamePost.Name = "textBox_NamePost";
            this.textBox_NamePost.Size = new System.Drawing.Size(341, 58);
            this.textBox_NamePost.TabIndex = 0;
            this.textBox_NamePost.TextChanged += new System.EventHandler(this.textBox_NamePost_TextChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1106, 715);
            this.splitContainer2.SplitterDistance = 733;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.textBox_Description);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(733, 715);
            this.splitContainer4.SplitterDistance = 149;
            this.splitContainer4.TabIndex = 1;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Description.Location = new System.Drawing.Point(0, 0);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Description.Size = new System.Drawing.Size(733, 149);
            this.textBox_Description.TabIndex = 1;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.button_NextSpoiler);
            this.splitContainer5.Panel1.Controls.Add(this.button_DeleteSpoiler);
            this.splitContainer5.Panel1.Controls.Add(this.button_preSpoiler);
            this.splitContainer5.Panel1.Controls.Add(this.textBox_NameSpoiler);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.label_NumberSpoiler);
            this.splitContainer5.Panel2.Controls.Add(this.textBox_SpoilerContent);
            this.splitContainer5.Size = new System.Drawing.Size(733, 562);
            this.splitContainer5.SplitterDistance = 46;
            this.splitContainer5.TabIndex = 6;
            // 
            // button_NextSpoiler
            // 
            this.button_NextSpoiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NextSpoiler.Location = new System.Drawing.Point(648, 11);
            this.button_NextSpoiler.Name = "button_NextSpoiler";
            this.button_NextSpoiler.Size = new System.Drawing.Size(75, 23);
            this.button_NextSpoiler.TabIndex = 9;
            this.button_NextSpoiler.Text = ">>";
            this.button_NextSpoiler.UseVisualStyleBackColor = true;
            this.button_NextSpoiler.Click += new System.EventHandler(this.button_NextSpoiler_Click);
            // 
            // button_DeleteSpoiler
            // 
            this.button_DeleteSpoiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeleteSpoiler.Location = new System.Drawing.Point(567, 11);
            this.button_DeleteSpoiler.Name = "button_DeleteSpoiler";
            this.button_DeleteSpoiler.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteSpoiler.TabIndex = 8;
            this.button_DeleteSpoiler.Text = "X";
            this.button_DeleteSpoiler.UseVisualStyleBackColor = true;
            this.button_DeleteSpoiler.Click += new System.EventHandler(this.button_DeleteSpoiler_Click);
            // 
            // button_preSpoiler
            // 
            this.button_preSpoiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_preSpoiler.Location = new System.Drawing.Point(486, 11);
            this.button_preSpoiler.Name = "button_preSpoiler";
            this.button_preSpoiler.Size = new System.Drawing.Size(75, 23);
            this.button_preSpoiler.TabIndex = 7;
            this.button_preSpoiler.Text = "<<";
            this.button_preSpoiler.UseVisualStyleBackColor = true;
            this.button_preSpoiler.Click += new System.EventHandler(this.button_preSpoiler_Click);
            // 
            // textBox_NameSpoiler
            // 
            this.textBox_NameSpoiler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NameSpoiler.Location = new System.Drawing.Point(11, 12);
            this.textBox_NameSpoiler.Name = "textBox_NameSpoiler";
            this.textBox_NameSpoiler.Size = new System.Drawing.Size(465, 20);
            this.textBox_NameSpoiler.TabIndex = 6;
            this.textBox_NameSpoiler.TextChanged += new System.EventHandler(this.textBox_NameSpoiler_TextChanged);
            // 
            // label_NumberSpoiler
            // 
            this.label_NumberSpoiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_NumberSpoiler.AutoSize = true;
            this.label_NumberSpoiler.Location = new System.Drawing.Point(707, 3);
            this.label_NumberSpoiler.Name = "label_NumberSpoiler";
            this.label_NumberSpoiler.Size = new System.Drawing.Size(0, 13);
            this.label_NumberSpoiler.TabIndex = 11;
            // 
            // textBox_SpoilerContent
            // 
            this.textBox_SpoilerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SpoilerContent.Location = new System.Drawing.Point(0, 0);
            this.textBox_SpoilerContent.Multiline = true;
            this.textBox_SpoilerContent.Name = "textBox_SpoilerContent";
            this.textBox_SpoilerContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SpoilerContent.Size = new System.Drawing.Size(733, 512);
            this.textBox_SpoilerContent.TabIndex = 3;
            this.textBox_SpoilerContent.TextChanged += new System.EventHandler(this.textBox_SpoilerContent_TextChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.button_deleteWord);
            this.splitContainer3.Panel1.Controls.Add(this.button_AddWord);
            this.splitContainer3.Panel1.Controls.Add(this.textBox_SearchProgram);
            this.splitContainer3.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView_Search);
            this.splitContainer3.Size = new System.Drawing.Size(369, 715);
            this.splitContainer3.SplitterDistance = 92;
            this.splitContainer3.TabIndex = 7;
            // 
            // button_deleteWord
            // 
            this.button_deleteWord.Location = new System.Drawing.Point(238, 54);
            this.button_deleteWord.Name = "button_deleteWord";
            this.button_deleteWord.Size = new System.Drawing.Size(65, 23);
            this.button_deleteWord.TabIndex = 7;
            this.button_deleteWord.Text = "<<";
            this.button_deleteWord.UseVisualStyleBackColor = true;
            this.button_deleteWord.Click += new System.EventHandler(this.button_deleteWord_Click);
            // 
            // button_AddWord
            // 
            this.button_AddWord.Location = new System.Drawing.Point(238, 25);
            this.button_AddWord.Name = "button_AddWord";
            this.button_AddWord.Size = new System.Drawing.Size(65, 23);
            this.button_AddWord.TabIndex = 6;
            this.button_AddWord.Text = ">>";
            this.button_AddWord.UseVisualStyleBackColor = true;
            this.button_AddWord.Click += new System.EventHandler(this.button_AddWord_Click);
            // 
            // textBox_SearchProgram
            // 
            this.textBox_SearchProgram.Location = new System.Drawing.Point(6, 25);
            this.textBox_SearchProgram.Multiline = true;
            this.textBox_SearchProgram.Name = "textBox_SearchProgram";
            this.textBox_SearchProgram.Size = new System.Drawing.Size(226, 52);
            this.textBox_SearchProgram.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Поиск программы";
            // 
            // dataGridView_Search
            // 
            this.dataGridView_Search.AllowUserToAddRows = false;
            this.dataGridView_Search.AllowUserToDeleteRows = false;
            this.dataGridView_Search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Search.ContextMenuStrip = this.contextMenuStrip_SearchProgram;
            this.dataGridView_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Search.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Search.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Search.MultiSelect = false;
            this.dataGridView_Search.Name = "dataGridView_Search";
            this.dataGridView_Search.ReadOnly = true;
            this.dataGridView_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Search.Size = new System.Drawing.Size(369, 619);
            this.dataGridView_Search.TabIndex = 9;
            // 
            // contextMenuStrip_SearchProgram
            // 
            this.contextMenuStrip_SearchProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.посмотретьToolStripMenuItem});
            this.contextMenuStrip_SearchProgram.Name = "contextMenuStrip_SearchProgram";
            this.contextMenuStrip_SearchProgram.Size = new System.Drawing.Size(142, 48);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // посмотретьToolStripMenuItem
            // 
            this.посмотретьToolStripMenuItem.Name = "посмотретьToolStripMenuItem";
            this.посмотретьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.посмотретьToolStripMenuItem.Text = "Посмотреть";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel_Descript,
            this.Status_ProgressBar,
            this.StatusLabel_Message});
            this.statusStrip1.Location = new System.Drawing.Point(0, 742);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1473, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel_Descript
            // 
            this.StatusLabel_Descript.Name = "StatusLabel_Descript";
            this.StatusLabel_Descript.Size = new System.Drawing.Size(0, 17);
            // 
            // Status_ProgressBar
            // 
            this.Status_ProgressBar.Name = "Status_ProgressBar";
            this.Status_ProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // StatusLabel_Message
            // 
            this.StatusLabel_Message.Name = "StatusLabel_Message";
            this.StatusLabel_Message.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Torrent|*.torrent|Все файлы(*.*)|*.*";
            this.openFileDialog1.Title = "Выберите .torrent файл";
            // 
            // Form_AddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 764);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_AddPost";
            this.Text = "Добавить пост";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_ImgSlider.ResumeLayout(false);
            this.groupBox_ImgSlider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Search)).EndInit();
            this.contextMenuStrip_SearchProgram.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem опубликоватьToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NamePost;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button_SelectTorrentFile;
        private System.Windows.Forms.TextBox textBox_TorrentFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_SearchProgram;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button button_deleteWord;
        private System.Windows.Forms.Button button_AddWord;
        private System.Windows.Forms.TextBox textBox_SearchProgram;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_Search;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_Descript;
        private System.Windows.Forms.ToolStripProgressBar Status_ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_Message;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox_ImgSlider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_imgNext;
        private System.Windows.Forms.Button button_imgDelete;
        private System.Windows.Forms.Button button_imgPreview;
        private System.Windows.Forms.TextBox textBox_ImgUrl;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Button button_NextSpoiler;
        private System.Windows.Forms.Button button_DeleteSpoiler;
        private System.Windows.Forms.Button button_preSpoiler;
        private System.Windows.Forms.TextBox textBox_NameSpoiler;
        private System.Windows.Forms.TextBox textBox_SpoilerContent;
        private System.Windows.Forms.Label label_NumberSpoiler;
        private System.Windows.Forms.ToolStripMenuItem torrentSoftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опубликоватьToolStripMenuItem1;
    }
}