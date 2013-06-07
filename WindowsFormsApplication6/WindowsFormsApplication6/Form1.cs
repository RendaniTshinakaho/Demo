using System;
using System.Windows.Forms;

namespace WindowsFormsApplication6
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
            txtValues.Text = "" + random.Next(0,9) + random.Next(0,9) + random.Next(0,9) + random.Next(0,9) +
            random.Next(0, 9) + " - " + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) +
            " - " + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) + random.Next(0, 9) +
            random.Next(0, 9);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValues.Clear();
            btnGenerate.Focus();
        }
    }
}
