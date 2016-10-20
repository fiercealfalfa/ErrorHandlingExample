using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ErrorHandlingExample
{
    class ThrowingExceptionExample
    {
        public void NullCheckingExample(string original)
        {
            if (original == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", "original");
            }
            else
            {
                Console.WriteLine(original);
            }
        }
}
}
