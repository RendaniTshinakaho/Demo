﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateNumbers_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            //
            txtGenerate.Text = " " + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) +
                               " - " +
                               random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + " - " +
                               random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + " - " +
                               random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + " - " +
                               random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + " - " +
                               random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + " - " +
                               random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9);
        }
    }
}