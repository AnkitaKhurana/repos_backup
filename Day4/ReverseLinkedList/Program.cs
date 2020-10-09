using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            mylist.Push(1);
            mylist.Push(2);
            mylist.Push(3);
            mylist.Push(4);
            mylist.Push(5);
            mylist.Push(6);
            mylist.Push(7);
            mylist.Push(8);
            mylist.Push(9);
            mylist.Push(10);
            mylist.Push(11);
            mylist.reverse();
            Console.ReadKey();


        }
    }
}
