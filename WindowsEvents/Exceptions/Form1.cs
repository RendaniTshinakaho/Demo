using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int Num1;
            int Num2;
            int result;
            //
           
            try
            {
                Num1 = int.Parse(textBox1.Text);
                Num2 = int.Parse(textBox2.Text);
                result = MultiplyNumbers(Num1, Num2);
                MessageBox.Show(result.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("There was a problem with your entry", "Please enter numeric numbers only!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                
                throw new Exception("There was a problem with you inputs ");
            }
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Focus();

        }

        private int MultiplyNumbers(int Number1,int Number2)
        {
            return Number1*Number2;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
