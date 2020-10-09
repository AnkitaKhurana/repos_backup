using System;
using System.Collections;

namespace ConsoleApp1
{
    struct point
    {
        public int x;
        public int y;
    };
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = int.Parse(Console.ReadLine());
            char[,] a = new char[num,num]; /* a is an array of num integers */
            Queue plus = new Queue();
            Queue multiply = new Queue();
            point[] plusPoints = new point[num];
            point[] multiplyPoints = new point[num];
            int lengthPlusPoints = 0;
            int lengthMultiplyPoints = 0;
            int totalPlus = 0;
            int totalMultiply = 0;
            for ( int i = 0; i < num; i ++)
            {
                for (int j = 0; j < num; j ++)
                { a[i,j] = Console.ReadKey().KeyChar; }
            }
            Console.WriteLine("\nYour Matrix :");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < num; j++)
                    Console.Write(a[i, j]);
            }
            for (int i = 1; i < num-1; i++)
            {
                for (int j = 1; j < num - 1; j++)
                {
                    if (i + 1 < num && i - 1 >= 0 && j + 1 < num && j - 1 >= 0 && a[i, j] == 'A' && a[i - 1, j] == 'A' && a[i + 1, j] == 'A' && a[i, j - 1] == 'A' && a[i, j + 1] == 'A')
                    {
                        plusPoints[lengthPlusPoints].x = i + 1;
                        plusPoints[lengthPlusPoints].y = j + 1;
                        lengthPlusPoints++;
                        totalPlus++;
                        plus.Enqueue((i-1) * num + j + 1);
                        plus.Enqueue((i) * num + j);
                        plus.Enqueue(i * num + j + 1);
                        plus.Enqueue((i) * num + j + 2);
                        plus.Enqueue((i + 1) * num + j + 1);


                    }
                    if (i + 1 < num && i - 1 >= 0 && j + 1 < num && j - 1 >= 0 && a[i, j] == 'A' && a[i - 1, j - 1] == 'A' && a[i + 1, j - 1] == 'A' && a[i + 1, j + 1] == 'A' && a[i - 1, j + 1] == 'A')

                    {
                        multiplyPoints[lengthMultiplyPoints].x = i + 1;
                        multiplyPoints[lengthMultiplyPoints].y = j + 1;
                        lengthMultiplyPoints++;
                        totalMultiply++;
                        multiply.Enqueue((i-1) * num +j);
                        multiply.Enqueue((i-1) * num + j + 2);
                        multiply.Enqueue(i * num + j + 1);
                        multiply.Enqueue((i+1) * num + j);
                        multiply.Enqueue((i + 1) * num + j+2);
                        
                    }

                }

            }
            Console.WriteLine("\nTotal Plus : " + totalPlus);
            for(int i = 0; i < lengthPlusPoints; i ++)
            {
                Console.Write("("+plusPoints[i].x + "," + plusPoints[i].y+") ");
            }
            Console.WriteLine("\nTotal Multiply : " + totalMultiply);
            for (int i = 0; i < lengthMultiplyPoints; i++)
            {
                Console.Write("(" + multiplyPoints[i].x + "," + multiplyPoints[i].y + ") ");
            }
            int counter = 0;
            Console.WriteLine("Sets of Plus Patterns");
            foreach (int p in plus)
            {
                if (counter % 5 == 0)
                    Console.WriteLine("\n");
                Console.Write(p + " ");
                counter++;
            }
            counter = 0;
            Console.WriteLine("\nSets of Multiply Patterns");
            foreach (int p in multiply)
            {
                if (counter % 5 == 0)
                    Console.WriteLine("\n");
                Console.Write(p + " ");
                counter++;

            }

            Console.ReadLine();

        }
    }
}
