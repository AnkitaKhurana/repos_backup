using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    class KnightMove
    {
        public static void main()
        {
            int[] srcCoord = new int[2];
            int[] destCoord = new int[2];
            Program.InputArray(srcCoord);
            Program.InputArray(destCoord);

            int moveReq = MinMovesByKnight(srcCoord, destCoord);
            Console.WriteLine(moveReq);

        }
        public static int MinMovesByKnight(int[] src, int[] dest)
        {
            Queue<int> visited = new Queue<int>();
            return bfs(visited, int[] src);   

        }
        public static int bfs(Queue visited, int[] src)
        {
            visited.Enqueue(src);
            var curList = adjList[src];
            for (int i = 0; i < curList.Length; i++)
            {
                string curNbr = curList[i];
                if (visited.Contains(curNbr) == false)
                {
                    bfs(visited, curNbr);
                }
                visited.Enqueue(curNbr);
                visited.Dequeue();
            }
        }
    }
}
