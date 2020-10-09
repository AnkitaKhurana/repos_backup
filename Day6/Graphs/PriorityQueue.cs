using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs

{
    class PriorityQueue
    {
        List<int> List;
        int Size;
        static int TimeStamp;

        private int Parent(int index) { return index >> 1; }
        private int Left(int index) { return (index << 1); }
        private int Right(int index) { return (index << 1) + 1; }

        // Constructor or Priority Queue
        public PriorityQueue()
        {
            List = new List<int>();
            Size = 0;
            List.Add(-1);
            PriorityQueue.TimeStamp = 1;
        }

        // Get Size of List
        public int GetSize()
        {
            return Size;
        }

        // Push new Customer in heap
        public void Push(int newCustomer)
        {
            //newCustomer.Priority2 = TimeStamp;
            //TimeStamp++;
            List.Add(newCustomer);
            ++Size;
            int currentIndex = Size;
            while (Parent(currentIndex).weight >= 1 && List[currentIndex]].weight < List[Parent(currentIndex)].weight)
            {
                //Customer tempCustomer = List[currentIndex];
                //List[currentIndex] = List[Parent(currentIndex)];
                //List[Parent(currentIndex)] = tempCustomer;

                int tempInt = List[currentIndex];
                List[currentIndex] = List[Parent(currentIndex)];
                List[Parent(currentIndex)] = tempInt;

                currentIndex = Parent(currentIndex);
            }
        }

        // Pop the Top most Element in Heap
        public void Pop()
        {
            if (Size == 0) return;

            int tempint = List[1];
            List[1] = List[Size];
            List[Size] = tempint;
            //Customer tempCustomer = List[1];
            //List[1] = List[Size];
            //List[Size] = tempCustomer;


            List.RemoveAt(Size);
            --Size;
            Heapify(1);
        }

        // Heapify the Heap
        private void Heapify(int currentIndex)
        {
            int minimumIndex = currentIndex;
            if (Left(currentIndex) <= Size && List[Left(currentIndex)] < List[currentIndex])
            {
                minimumIndex = Left(currentIndex);
            }
           

            if (Right(currentIndex) <= Size && List[Right(currentIndex)] < List[minimumIndex])
            {
                minimumIndex = Right(currentIndex);
            }        

            if (currentIndex != minimumIndex)
            {
                int tempint = List[currentIndex];
                List[currentIndex] = List[minimumIndex];
                List[minimumIndex] = tempint;

                //Customer tempCustomer = List[currentIndex];
                //List[currentIndex] = List[minimumIndex];
                //List[minimumIndex] = tempCustomer;
                Heapify(minimumIndex);
            }

        }

        // Returns the Top of List
        public int Top()
        {
            if (Size == 0) return -1;
            return List[1];
        }
    }
}

