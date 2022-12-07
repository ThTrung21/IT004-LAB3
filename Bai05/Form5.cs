using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form5 : Form
    {
        float a=0,b=0;
        string solution;
        float S = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S = a + b;
            textBox3.Text = Convert.ToString(S);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b=float.Parse(textBox2.Text);
        }

        private void bSub_Click(object sender, EventArgs e)
        {
            S = a - b;
            textBox3.Text = Convert.ToString(S);
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            S = a * b;
            textBox3.Text = Convert.ToString(S);
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            if (b == 0)
                textBox3.Text = "Error";
            else
            {
                S = a / b;
                textBox3.Text = Convert.ToString(S);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a=float.Parse(textBox1.Text);
        }
    }
}
