using System;
using System.Collections.Generic;

namespace Day2
{
    class Program
    {
        public class TemplateList<T> : List<T>
        {
            T top;
            T end;
            int size;
            public TemplateList()
            {
                size = 0;
            }
            public new void Add(T data)
            {
                base.Add(data);
                size++;
            }
            new public void Clear()
            {
                base.Clear();
                size = 0;
            }
            //new public void Find()
            //{
            //    base.Find(x => x.GetId() == "xy");
            //}
            public void Push(T data)
            {
                base.Insert(0, data);
                size++;
            }
            public void Pop()
            {
                base.RemoveAt(size);
                size--;
            }
            public void Peek()
            {
                base.FindIndex(base.Count-1);
            }
            public void Display(TemplateList<T> myList)
            {
                foreach (T data in myList)
                {
                    Console.Write(data + " ");
                }
                Console.WriteLine("\n");
            }
        }
       

        static void Main(string[] args)
        {
            //TemplateList<int> t = new TemplateList<int>();
            //t.Add(1);
            //t.Add(2);
            //t.Display(t);

            //TemplateList<int> tChar = new TemplateList<int>();
            //tChar.Add('A');
            //tChar.Add('B');
            //t.Display(tChar);
            //Console.ReadKey();

            //TemplateList<int> intStack = new TemplateList<int>();

            //intStack.Push(2);
            //intStack.Push(3);
            //intStack.Pop();
            //intStack.Display(intStack);

            //StackLL<int> myStack = new StackLL<int>();
            //myStack.Push(1);
            //myStack.Push(2);
            //while (myStack.noOfElements) ;
            //{

            //}
            myStack<int> s = new myStack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Pop();
            s.Reverse();
            s.Display();
            reverseStack<int>(s);

        }
    }
}
