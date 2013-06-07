using System;
using System.Globalization;
using System.Windows.Forms;

namespace Prj_Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                var value1 = int.Parse(txtTest1.Text);
                var value2 = int.Parse(txtTest2.Text);
                var result = value1 + value2;
                MessageBox.Show(result.ToString(CultureInfo.InvariantCulture));
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are u sure , u wnt to Quit?", "Close", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
