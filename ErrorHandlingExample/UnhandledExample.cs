using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ErrorHandlingExample
{
    class UnhandledExample
    {
        public List<string> ReadFromFile(string fileName)
        {
            List<string> fileContents = new List<string>();
            StreamReader reader = new StreamReader(fileName);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                fileContents.Add(line);
                
            }
            reader.Close();
            return fileContents;
        }
    }
}
