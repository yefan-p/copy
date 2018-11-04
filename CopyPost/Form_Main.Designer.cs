namespace CopyPost
{
    partial class Form_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.получитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nnmclubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_NewPost = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_NewPost = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.опубликоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_PublicPost = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel_Descript = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel_Message = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NewPost)).BeginInit();
            this.contextMenuStrip_NewPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PublicPost)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.получитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // получитьToolStripMenuItem
            // 
            this.получитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutorToolStripMenuItem,
            this.rutrackerToolStripMenuItem,
            this.nnmclubToolStripMenuItem});
            this.получитьToolStripMenuItem.Name = "получитьToolStripMenuItem";
            this.получитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.получитьToolStripMenuItem.Text = "Получить";
            // 
            // rutorToolStripMenuItem
            // 
            this.rutorToolStripMenuItem.Name = "rutorToolStripMenuItem";
            this.rutorToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.rutorToolStripMenuItem.Text = "rutor";
            this.rutorToolStripMenuItem.Click += new System.EventHandler(this.rutorToolStripMenuItem_Click);
            // 
            // rutrackerToolStripMenuItem
            // 
            this.rutrackerToolStripMenuItem.Name = "rutrackerToolStripMenuItem";
            this.rutrackerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.rutrackerToolStripMenuItem.Text = "rutracker";
            // 
            // nnmclubToolStripMenuItem
            // 
            this.nnmclubToolStripMenuItem.Name = "nnmclubToolStripMenuItem";
            this.nnmclubToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.nnmclubToolStripMenuItem.Text = "nnm-club";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_NewPost);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_PublicPost);
            this.splitContainer1.Size = new System.Drawing.Size(1129, 492);
            this.splitContainer1.SplitterDistance = 540;
            this.splitContainer1.TabIndex = 4;
            // 
            // dataGridView_NewPost
            // 
            this.dataGridView_NewPost.AllowUserToAddRows = false;
            this.dataGridView_NewPost.AllowUserToDeleteRows = false;
            this.dataGridView_NewPost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_NewPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NewPost.ContextMenuStrip = this.contextMenuStrip_NewPost;
            this.dataGridView_NewPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_NewPost.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView_NewPost.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_NewPost.MultiSelect = false;
            this.dataGridView_NewPost.Name = "dataGridView_NewPost";
            this.dataGridView_NewPost.ReadOnly = true;
            this.dataGridView_NewPost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_NewPost.Size = new System.Drawing.Size(540, 492);
            this.dataGridView_NewPost.TabIndex = 2;
            // 
            // contextMenuStrip_NewPost
            // 
            this.contextMenuStrip_NewPost.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опубликоватьToolStripMenuItem,
            this.скрытьToolStripMenuItem});
            this.contextMenuStrip_NewPost.Name = "contextMenuStrip_NewPost";
            this.contextMenuStrip_NewPost.Size = new System.Drawing.Size(224, 48);
            // 
            // опубликоватьToolStripMenuItem
            // 
            this.опубликоватьToolStripMenuItem.Name = "опубликоватьToolStripMenuItem";
            this.опубликоватьToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.опубликоватьToolStripMenuItem.Text = "Подготовить к публикации";
            this.опубликоватьToolStripMenuItem.Click += new System.EventHandler(this.опубликоватьToolStripMenuItem_Click);
            // 
            // скрытьToolStripMenuItem
            // 
            this.скрытьToolStripMenuItem.Name = "скрытьToolStripMenuItem";
            this.скрытьToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.скрытьToolStripMenuItem.Text = "Скрыть";
            // 
            // dataGridView_PublicPost
            // 
            this.dataGridView_PublicPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PublicPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_PublicPost.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_PublicPost.Name = "dataGridView_PublicPost";
            this.dataGridView_PublicPost.Size = new System.Drawing.Size(585, 492);
            this.dataGridView_PublicPost.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel_Descript,
            this.Status_ProgressBar,
            this.StatusLabel_Message});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1129, 22);
            this.statusStrip1.TabIndex = 5;
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
            this.Status_ProgressBar.Visible = false;
            // 
            // StatusLabel_Message
            // 
            this.StatusLabel_Message.Name = "StatusLabel_Message";
            this.StatusLabel_Message.Size = new System.Drawing.Size(0, 17);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 541);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_Main";
            this.Text = "CopyPost";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NewPost)).EndInit();
            this.contextMenuStrip_NewPost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PublicPost)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem получитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nnmclubToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView_NewPost;
        private System.Windows.Forms.DataGridView dataGridView_PublicPost;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_NewPost;
        private System.Windows.Forms.ToolStripMenuItem опубликоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скрытьToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_Descript;
        private System.Windows.Forms.ToolStripProgressBar Status_ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_Message;
    }
}

