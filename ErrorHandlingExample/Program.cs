using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unhandled Example
            //Note the file I am providing the read function exists in this example
            //UnhandledExample unhandledReader = new UnhandledExample();
            //List<string> andrewContents = unhandledReader.ReadFromFile("andrew.txt");
            //foreach (string line in andrewContents)
            //{
            //    Console.WriteLine(line);
            //}
            ////Note the file I am providing the read function does not exist in this example
            //List<string> mikeContents = unhandledReader.ReadFromFile("Mike.txt");
            //foreach (string line in mikeContents)
            //{
            //    Console.WriteLine(line);
            // }
            ////This example uses try/catch/finally to handle the exceptions
            //HandledExample handledExample = new HandledExample();
            //////Note the file I am providing the read function exists in this example
            //List<string> existingFile = handledExample.ReadFromFile("andrewContents.txt");
            //foreach (string line in existingFile)
            //{
            //    Console.WriteLine(line);
            //}
            ////Note the file I am providing the reader does not exist in this example
            //List<string> notExistingFile = handledExample.ReadFromFile("mikeContents.txt");
            //foreach (string line in existingFile)
            //{
            //    Console.WriteLine(line);
            //}
            ////The proper way to use StreamReader
            //UsingStreamReaderCorrectly sr = new UsingStreamReaderCorrectly();
            //sr.ReadFromFile("andrew.txt");
            //Unhandled Throwing an Exception Example
            //ThrowingExceptionExample foo = new ThrowingExceptionExample();
            //string firstExample = null;
            ////foo.NullCheckingExample(firstExample);
            ////Handled Throwing Example Example
            //try
            //{
            //    foo.NullCheckingExample(firstExample);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    Console.WriteLine("I would also work out a way fix this method not working");
            //}
            Console.WriteLine("End of the program, this won't print if there is an unhandled exception");
            Console.ReadKey();

        }
    }
}
