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
    public partial class Histogram : Form
    {
        public Histogram()
        {
            InitializeComponent();
        }
        const int dx = 168;
        const int dy = 84;
        public static Bitmap showHistogram(Bitmap picture, Bitmap histogram)
        {
            int[] pixelValue = new int[picture.Width * picture.Height];
            int cnt = 0;
            for (int i = 0; i < picture.Width; i++) { 
                for (int j = 0; j < picture.Height; j++)
                {
                    Color color = picture.GetPixel(i, j);
                    pixelValue[cnt] = color.R;
                    cnt++;
                }
            }
            int[] grayValue = new int[256];
            cnt = 0;
            for (int i = 0; i <= 255; i++)
            {
                for (int j = 0; j < picture.Height * picture.Width; j++)
                    if (i == pixelValue[j])
                        cnt++;
                grayValue[i] = cnt;
                cnt = 0;
            }
            int max = grayValue[0];
            for (int i = 1; i <= 255; i++)
                if (grayValue[i] > max)
                    max = grayValue[i];
            float ratio = histogram.Height / (float)max;
            for (int i = 0; i <= 255; i++)
                grayValue[i] = Convert.ToInt32(grayValue[i] * ratio);

            for (int i = 0; i < histogram.Width; i++)
                for (int j = 0; j < histogram.Height; j++)
                    histogram.SetPixel(i, j, Color.FromArgb(240, 240, 240));

            for (int i = 0; i < histogram.Width; i++)
            {
                for (int j = 0; j < histogram.Height; j++)
                {
                    if (j >= (histogram.Height - grayValue[i]) && j < histogram.Height)
                        histogram.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                }
            }
            return histogram;
        }
        public static Bitmap equalHistogram(Bitmap picture, Bitmap histogram)
        {
            int[] pixelValue = new int[picture.Width * picture.Height];
            int cnt = 0;
            for (int i = 0; i < picture.Width; i++)
                for (int j = 0; j < picture.Height; j++)
                {
                    Color color = picture.GetPixel(i, j);
                    pixelValue[cnt] = color.R;
                    cnt++;
                }
            int[] grayValue = new int[256];
            cnt = 0;
            for (int i = 0; i <= 255; i++)
            {
                for (int j = 0; j < picture.Height * picture.Width; j++)
                    if (i == pixelValue[j])
                        cnt++;
                grayValue[i] = cnt;
                cnt = 0;
            }
            int min = grayValue[0];
            int allValue = 0;
            for (int i = 0; i <= 255; i++)
            {
                allValue += grayValue[i];
                if (grayValue[i] < min)
                    min = grayValue[i];
            }
            int increment = 0;
            for (int i = 0; i <= 255; i++)
            {
                //System.Console.WriteLine(allValue);
                increment += grayValue[i];
                double num = (double)(increment - min) / (allValue - 1);
                //System.Console.WriteLine(num);
                grayValue[i] = (int)Math.Round(num * 255);
            }
            for (int i = 0; i < picture.Width; i++)
                for (int j = 0; j < picture.Height; j++)
                {
                    Color color = picture.GetPixel(i, j);
                    int value = color.R;
                    picture.SetPixel(i, j, Color.FromArgb(grayValue[value], grayValue[value], grayValue[value]));
                }
            return picture;
        }

        void Run(bool x)
        {
            showHistogramToolStripMenuItem.Enabled = x;
            equalHistogramToolStripMenuItem.Enabled = x;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                Run(true);
                pictureBox3.Image = Image.FromFile(op.FileName);
                // goc
            }
        }

        private void showHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap his = new Bitmap(dx, dy);
            Bitmap h = (Bitmap)pictureBox3.Image.Clone();
            his = showHistogram(h, his);
            pictureBox1.Image = his;
            // chart 1
        }

        private void equalHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap his = new Bitmap(dx, dy);
            Bitmap h = (Bitmap)pictureBox3.Image.Clone();
            h = equalHistogram(h, his);
            pictureBox4.Image = h;
            pictureBox2.Image = showHistogram(h, his);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Histogram_Load(object sender, EventArgs e)
        {
            Run(false);
        }
    }
}
