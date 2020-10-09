using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void InputArray(int[] arr)
        {
            String[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = int.Parse(input[i]);
            }
        }

        public static findMin(int[] src)
        {
            PriorityQueue p = new PriorityQueue();
            int[] distVictim = new int[8];
            bool[] isVisited = new bool[8];
            distVictim[0] = 0;
            p.Push(addList[i]);
            int i = 0;
            while (p.Top() != -1)
            {
                var currentNode = p.Pop();
                if (isVisited[i] == false)
                {
                    distVictim[i] = Math.Min(currentNode.weight + distVictim[addList[i]];
                    isVisited[i] = false;
                }
                else
                    continue;
X                i++;
                p.Push(addList.Contains())
            }

           
        }

    }
}
