using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ConnectToDatabaseUsingRegistry
{
    public partial class Form1 : Form
    {
        private RegistryKey objRegistryKey = Registry.LocalMachine;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            var values = (string)objRegistryKey.GetValue(@"Software\Wow6432Node\Yellow\YellowPayroll\Instances\Default\sqlconnectionstring");
            label2.Text = values;
        }
    }
}
