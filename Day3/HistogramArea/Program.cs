using System;
using System.Collections;

namespace HistogramArea
{
    class Program
    {
        static int FindArea(int[] histogram, Stack heightStk, Stack indexStk)
        {
           
            int bestArea = 0;
            for ( int i = 0; i < histogram.Length; i ++)
            {
                int indexToBePushed = i;
                int curBarHeight = i ==histogram.Length ?-1:histogram[i]; //This!
                while (heightStk.Count != 0 && (int)heightStk.Peek() >= curBarHeight)
                {
                    int lengthOfRectangle = i - (int)indexStk.Peek();
                    int currArea = (int)heightStk.Peek() * lengthOfRectangle;
                    bestArea = Math.Max(currArea, bestArea);
                    indexToBePushed = (int)indexStk.Peek();
                    heightStk.Pop();
                    indexStk.Pop();
                }
                indexStk.Push(indexToBePushed);
                heightStk.Push(curBarHeight);
            }
            return bestArea;
        }
        static void Main(string[] args)
        {
            int[] histogram = { 5, 4, 3, 5, 6, 4, 2, 3, 1 };
            Stack heightStk = new Stack();
            Stack indexStack = new Stack();
            Console.Write(FindArea(histogram,heightStk,indexStack));
            Console.ReadKey();
        }
    }
}
;