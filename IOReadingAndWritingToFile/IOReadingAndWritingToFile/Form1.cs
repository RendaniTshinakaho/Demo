using System;
using System.IO;
using System.Windows.Forms;

namespace IOReadingAndWritingToFile
{
    public partial class Form1 : Form
    {
        private const string OpenFileName = @"C:\test.txt";
        private const string SaveFileName = @"C:\test2.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, you want to close this Application", "Exit", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var fStreamReader = new StreamReader(OpenFileName);
            var content = string.Empty;
            var isFinished = false;
            while (!isFinished)
            {
                var line = fStreamReader.ReadLine();
                if (line == null)
                {
                    isFinished = true;
                }
                else
                {
                    content += line;
                }
            }
            txtDisplay.Text = content;
            fStreamReader.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var streamWriter = new StreamWriter(SaveFileName);
            streamWriter.WriteLine(txtDisplay.Text);
            streamWriter.Close();
        }
    }
}
