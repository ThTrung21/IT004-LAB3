using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            Random rnd= new Random();
            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);
            Color bgcolor = Color.FromArgb(r, g, b);
            this.BackColor = bgcolor;
        }
    }
}
