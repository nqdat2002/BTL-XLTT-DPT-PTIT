using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA
{
    public partial class ZoomScroll : Form
    {
        const int ss = 150;
        public ZoomScroll()
        {
            InitializeComponent();
        }
        Image ZoomPicture(Image img, Size sz)
        {
            Bitmap m = new(img, Convert.ToInt32(img.Width) + Convert.ToInt32(img.Width * sz.Width / ss), Convert.ToInt32(img.Height) + Convert.ToInt32(img.Height * sz.Height / ss));
            Graphics gpu = Graphics.FromImage(m);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return m;
        }
        public Image Show(Bitmap tmp)
        {
            var codeBitmap = new Bitmap(tmp);
            Image image = (Image)codeBitmap;
            return image;
        }
        public PictureBox t = new PictureBox();
        private void Run(bool x)
        {
            trackBar1.Enabled = x;
        }
        private void ZoomScroll_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = ss;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;
            this.DoubleBuffered = true;
            Run(false);
        }
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value != 0)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = ZoomPicture(t.Image, new Size(trackBar1.Value, trackBar1.Value));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog() == DialogResult.OK)
            {
                t = new PictureBox();
                t.Load(op.FileName);
                pictureBox1.Load(op.FileName);
                Run(true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 