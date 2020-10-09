using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class SpecialTreeNode<T> : TreeNode<T>
    {
        TreeNode<T> next;

        SpecialTreeNode(T data) : base(data)
        {

        }
        public TreeNode<T> GetNext()
        {
            return next;
        }
        public void SetNext(T data)
        {

        }

    }
}
