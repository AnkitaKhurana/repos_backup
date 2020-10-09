using System;
using System.Collections.Generic;
using System.Text;

namespace Assign2
{ 
    // My exception 
    class MyExceptions : Exception
    {
        public MyExceptions(string message) : base(message)
        {
            Console.WriteLine("\n" + message);
        }
    }
}
