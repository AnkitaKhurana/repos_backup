using System;

namespace Tree
{
    class BinaryTreeSpecial<T>
    {
        // Tree Root 
        private readonly TreeNodeSpecial<T> root;

        // Constructor to initialise root
        public BinaryTreeSpecial()
        {
            root = CreateTree();
        }

        // Create Tree Function
        public TreeNodeSpecial<T> CreateTree()
        {
            T x;
            string input = Console.ReadLine();
            x = (T)Convert.ChangeType(input, typeof(T));
            if ((int)(object)x == -1)
            {
                return null;
            }
            TreeNodeSpecial<T> newTreeNode = new TreeNodeSpecial<T>(x);
            Console.WriteLine("Enter the left child of " + x);
            newTreeNode.SetLeft(CreateTree());
            Console.WriteLine("Enter the right child of " + x);
            newTreeNode.SetRight(CreateTree());
            return newTreeNode;
        }

        // Prints in Order by calling Private PrintInOrder 
        public void PrintInOrder()
        {
            this.PrintInOrder(root);
        }

        // Private PrintInOrder prints tree Recursively
        private void PrintInOrder(TreeNodeSpecial<T> root)
        {
            if (root == null) return;
            PrintInOrder(root.GetLeft());
            if(root.GetNext()!=null)
            Console.Write(" "+root.GetData() + "-->" +root.GetNext().GetData());
            else
                Console.Write(" "+root.GetData() + "--> null");
            PrintInOrder(root.GetRight());
        }

        // Connects next nodes in O(1) Space
        public void Connect()
        {
            TreeNodeSpecial<T> startNode = root;
            TreeNodeSpecial<T> leftMostNode = null;
            TreeNodeSpecial<T> childNode = null;
            TreeNodeSpecial<T> currentNode = null;
            while (startNode != null)
            {
                leftMostNode = null;
                childNode = null;
                currentNode = startNode;
                while (currentNode != null)                     // check till curent node exists
                {

                    if (currentNode.GetLeft() != null)           // check for left element existance 
                    {
                        if (leftMostNode == null)                // assign to left if it is null 
                        {
                            leftMostNode = currentNode.GetLeft();
                            childNode = currentNode.GetLeft();
                        }
                        else                                    // Assign Child Node
                        {                           
                            childNode.SetNext(currentNode.GetLeft());
                            childNode = currentNode.GetLeft();
                        }
                    }
                    if (currentNode.GetRight() != null)          // check for right element existance 
                    {
                        if (leftMostNode == null)                // assign to left if it isnull  
                        {
                            leftMostNode = currentNode.GetRight();
                            childNode = currentNode.GetRight();
                        }
                        else                                     // Assign Child Node
                        {
                            childNode.SetNext(currentNode.GetRight());
                            childNode = currentNode.GetRight();
                        }
                    }
                    currentNode = currentNode.GetNext();        // Update Current Node
                }
                startNode = leftMostNode;                       // Update Start Node
            }
        }
    }
}
