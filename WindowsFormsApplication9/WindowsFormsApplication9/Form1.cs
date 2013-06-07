using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string OpenFileName = @"c:\test.txt ";
        private const string SaveFileName = @"c:\test2.txt ";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(OpenFileName);
            string line;
            string content = string.Empty;
            bool isFinished = false;

            while (!isFinished == true)
            {
                line = streamReader.ReadLine();
                if (line == null)
                {
                    isFinished = true;
                }
                content += line;
            }
            textBox1.Text = content;
            streamReader.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter(SaveFileName);
            sr.WriteLine(textBox1.Text);
            sr.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure, you want to Quit?", "Quit?", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
               Application.Exit(); 
            }
        }
    }
}
