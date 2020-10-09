using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class StackLL<T>
    {
        LinkedList<T> list;
        public int noOfElements { get; private set; }
        public StackLL()
        {
            list = new LinkedList<T>();
            noOfElements = 0;
        }
        public StackLL(StackLL<T> inputStack)
        {
            list = new LinkedList<T>(inputStack.list);
            noOfElements = 0;
        }
        public void Pop()
        {
            if (list.Count == 0)
            {
                throw new System.IndexOutOfRangeException("Empty!");
            }
            list.RemoveLast();
        }
        public void Push(T obj)
        {
            list.AddLast(obj);
        }   

    }
   
}
