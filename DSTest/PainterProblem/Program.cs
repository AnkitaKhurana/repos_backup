using System;

namespace PainterProblem
{
    class Program
    {
        /// <summary>
        /// Main Function of Project
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {                
                PainterProb P = new PainterProb();
                if (!long.TryParse(Console.ReadLine(), out long NumberOfBoards))
                {
                    throw new Exception("Not a valid Input");
                }
                long[] Boards = new long[NumberOfBoards];
               
                if (!long.TryParse(Console.ReadLine(), out long NumberOfPainters))
                {
                    throw new Exception("Not a valid Input");
                }
                if (!long.TryParse(Console.ReadLine(), out long TimeByEachPainter))
                {
                    throw new Exception("Not a valid Input");
                }
                P.Input(Boards);
                long timeForOneUnit = P.MinimumTimeRequired(Boards, NumberOfPainters);
                Console.WriteLine((timeForOneUnit * TimeByEachPainter) % 10000003);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
