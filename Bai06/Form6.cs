using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form6 : Form
    {
        double FirstNum;
        
        string Equation;
        public Form6()
        {
            InitializeComponent();
        }

        private void bN1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void bN2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void bN3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void bN4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void bN5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void bN6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void bN7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void bN8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void bN9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void bN0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bDecimal_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            FirstNum= Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Equation = "+";
        }

        private void bSub_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Equation = "-";
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Equation = "*";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Equation = "/";
            
        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            double SecondNum = Convert.ToDouble(textBox1.Text);
            double Result;
            if(Equation=="+")
            {
                Result = FirstNum + SecondNum;
                textBox1.Text=Convert.ToString(Result);
                FirstNum = Result;
            }
            if (Equation == "-")
            {
                Result = FirstNum - SecondNum;
                textBox1.Text = Convert.ToString(Result);
                FirstNum = Result;
            }
            if (Equation == "*")
            {
                Result = FirstNum * SecondNum;
                textBox1.Text = Convert.ToString(Result);
                FirstNum = Result;
            }
            if (Equation == "/")
            {
                if (SecondNum != 0)
                {
                    Result = FirstNum / SecondNum;
                    textBox1.Text = Convert.ToString(Result);
                    FirstNum = Result;
                }
                else
                {
                    textBox1.Text = "ERROR!";
                }
            }


        }
    }
}
