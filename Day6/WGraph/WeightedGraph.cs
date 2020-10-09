using System;
using System.Collections.Generic;
using System.Text;

namespace WGraph
{
    class WeightedGraph<T>
    {
        Dictionary<T, List<Tuple<T, T>>> adjList;
        int numOfVertices;

        public WeightedGraph(int n)
        {
            numOfVertices = n;
            adjList = new Dictionary<T, List<Tuple<T, T>>>();
        }

        public void AddEdge(T src, T dest, T wt)
        {
            if (adjList.ContainsKey(src) == false)
            {
                adjList.Add(src, new List<Tuple<T, T>>());
            }

            if (adjList.ContainsKey(dest) == false)
            {
                adjList.Add(dest, new List<Tuple<T, T>>());
            }

            adjList[src].Add(Tuple<T,T>(dest,wt));
            adjList[dest].Add(Tuple<T,t>(src,wt));
        }
    }
}
