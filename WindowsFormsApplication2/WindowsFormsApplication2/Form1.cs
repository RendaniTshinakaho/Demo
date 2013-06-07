using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string FileOpenName = @"C:\test.txt ";
        private const string OpenFileName = @"C:\test2.txt ";

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "File Input & Output";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            StreamReader  streamReader = new StreamReader(FileOpenName);

            string line;
            string content = string.Empty;
            bool isfinished = false;
            //
            while (!isfinished)
            {
                line = streamReader.ReadLine();
                if (line == null)
                {
                    isfinished = true;
                }
                content += line;
            }
            textBox1.Text = content;
            streamReader.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(OpenFileName);
            streamWriter.WriteLine(textBox1.Text);
            streamWriter.Close();
        }
    }
}
