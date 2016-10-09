using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReader
{
    class ReadFile
    {
        string line;
        int startLine;
        string[] lineArr;
        StreamReader streamReader;

        public ReadFile(string fileName, int inputNoTestCase, int inputstartLine = 0)
        {
            startLine = inputstartLine;
            lineArr = new string[inputNoTestCase];
            streamReader = new StreamReader(fileName);
            ReadLine();
        }

        public string[] Line
        {
            get { return lineArr; }
        }

        private void ReadLine()
        {
            int lineArrCount = 0;
            while ((line = streamReader.ReadLine()) != null)
            {
                lineArr[lineArrCount] = line;
                startLine++;
                lineArrCount++;
            }
        }
    }
}
