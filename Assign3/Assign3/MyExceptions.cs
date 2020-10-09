using System;
using System.Collections.Generic;
using System.Text;

namespace Assign3
{
    class MyExceptions : Exception
    {
        public MyExceptions(string message) : base(message)
        {
            Console.WriteLine("\n" + message);
        }
    }
}
