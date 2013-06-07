using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MonitoringSoftware
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSystemInformation_Click(object sender, EventArgs e)
        {
            txtMonitorSize.Text = SystemInformation.PrimaryMonitorSize.ToString();
            txtDomainName.Text = SystemInformation.UserDomainName;
            txtMonitorMaximumSize.Text = SystemInformation.PrimaryMonitorMaximizedWindowSize.ToString();
            txtComputerName.Text = SystemInformation.UserName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Monitoring Software";
        }
    }
}
