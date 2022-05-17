using System;
using System.Buffers;
using System.Windows;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace XLA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        private void RunApp(bool x)
        {
            adjustmentsToolStripMenuItem.Enabled = x;
            convertToolStripMenuItem.Enabled = x;
            saveToolStripMenuItem.Enabled = x;
            filterToolStripMenuItem.Enabled = x;
            editToolStripMenuItem.Enabled = x;
            convertToolStripMenuItem.Enabled = x;
            //zoomToolStripMenuItem.Enabled = x;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RunApp(false);
        }

        // This is Open the sources of Picture to edit
        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDialog.Title = "Open picture";
            OpenDialog.InitialDirectory = @"C:\Users";
            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                RunApp(true);
                Old.Image = Image.FromFile(OpenDialog.FileName);
            }
        }
        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDialog.Title = "Save picture";
            SaveDialog.InitialDirectory = @"C:\";
            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                New.Image.Save(SaveDialog.FileName);
                New.Image = null;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OpenDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToBinToolStripMenuItem_Click(object sender, EventArgs e)
        {   // RGB -> Bin
            Bitmap img = (Bitmap)Old.Image.Clone();
            Bitmap bin = new Bitmap(img.Width, img.Height);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);
                    int x1, x2, x3;
                    x1 = (c.R >= 128 ? 255 : 0);
                    x2 = (c.G >= 128 ? 255 : 0);
                    x3 = (c.B >= 128 ? 255 : 0);
                    bin.SetPixel(i, j, Color.FromArgb(x1, x2, x3));

                }
            }
            New.Image = bin;
        }
        private void brighnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input ip = new input();
            ip.ShowDialog();
            if (ip.textBox1.Text == "") return;
            int val = int.Parse(ip.textBox1.Text);
            Bitmap t = (Bitmap)Old.Image.Clone();
            Bitmap res = new Bitmap(t.Width, t.Height);
            for (int x = 0; x < t.Width; x++)
            {
                for (int y = 0; y < t.Height; y++)
                {
                    Color c = t.GetPixel(x, y);
                    int x1 = Math.Max(Math.Min(c.R + val, 255), 0);
                    int x2 = Math.Max(Math.Min(c.G + val, 255), 0);
                    int x3 = Math.Max(Math.Min(c.B + val, 255), 0);
                    res.SetPixel(x, y, Color.FromArgb(x1, x2, x3));
                }
            }
            New.Image = res;

        }
        // brighness_with_scroll
        private void brighnessScrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrightnessScroll br = new BrightnessScroll();
            br.ShowDialog();
            Bitmap tp = (Bitmap)Old.Image.Clone();
            Bitmap res = new Bitmap(tp.Width, tp.Height);
            int val = br.Tovalue();
            if(val == 0)
            {
                New.Image = tp;
                return;
            }
            for (int x = 0; x < tp.Width; x++)
            {
                for (int y = 0; y < tp.Height; y++)
                {
                    Color c = tp.GetPixel(x, y);
                    int x1 = Math.Max(Math.Min(c.R + val, 255), 0);
                    int x2 = Math.Max(Math.Min(c.G + val, 255), 0);
                    int x3 = Math.Max(Math.Min(c.B + val, 255), 0);
                    res.SetPixel(x, y, Color.FromArgb(x1, x2, x3));
                }
            }
            New.Image = res;
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // information about this app and author
            About a = new About();
            a.ShowDialog();
        }

        private void Old_Click(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {

        }

        private void contrastScrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContrastScroll ct = new ContrastScroll();
            ct.ShowDialog();
            Bitmap t = (Bitmap)Old.Image.Clone();
            double val = ((100.0 + (ct.ToValue() - 100)) / 100) + ((100.0 + (ct.ToValue() - 100)) / 100);
            Bitmap res = new Bitmap(t.Width, t.Height);
            for (int x = 0; x < t.Width; x++)
            {
                for(int y = 0; y < t.Height; y++)
                {
                    Color c = t.GetPixel(x, y);
                    double tmp = ((((c.R / 255.0) - 0.5) * val) + 0.5) * 255.0;
                    int nr = (int)tmp;

                    tmp = ((((c.G / 255.0) - 0.5) * val) + 0.5) * 255.0;
                    int ng = (int)tmp;

                    tmp = ((((c.B / 255.0) - 0.5) * val) + 0.5) * 255.0;
                    int nb = (int)tmp;

                    if (nr < 0) nr = 0;
                    if (nr > 255) nr = 255;
                    if (ng < 0) ng = 0;
                    if (ng > 255) ng = 255;
                    if (nb < 0) nb = 0;
                    if (nb > 255) nb = 255;
                    res.SetPixel(x, y, Color.FromArgb(c.A, nr, ng, nb));
                }
            }
            New.Image = res;
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input ip = new input();
            ip.ShowDialog();

            Bitmap t = (Bitmap)Old.Image.Clone();
            Bitmap res = new Bitmap(t.Width, t.Height);
            if (ip.textBox1.Text == "") return;
            int v = int.Parse(ip.textBox1.Text);
            double val = ((100.0 + (v - 100)) / 100) + ((100.0 + (v - 100)) / 100);
            for (int i = 0; i < t.Width; i++)
            {
                for (int j = 0; j < t.Height; j++)
                {
                    Color c = t.GetPixel(i, j);
                    double tmp = ((((c.R / 255.0) - 0.5) * val) + 0.5) * 255.0;
                    int nr = (int)tmp;

                            tmp = ((((c.G / 255.0) - 0.5) * val) + 0.5) * 255.0;
                    int ng = (int)tmp;

                            tmp = ((((c.B / 255.0) - 0.5) * val) + 0.5) * 255.0;
                    int nb = (int)tmp;

                    if (nr < 0) nr = 0;
                    if (nr > 255) nr = 255;
                    if (ng < 0) ng = 0;
                    if (ng > 255) ng = 255;
                    if (nb < 0) nb = 0;
                    if (nb > 255) nb = 255;
                    res.SetPixel(i, j, Color.FromArgb(c.A, nr, ng, nb));
                }
            }
            New.Image = res;
        }

        // Filter 
        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap picture = (Bitmap) Old.Image.Clone();
            int[] matrix = new int[9];
            int[,] pixelPicture = new int[picture.Width - 2, picture.Height - 2];
            int[,] pixelPicture1 = new int[picture.Width - 2, picture.Height - 2];
            int[,] pixelPicture2 = new int[picture.Width - 2, picture.Height - 2];
            int pixel;
            int cnt = 0;
            for (int i = 0; i < picture.Width - 2; i++)
            {
                for (int j = 0; j < picture.Height - 2; j++)
                {
                    cnt = 0;
                    for (int n = i; n <= i + 2; n++)
                        for (int m = j; m <= j + 2; m++)
                        {
                            Color c = picture.GetPixel(n, m);
                            matrix[cnt] = c.R;
                            cnt++;
                        }
                    pixel = matrix[0] * -1 + matrix[1] * -2 + matrix[3] * -1 + matrix[6] * 1 + matrix[7] * 2 + matrix[8] * 1;
                    pixelPicture1[i, j] = pixel;

                }
            }
            for (int i = 0; i < picture.Width - 2; i++)
            {
                for (int j = 0; j < picture.Height - 2; j++)
                {
                    cnt = 0;
                    for (int n = i; n <= i + 2; n++)
                        for (int m = j; m <= j + 2; m++)
                        {
                            Color c = picture.GetPixel(n, m);
                            matrix[cnt] = c.R;
                            cnt++;
                        }
                    pixel = matrix[0] * -1 + matrix[2] * 1 + matrix[3] * -2 + matrix[5] * 2 + matrix[6] * -1 + matrix[8] * 1;
                    pixelPicture2[i, j] = pixel;

                }
            }
            for (int i = 0; i < picture.Width - 2; i++)
            {
                for (int j = 0; j < picture.Height - 2; j++)
                {
                    pixelPicture[i, j] = Math.Abs(pixelPicture1[i, j]) + Math.Abs(pixelPicture2[i, j]);
                }
            }
            for (int i = 0; i < picture.Width - 2; i++)
            {
                for (int j = 0; j < picture.Height - 2; j++)
                {
                    Color c = picture.GetPixel(i, j);
                    if (pixelPicture[i, j] > 255)
                        picture.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    else
                        picture.SetPixel(i, j, Color.FromArgb(pixelPicture[i, j], pixelPicture[i, j], pixelPicture[i, j]));
                }
            }
            New.Image = picture;
        }

        private void rGBToRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)Old.Image.Clone();
            Bitmap red = new Bitmap(img.Width, img.Height);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);

                    byte R = c.R;
                    byte A = c.A;

                    red.SetPixel(i, j, Color.FromArgb(A, R, 0, 0));

                }
            }
            New.Image = red;
        }

        private void rGBToGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)Old.Image.Clone();
            Bitmap green = new Bitmap(img.Width, img.Height);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);

                    byte G = c.G;
                    byte A = c.A;

                    green.SetPixel(i, j, Color.FromArgb(A, 0, G, 0));

                }
            }
            New.Image = green;
        }

        private void rGBToBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)Old.Image.Clone();
            Bitmap blue = new Bitmap(img.Width, img.Height);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);

                    byte B = c.B;
                    byte A = c.A;

                    blue.SetPixel(i, j, Color.FromArgb(A, 0, 0, B));

                }
            }
            New.Image = blue;
        }

        private void rGBToGrayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)Old.Image.Clone();
            Bitmap gray = new Bitmap(img.Width, img.Height);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);

                    byte R = c.R;
                    byte G = c.G;
                    byte B = c.B;
                    byte max = Math.Max(R, Math.Max(G, B));
                    byte min = Math.Min(R, Math.Min(G, B));

                    //()
                    // int x = (int)(c.R * .299 + c.B * .114 + c.G * .578);
                    // byte x = (byte)((R + G + B) / 3);
                    // using Average ()

                    byte x = (byte)((min + max) / 2);
                    gray.SetPixel(i, j, Color.FromArgb(x, x, x));
                    // Using Lightness
                }
            }
            New.Image = gray;
        }

        private void grayToBinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Gray -> Bin
            Bitmap img = (Bitmap)Old.Image.Clone();
            Bitmap bin = new Bitmap(img.Width, img.Height);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);
                    byte R = c.R;
                    byte G = c.G;
                    byte B = c.B;
                    byte max = Math.Max(R, Math.Max(G, B));
                    byte min = Math.Min(R, Math.Min(G, B));
                    byte Bina = (byte)((min + max) / 2);
                    if (Bina < 128)
                        Bina = 0;
                    else
                        Bina = 255;
                    bin.SetPixel(i, j, Color.FromArgb(Bina, Bina, Bina));

                }
            }
            New.Image = bin;
        }

        private void invertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)Old.Image.Clone();
            Bitmap res = new Bitmap(img.Width, img.Height);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);
                    res.SetPixel(i, j, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));

                }
            }
            New.Image = res;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomScroll z = new ZoomScroll();
            z.ShowDialog();
        }

        private void cropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crop cr = new Crop();
            cr.ShowDialog();
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogram hs = new Histogram();
            hs.ShowDialog();
        }
    }
}