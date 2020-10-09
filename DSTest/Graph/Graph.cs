using System;
using System.Collections.Generic;
using System.Linq;

namespace Graph
{
    /// <summary>
    /// Graph Class to handle Graphs Implementation
    /// </summary>
    class Graph
    {
        // Number of Vertices in Graph
        int NoOfVertices;
        // Dictionaty to maintain Adjacency List
        Dictionary<int, List<int>> AdjacencyList;

        /// <summary>
        /// Constructor of Graph Class
        /// </summary>
        /// <param name="vertex"></param>
        public Graph(int vertex)
        {
            this.NoOfVertices = vertex;
            AdjacencyList = new Dictionary<int, List<int>>();
        }

        /// <summary>
        /// Function Adds And Edge to the Graph 
        /// </summary>
        /// <param name="src"></param>
        /// <param name="des"></param>
        public void AddEdge(int src, int des)
        {
            if (AdjacencyList.ContainsKey(src) == false)
            {
                AdjacencyList.Add(src, new List<int>());
            }
            if (AdjacencyList.ContainsKey(des) == false)
            {
                AdjacencyList.Add(des, new List<int>());
            }
            AdjacencyList[src].Add(des);
            // Here Undirected graph therefore adding des to src too
            AdjacencyList[des].Add(src);
        }
        private int findNewSrc(HashSet<int> visited)
        {
            for(int i = 0; i < AdjacencyList.Count; i++)
            {
                if (visited.Contains(AdjacencyList.ElementAt(i).Key) == false)
                {
                    Console.WriteLine("Sending source: " + AdjacencyList.ElementAt(i).Key);
                    return AdjacencyList.ElementAt(i).Key;
                }
                    
            }
            return -1;
        }    
        /// <summary>
        /// Private Find Cycle in a graph
        /// </summary>
        /// <param name="src"></param>
        /// <param name="visted"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        private bool FindCycle(int src, HashSet<int> visted, int parent)
        {
            
            // Add Visited to Graph
            visted.Add(src);
            // Find the current List cooresponding to source 
            var currentList = AdjacencyList[src];
                     
            // Loop to check all Neighbours of src
            for (int i = 0; i < currentList.Count; i++)
            {
                if (visted.Contains(currentList.ElementAt(i)) == false)
                {
                    visted.Add(currentList.ElementAt(i));
                    parent = src;
                    FindCycle(currentList.ElementAt(i), visted, parent);                        
                }
                else
                {
                    if (parent != currentList.ElementAt(i))
                    {
                        return true;                        
                    }
                }
            }
            return false;
          
        }

        /// <summary>
        /// Find Cycle for User
        /// </summary>
        /// <returns></returns>
        public bool FindCycle()
        {           
            HashSet<int> visited = new HashSet<int>();
            
                for(int i = 0; i < AdjacencyList.Count; i++)
                {
                    int src = AdjacencyList.ElementAt(i).Key;
                    if(visited.Contains(src)==false)
                    if (FindCycle(src, visited, src) == true)
                        return true;
                }             
            return false;
        }

        /// <summary>
        /// Function to Print Graph 
        /// </summary>
        public void PrintGraph()
        {
            for (int i = 0; i < AdjacencyList.Count; i++)
            {
                var pairs = AdjacencyList.ElementAt(i);
                Console.Write(pairs.Key + "( ");
                for (int pair = 0; pair < pairs.Value.Count; pair++)
                {
                    Console.Write(" " + pairs.Value.ElementAt(pair));
                }
                Console.WriteLine(" )");
            }
        }

    }
}