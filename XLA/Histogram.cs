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
            return
                histogram;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
