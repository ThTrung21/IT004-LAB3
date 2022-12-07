﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog ChangeColor = new ColorDialog();
            ChangeColor.Color = BackColor;

            if (ChangeColor.ShowDialog() == DialogResult.OK)
                BackColor = ChangeColor.Color;
        }


    }

    
}
