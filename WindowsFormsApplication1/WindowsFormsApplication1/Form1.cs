using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private const string OpenFileName = @"c:\test.txt";
        private const string SaveFileName = @"c:\test2.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Simple IO ";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(OpenFileName);
            string line;
            string contents = string.Empty;
            bool isFinished = false;
            //

            while (!isFinished)
            {
                line = streamReader.ReadLine();
                if (line == null)
                {
                    isFinished = true;
                }
                else
                {
                    contents += line;
                }   
            }
            txtValue.Text = contents;
            streamReader.Close();     
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter(SaveFileName);
            sr.WriteLine(txtValue.Text);
            sr.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure, you want to quit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }


        }
    }
}
