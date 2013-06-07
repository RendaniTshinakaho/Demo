using System;
using System.Windows.Forms;

namespace Error_Handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int result;
            try
            {
                result = int.Parse(txtNumber1.Text)*int.Parse(txtNumber2.Text);
                MessageBox.Show(result.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem with entry." + "Please make sure you numeric values only.", "Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car1 = new Car();
            car1.Make = "Opel";
            car1.Model = "2002";
            car1.ElapseMileage = 10000;
            //
            Car car2 = new Car("Opel","2010",0);
            MessageBox.Show(car2.Make + " " + car2.Model + " " + car2.ElapseMileage.ToString());
        }
    }
}
