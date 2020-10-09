using System;
using System.Collections.Generic;
using System.Text;

namespace Assign3
{
    class Ques2
    {
        // Read Number Function
        public int ReadNumber(int start, int end, int index)
        {
            int number;
            Console.WriteLine("Enter Number "+(index+1)+":  ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                throw (new MyExceptions("Input string was not in a correct format."));
            }
            if (!(start < number && number < end))
            {
                throw (new MyExceptions("Number not between " + start +" and "+ end));
            }
            return number;
        }
        public void Program()
        {
            try
            {
                int start = 1, end = 100;
                for (int index = 0; index < 10; index++)
                {
                    start = ReadNumber(start, end, index);
                }
            }
            catch (MyExceptions) { }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("End");
            }
        }
    }
}
