using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Make = "Opel";
            car.Model = "2002";
            car.ElapseMileage = 10000;
            //
            Car car2 = new Car("Opel","2002",10000);
        }
    }
}
