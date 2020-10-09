using System.Collections.Generic;

namespace Bank
{
    class PriorityQueue
    {
        List<Customer> List;
        int Size;
        static int TimeStamp;

        private int Parent(int index) { return index >> 1; }
        private int Left(int index) { return (index << 1); }
        private int Right(int index) { return (index << 1) + 1; }

        // Constructor or Priority Queue
        public PriorityQueue()
        {
            List = new List<Customer>();
            Size = 0;
            List.Add(null);
            PriorityQueue.TimeStamp = 1;
        }

        // Get Size of List
        public int GetSize()
        {
            return Size;
        }

        // Push new Customer in heap
        public void Push(Customer newCustomer)
        {
            newCustomer.Priority2 = TimeStamp;
            TimeStamp++;
            List.Add(newCustomer);
            ++Size;
            int currentIndex = Size;
            while (Parent(currentIndex) >= 1 && List[currentIndex].GetPriority() < List[Parent(currentIndex)].GetPriority())
            {
                Customer tempCustomer = List[currentIndex];
                List[currentIndex] = List[Parent(currentIndex)];
                List[Parent(currentIndex)] = tempCustomer;
                currentIndex = Parent(currentIndex);
            }
        }

        // Pop the Top most Element in Heap
        public void Pop()
        {
            if (Size == 0) return;
            Customer tempCustomer = List[1];
            List[1] = List[Size];
            List[Size] = tempCustomer;
            List.RemoveAt(Size);
            --Size;
            Heapify(1);
        }

        // Heapify the Heap
        private void Heapify(int currentIndex)
        {
            int minimumIndex = currentIndex;
            if (Left(currentIndex) <= Size && List[Left(currentIndex)].GetPriority() < List[currentIndex].GetPriority())
            {
                minimumIndex = Left(currentIndex);
            }
            else if (Left(currentIndex) <= Size && List[Left(currentIndex)].GetPriority() == List[currentIndex].GetPriority())
            {
                if (List[Left(currentIndex)].Priority2 < List[currentIndex].Priority2)
                {
                    minimumIndex = Left(currentIndex);
                }
            }

            if (Right(currentIndex) <= Size && List[Right(currentIndex)].GetPriority() < List[minimumIndex].GetPriority())
            {
                minimumIndex = Right(currentIndex);
            }
            else if (Right(currentIndex) <= Size && List[Right(currentIndex)].GetPriority() == List[minimumIndex].GetPriority())
            {
                if (List[Right(currentIndex)].Priority2 < List[minimumIndex].Priority2)
                {
                    minimumIndex = Right(currentIndex);
                }
            }

            if (currentIndex != minimumIndex)
            {
                Customer tempCustomer = List[currentIndex];
                List[currentIndex] = List[minimumIndex];
                List[minimumIndex] = tempCustomer;
                Heapify(minimumIndex);
            }

        }

        // Returns the Top of List
        public Customer Top()
        {
            if (Size == 0) return null;
            return List[1];
        }
    }
}

