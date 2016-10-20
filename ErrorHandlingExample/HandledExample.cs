using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ErrorHandlingExample
{
    class HandledExample
    {
        public List<string> ReadFromFile(string fileName)
        {
            List<string> fileContents = new List<string>();
          
            try
            {
                StreamReader reader = new StreamReader(fileName);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    fileContents.Add(line);

                }
                return fileContents;
            }
            catch (Exception e)
            {
                //Here I would log the error, but as an example I am writing it to console
                Console.WriteLine(e.Message);
                //Here I will directly give a message to the user asking them to try again
                Console.WriteLine("File not found, please try again");
                //Here I am going to return the function to the caller
                return ReadFromFile(getFileName());

            }

        }

        private string getFileName()
        {
            Console.WriteLine("Please enter a file name");
            return Console.ReadLine();

        }
    }
}
