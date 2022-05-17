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
    public partial class BrightnessScroll : Form
    {
        public BrightnessScroll()
        {
            InitializeComponent();
        }
        private void BrighnessScroll_Load(object sender, EventArgs e)
        {
            L1.Text = Scroll.Maximum.ToString();
            L2.Text = Scroll.Value.ToString();
            L3.Text = Scroll.Minimum.ToString();
            this.AcceptButton = button1;
        }
        public int Tovalue()
        {
            return (Scroll.Value);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Scroll_Scroll(object sender, EventArgs e)
        {
            L2.Text = Scroll.Value.ToString();
        }

        
    }
}
