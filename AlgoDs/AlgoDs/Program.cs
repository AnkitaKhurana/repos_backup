using System;

namespace AlgoDs
{
    class Program
    {
        static public int findFib(int a , int b)
        {
            int c = a + b;
            Console.WriteLine(c);
            return c;
        }
        static public int findFibRecursion(int n )
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
            {
                
                return (findFibRecursion(n - 1) + findFibRecursion(n - 2));

            }
           
        }
        static void Main(string[] args)
        {
            //int a = 0;
            //int b = 1;
            //int c = 1;
            //int temp;
            //Console.WriteLine(a + " \n" + b);

            //// Using Loop
            //for(int i = 0;  i< 10; i++)
            //{                
            //    temp = findFib(a, b);
            //    a = b;
            //    b = temp;

            //}
            //int n = 10;
            //// Using Recursion
            //findFibRecursion(n);
            //Console.ReadKey();
            Task1 task1 = new Task1();
            task1.Program();
        }
    }
}
