using System;

namespace LargestNumber
{
    /// <summary>
    /// Main Program to find the Largest Number 
    /// </summary>
    class Program
    {
        // Array to store Numbers 
        public long[] Array = new long[] { };
        // Size of Array
        public long Size;
        // Constructor for Program
        Program(long sizeArray)
        {
            Size = sizeArray; ;
            Array = new long[Size];
        }

        // Function to get Array
        void GetArray()
        {
            Console.WriteLine("Enter Array:");
            for (long index = 0; index < Size; index++)
            {
                if (!long.TryParse(Console.ReadLine(), out long element))
                {
                    throw (new Exception("Input string was not in a correct format."));
                }
                if (element < 0)
                {
                    throw (new Exception("Negative numbers are not Allowed"));
                }
                Array[index] = element;
            }
        }

        // Display the Array
        void Display()
        {
            for (long index = 0; index < Size; index++)
            {
                Console.Write(Array[index] + " ");
            }
        }

        // Sort Array according to Array
        void SortArray()
        {
            System.Array.Sort<long>(Array, delegate (long number1, long number2)
            {
                long num12 = long.Parse(number1.ToString() + number2.ToString());
                long num21 = long.Parse(number2.ToString() + number1.ToString());
                if (num12 > num21)
                    return -1;
                else
                    return 1;
            });
        }

        // Main Function
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Total Numbers in the array :");
                if (!long.TryParse(Console.ReadLine(), out long size))
                {
                    throw (new Exception("Input string was not in a correct format."));
                }
                if (size < 0)
                {
                    throw (new Exception("Size cannot be Negative"));
                }
                Program program = new Program(size);
                program.GetArray();
                program.SortArray();
                Console.WriteLine("Result :");
                program.Display();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
