using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        private const string OpenFileName = @"C:\test.txt ";
        private const string SaveFileName = @"C:\test2.txt ";
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to Quit?", "Quit", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var streamWriter = new StreamWriter(SaveFileName);
            streamWriter.WriteLine(textBox1.Text);
            streamWriter.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var streamReader = new StreamReader(OpenFileName);
            var content = string.Empty;
            var isfinished = false;

            while (!isfinished )
            {
                var line = streamReader.ReadLine();
                if (line == null)
                {
                    isfinished = true;
                }
                content += line;

            }
            textBox1.Text = content;
            streamReader.Close();
        }
    }
}
