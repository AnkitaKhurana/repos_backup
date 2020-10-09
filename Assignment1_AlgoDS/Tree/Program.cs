using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instance for special binary Tree 
            BinaryTreeSpecial<int> bts = new BinaryTreeSpecial<int>();
            Console.WriteLine("Print Order Transversal");
            bts.PrintInOrder();
            bts.Connect();
            Console.WriteLine();
            Console.WriteLine("Nodes Connected");
            bts.Connect();
            Console.WriteLine();
            bts.PrintInOrder();
            Console.ReadKey();
        }
    }
}
