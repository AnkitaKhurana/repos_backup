using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseLinkedList
{
    class List<T> 
    {
        LinkedList<T> list;
        public int noOfElements { get; private set; }
        public List()
        {
            list = new LinkedList<T>();
            noOfElements = 0;
        }
        public List(List<T> inputStack)
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
        public void reverse()
        {
            if (list.Count==0)
                return;

            Console.WriteLine(list.Last.Value);
            list.RemoveLast();
            reverse();
        }
        public void DisplayList()
        {
            if (list.Count == 0)
                return;
            Console.WriteLine(list.First.Value);
            list[8];
        }
    }
}
