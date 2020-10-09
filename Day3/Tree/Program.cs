using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.printInOrder();
            Console.WriteLine();
            bt.printLevelOrder();
            Console.ReadKey();
        }
    }
}
