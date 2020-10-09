using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinaryTree
    {
        TreeNode<int> root;
        public BinaryTree()
        {
            root = createTree();
        }
        public TreeNode<int> createTree()
        {
            int x;
            x = int.Parse(Console.ReadLine());
            if (x == -1)
            {
                return null;
            }
            TreeNode<int> newTreeNode = new TreeNode<int>(x);
            Console.WriteLine("Enter the left child of" + x);
            newTreeNode.SetLeft(createTree());
            Console.WriteLine("Enter the right child of" + x);
            newTreeNode.SetRight(createTree());
            return newTreeNode;
        }
        public void printInOrder()
        {
            this.printInOrder(root);
        }
        private void printInOrder(TreeNode<int> root)
        {
            if (root == null) return;
            printInOrder(root.GetLeft());
            Console.Write(root.GetData() + " ");
            printInOrder(root.GetRight());
        }
        public void printLevelOrder()
        {
            this.printLevelOrder(root);
        }
        private void printLevelOrder(TreeNode<int> root)
        {
            const TreeNode<int> MARKER = null;
            if (root == null)
            {
                return;
            }
            Queue<TreeNode<int>> displayQueue = new Queue<TreeNode<int>>();
            displayQueue.Enqueue(root);
            displayQueue.Enqueue(MARKER);

            while (displayQueue.Count != 0)
            {
                TreeNode<int> currentNode = displayQueue.Dequeue();
                if (currentNode == MARKER)
                {
                    Console.WriteLine();
                    if (displayQueue.Count != 0) displayQueue.Enqueue(MARKER);
                    continue;
                }
                Console.Write(currentNode.GetData() + " ");
                if (currentNode.GetLeft() != null)
                {
                    displayQueue.Enqueue(currentNode.GetLeft());
                }
                if (currentNode.GetRight() != null)
                {
                    displayQueue.Enqueue(currentNode.GetRight());
                }
            }

        }
    }
}
