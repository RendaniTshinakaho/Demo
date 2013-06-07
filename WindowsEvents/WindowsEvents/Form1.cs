using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Form Load");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("Test");
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please Enter a value","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox1.Text = string.Empty;
                textBox1.Focus();           
                
            }
        }
    }
}
