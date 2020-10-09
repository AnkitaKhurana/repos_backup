using System;

class Class1
{
    public class myStack<T> : Stack<T>
    {
        public new void Push(T data)
        {
            base.Push(data);           
        }
        public new void Pop(T data)
        {
            base.Pop();
        }
        public new void Peek()
        {
            return base.Peek();
        }
        public new void Reverse()
        {
            myStack<T> reverseStack = new myStack<T>();
            while(this.Peek != null)
            {
                myStack.Push(this.Pop);
            }

        }
        public new void Display()
        {

        }
    }
    public static void insertAtBottom<T>(StackLL<T> stk, T element)
    {
        if (stk.noOfElements == 0)
        {
            stk.Push(elementToInsert);
            return;
        }
        T topObj = stk.Top();
        stk.Pop();
        insertAtbottom(stk, element);
        stk.push(topObj);

    }
    public static void reverseStack<T>(StackLL<T> stk, T elementToInsert)
    {
        if (stk.noOfElements == 0)
        {
            return;
        }
        T topObj = stk.Top();
        stk.Pop();
        reverseStack(stk);
        insertAtbottom(stk, topObj);

    }
    public Class1()
	{
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
