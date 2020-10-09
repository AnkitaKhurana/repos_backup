using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number of Vertices : ");
                if (!int.TryParse(Console.ReadLine(), out int vertices))
                {
                    throw new Exception("Not a Valid Integer");
                }
                Console.WriteLine("Enter number of Edges : ");
                if (!int.TryParse(Console.ReadLine(), out int edges))
                {
                    throw new Exception("Not a Valid Integer");
                }
                Graph graph = new Graph(vertices);
                for (int item = 0; item < edges; item++)
                {
                    if (!int.TryParse(Console.ReadLine(), out int src))
                    {
                        throw new Exception("Not a Valid Integer");
                    }
                    if (!int.TryParse(Console.ReadLine(), out int dest))
                    {
                        throw new Exception("Not a Valid Integer");
                    }
                    graph.AddEdge(src, dest);
                }
                graph.PrintGraph();
                if (graph.FindCycle() == true)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

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
