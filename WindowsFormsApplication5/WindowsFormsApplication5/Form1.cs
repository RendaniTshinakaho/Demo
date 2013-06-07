using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Sample";
            dlg.ShowReadOnly = true;
            if (dlg.ShowDialog()== DialogResult.OK)
            {
                string filename = dlg.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
