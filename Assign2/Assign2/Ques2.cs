using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assign2
{
    class Ques2
    {
        // Display Current Queue status
        private void Display(Queue q)
        {
            foreach (int i in q)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        // Send Data to main program
        public void SendData(int CacheLimit)
        {
            Queue q = new Queue();
            Console.WriteLine("Enter positive integers to add to cache");
            Console.WriteLine("Enter -1 to exit");
            int valueEntered = 0;
            while (valueEntered != -1)
            {
                if (!int.TryParse(Console.ReadLine(), out valueEntered))
                {
                    throw (new MyExceptions("Input string was not in a correct format."));

                }
                if (q.Count >= CacheLimit)
                {
                    q.Dequeue();
                    q.Enqueue(valueEntered);
                }
                else
                {
                    q.Enqueue(valueEntered);
                }
                Display(q);
            }


        }
    }
}
