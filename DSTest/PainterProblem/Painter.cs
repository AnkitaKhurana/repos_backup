using System;
using System.Linq;

namespace PainterProblem
{
    class PainterProb
    {
        /// <summary>
        ///  Function to Calculate the Minimum Time required for Work completion
        /// </summary>
        /// <param name="Boards"></param>
        /// <param name="TotalPainters"></param>
        /// <returns></returns>
        public long MinimumTimeRequired(long[] Boards, long TotalPainters)
        {
            // Starting the begin Value by 0 
            long Beggining = 0;
            // Assigning Max Possible time to Total sum of board sizes
            long MaximumValue = Boards.Sum();
            // Assign Least Time initially to total sum of board i.e all work given to 1 painter
            long LeastTime = MaximumValue;

            // Work till the start value in implemented Binary Search is less than max value
            while (Beggining <= MaximumValue)
            {
                // assuming the mean to be the best way to divide the board
                long currentMean = (Beggining + MaximumValue) / 2;
                // Find if the assumed mean was working for the boards and painters
                if (CheckForMean(Boards, TotalPainters, currentMean) == true)
                {
                    // True means that the allocation to painter for current Mean size if valid
                    // Hence check now for lower values than mean to allocate more work to painter
                    LeastTime = currentMean;
                    MaximumValue = currentMean - 1;
                }
                else
                {
                    // this will again check for higher mean on the right 
                    Beggining = currentMean + 1;
                }
            }
            return LeastTime;
        }
        /// <summary>
        /// Function to Find the Acceptance of current Mean for problem
        /// </summary>
        /// <param name="Boards"></param>
        /// <param name="TotalPainters"></param>
        /// <param name="CurrentMean"></param>
        /// <returns></returns>
        static bool CheckForMean(long[] Boards, long TotalPainters, long CurrentMean)
        {
            // Initialising Painters to 1 initially will iterate to Total Painters
            long PaintersRequired = 1;
            // Board Assigned Score
            long BoardsAssigned = 0;

            for (long BoardIndex = 0; BoardIndex < Boards.Length; ++BoardIndex)
            {
                long currentBoard = Boards[BoardIndex];
                if (BoardsAssigned + currentBoard <= CurrentMean)
                {
                    // Current Board can be assigned to painter
                    BoardsAssigned = BoardsAssigned + currentBoard;
                }
                else
                {
                    // Current board cannot be assigned to Painter
                    // Goto Next Painter
                    ++PaintersRequired;
                    if (PaintersRequired > TotalPainters)
                    { return false; }
                    if (currentBoard <= CurrentMean)
                    {
                        // Reassign Boards Assigned for new Painter 
                        BoardsAssigned = currentBoard;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            return true;
        }
        /// <summary>
        /// Function to Input Integer Arrays 
        /// </summary>
        /// <param name="arr"></param>
        public void Input(long[] arr)
        {
            String[] input = Console.ReadLine().Split(' ');
            for (long i = 0; i < arr.Length; ++i)
            {
                if (!long.TryParse(input[i], out arr[i]))
                {
                    throw new Exception("Not a Number!");
                }
            }
        }
    }
}