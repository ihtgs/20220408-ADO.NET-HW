namespace MyHW
{
    partial class FrmShowPic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowPic));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.實際大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自動播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一張ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.實際大小ToolStripMenuItem,
            this.上一張ToolStripMenuItem,
            this.自動播放ToolStripMenuItem,
            this.下一張ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 348);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(316, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Frm相片檢視器";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(309, 345);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(197, 28);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // 實際大小ToolStripMenuItem
            // 
            this.實際大小ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("實際大小ToolStripMenuItem.Image")));
            this.實際大小ToolStripMenuItem.Name = "實際大小ToolStripMenuItem";
            this.實際大小ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.實際大小ToolStripMenuItem.Text = "實際大小";
            this.實際大小ToolStripMenuItem.Click += new System.EventHandler(this.實際大小ToolStripMenuItem_Click);
            // 
            // 上一張ToolStripMenuItem
            // 
            this.上一張ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("上一張ToolStripMenuItem.Image")));
            this.上一張ToolStripMenuItem.Name = "上一張ToolStripMenuItem";
            this.上一張ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.上一張ToolStripMenuItem.Text = "上一張";
            this.上一張ToolStripMenuItem.Click += new System.EventHandler(this.上一張ToolStripMenuItem_Click);
            // 
            // 自動播放ToolStripMenuItem
            // 
            this.自動播放ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("自動播放ToolStripMenuItem.Image")));
            this.自動播放ToolStripMenuItem.Name = "自動播放ToolStripMenuItem";
            this.自動播放ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.自動播放ToolStripMenuItem.Text = "自動播放";
            this.自動播放ToolStripMenuItem.Click += new System.EventHandler(this.自動播放ToolStripMenuItem_Click);
            // 
            // 下一張ToolStripMenuItem
            // 
            this.下一張ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("下一張ToolStripMenuItem.Image")));
            this.下一張ToolStripMenuItem.Name = "下一張ToolStripMenuItem";
            this.下一張ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.下一張ToolStripMenuItem.Text = "下一張";
            this.下一張ToolStripMenuItem.Click += new System.EventHandler(this.下一張ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 345);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 850;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmShowPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 372);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmShowPic";
            this.Text = "FrmShowPic";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 實際大小ToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem 上一張ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自動播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一張ToolStripMenuItem;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}