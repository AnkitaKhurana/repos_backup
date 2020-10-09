using System;
using System.Collections.Generic;
using System.Text;

namespace Assign3
{
    class Ques1
    {
        public void Program()
        {
            try
            {
                Console.WriteLine("Enter Number to Calculate Square root");
                int number;
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    throw (new MyExceptions("Input string was not in a correct format."));
                }
                if (number < 0)
                {
                    throw (new MyExceptions("Invalid Number"));
                }
                Console.WriteLine("Square Root :"+Math.Sqrt(number));
            }
            catch(MyExceptions){}
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}
