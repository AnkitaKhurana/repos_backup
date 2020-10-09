using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class TreeNodeSpecial<T>
    {
        /// <summary>
        ///  Members : (Data , Left Node , Right Node, next Node)
        /// </summary>
        private T data;
        TreeNodeSpecial<T> next;
        TreeNodeSpecial<T> left;
        TreeNodeSpecial<T> right;

        // Constructor to initialise Node
        public TreeNodeSpecial(T data)
        {
            this.data = data;
            left = null;
            right = null;
            next = null;
        }

        // Sets Left Child
        public void SetLeft(TreeNodeSpecial<T> newLeft)
        {
            this.left = newLeft;
        }

        // Sets right child
        public void SetRight(TreeNodeSpecial<T> newRight)
        {
            this.right = newRight;
        }

        // Get Node Data
        public T GetData()
        {
            return data;
        }

        // Get Next Node
        public TreeNodeSpecial<T> GetNext()
        {
            return next;
        }

        // Set Next Node of Current Node
        public void SetNext(TreeNodeSpecial<T> nextNode)
        {
            this.next = nextNode;
        }

        // Get Left Child
        public TreeNodeSpecial<T> GetLeft()
        {
            return this.left;
        }

        // Get right child
        public TreeNodeSpecial<T> GetRight()
        {
            return this.right;
        }

    }
}
