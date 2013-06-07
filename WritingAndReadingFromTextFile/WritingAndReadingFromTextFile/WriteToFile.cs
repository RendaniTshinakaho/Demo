using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WritingAndReadingFromTextFile
{
    internal class WriteToFile
    {
        private const string FileOpen = @"C:\test.txt";
        private const string SaveFile = @"C:\test1.txt";

        private void ReaderFromFile()
        {
            StreamReader streamReader = new StreamReader(FileOpen);
            string line = string.Empty;
            var content = string.Empty;
            bool isFinished = false;
            while (!isFinished)
            {
                line = streamReader.ReadLine();
                if (line == null)
                {
                    isFinished = true;
                }
                else
                {
                    content += line;
                }
            }
        }
    }
}
