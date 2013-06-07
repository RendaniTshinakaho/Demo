using System;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text)) return;
            MessageBox.Show("Please Enter a Value", "Error");
            textBox1.Focus();
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text)) return;
            MessageBox.Show("Please enter a value");
            {
                textBox2.Focus();
            }
        }
    }
}
