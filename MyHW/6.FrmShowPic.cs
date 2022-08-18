using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmShowPic : Form
    {
        int w, h;        
        public FrmShowPic()
        {
            InitializeComponent();
            w = pictureBox1.Width;
            h = pictureBox1.Height;
        }

        private void 實際大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
        
        internal int index,border;
        private void 上一張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            FrmMyAlbum_V2 fO = (FrmMyAlbum_V2)this.Owner;
            if (index > 0)
                pictureBox1.Image = ((PictureBox)fO.flowLayoutPanel1.Controls[--index]).Image;
        }
        private void 下一張ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            FrmMyAlbum_V2 fO = (FrmMyAlbum_V2)this.Owner;
            if (index < border)
                pictureBox1.Image = ((PictureBox)fO.flowLayoutPanel1.Controls[++index]).Image;
        }
        private void 自動播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int n = trackBar1.Value;
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.SendToBack();
            pictureBox1.Width = w * n;
            pictureBox1.Height = h * n;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            index = index < border ? index + 1:0;
            FrmMyAlbum_V2 fO = (FrmMyAlbum_V2)this.Owner;
            pictureBox1.Image = ((PictureBox)fO.flowLayoutPanel1.Controls[index]).Image;
        }




    }
}
