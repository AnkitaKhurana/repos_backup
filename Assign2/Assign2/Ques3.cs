using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assign2
{

    class Ques3
    {
        // Node class to generate tree nodes
        public class node
        {
            public int data;
            public node left;
            public node right;
            public node(int d)   // Constructor 
            {
                data = d;
                left = null;
                right = null;
            }
        }
        node head = null;      // Initialising Head node (root)

        // Level Order Transversal
        public void printLevelOrder()
        {
            Console.WriteLine("Level Order");
            Queue elementQueue = new Queue();
            node current = head;
            if (current == null)
                return;

            else
            {
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    if (current.left != null)
                        elementQueue.Enqueue(current.left);
                    if (current.right != null)
                        elementQueue.Enqueue(current.right);
                    if (elementQueue.Count > 0)
                        current = (node)elementQueue.Dequeue();
                    else
                        current = null;
                }



            }

        }
        // Spiral Order Transversal
        public void printSpiralOrder()
        {
            Console.WriteLine("Spiral Order");
            node current = head;
            if (current == null)
                return;
            Stack leftToRight = new Stack();
            Stack rightToLeft = new Stack();
            rightToLeft.Push(current);
            while (!(leftToRight.Count == 0) || !(rightToLeft.Count == 0))
            {

                while (rightToLeft.Count > 0)
                {
                    node temp = (node)rightToLeft.Peek();
                    Console.WriteLine(temp.data);

                    if (temp.right != null)
                        leftToRight.Push(temp.right);
                    if (temp.left != null)
                        leftToRight.Push(temp.left);
                    rightToLeft.Pop();

                }


                while (leftToRight.Count > 0)
                {
                    node temp = (node)leftToRight.Peek();
                    Console.WriteLine(temp.data);

                    if (temp.left != null)
                        rightToLeft.Push(temp.left);
                    if (temp.right != null)
                        rightToLeft.Push(temp.right);
                    leftToRight.Pop();

                }
            }


        }

        // Insert Element in tree
        public void insert(int data)
        {
            node newElement = new node(data);
            if (head == null)
            {
                head = newElement;
            }
            else
            {
                Queue status = new Queue();
                status.Enqueue(head);
                while (status.Count != 0)
                {
                    node current = (node)status.Peek();
                    status.Dequeue();
                    if (current.left == null)
                    {
                        current.left = newElement;
                        break;
                    }
                    else
                    {
                        status.Enqueue(current.left);
                    }
                    if (current.right == null)
                    {
                        current.right = newElement;
                        break;
                    }
                    else
                    {
                        status.Enqueue(current.right);
                    }
                }

            }

        }

        // Build Tree 
        public void buildTree()
        {
            int ans = 1;
            Console.WriteLine("Build Tree :");
            while (ans == 1)
            {
                Console.WriteLine("Enter Element");
                if (!int.TryParse(Console.ReadLine(), out int element))
                {
                    throw (new MyExceptions("Input string was not in a correct format."));
                }
                insert(element);
                Console.Write("Want to add more? (1:Yes, 0:No)");
                if (!int.TryParse(Console.ReadLine(), out ans))
                {
                    throw (new MyExceptions("Input string was not in a correct format."));
                }
                if (ans != 1 && ans != 0)
                {
                    throw (new MyExceptions("Only 1 or 0 Allowed"));
                }

            }

        }
        // Main function called 
        public void program()
        {
            buildTree();
            printLevelOrder();
            Console.WriteLine();
            printSpiralOrder();
        }



    }
}
