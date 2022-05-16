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
    public partial class input : Form
    {
        public input()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Fill in your number you want !!!");
            }
            else
            {
                this.Close();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }
    }
}
