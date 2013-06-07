using System;
using System.IO;
using System.Windows.Forms;

namespace WritingAndReadingFromTextFile
{
    public partial class Form1 : Form
    {
        private const string openFileName = @"c:\test.txt";
        private const string saveFileName = @"c:\test2.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to Quit?", "Close Application", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
                var streamReader = new StreamReader(openFileName);
                var content = string.Empty;
                var finished = false;

                while (!finished)
                {
                    var line = streamReader.ReadLine();
                    if (line == null)
                    {
                        finished = true;
                    }
                    else
                    {
                        content += line;
                    }
                }
            txtValue.Text = content;
                streamReader.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var streamWriter = new StreamWriter(saveFileName);
            streamWriter.WriteLine(txtValue.Text);
            streamWriter.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Writing and Opening From a Text File";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyData.Equals(Keys.F7))btnExit_Click(sender,e);
        }
    }
}
