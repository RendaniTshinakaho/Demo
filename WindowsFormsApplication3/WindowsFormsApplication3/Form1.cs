using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            txtValue.Text = " " + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) +
                            random.Next(0, 9) + random.Next(0, 9) + " - " + random.Next(0, 9) + random.Next(0, 9) +
                            random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + " - " +
                            random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) +
                            random.Next(0, 9) + random.Next(0, 9);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Generate Random Numbers";
        }
    }
}
