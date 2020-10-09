using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{

    class HashTables
    {
        private List<LinkedList<Node>> Table;
        int Capacity;
        int NumOfItems;
        private static int PRIME = 7;

        public HashTables()
        {
            int capacity = PRIME;
            NumOfItems = 0;
            Table = new List<LinkedList<Node>>(capacity);
        }
        public void insert(string key, string value)
        {
            Node currentNode = new Node(key,value);
            InsertIntoTable(currentNode);
            ++NumOfItems;
        }
        private void InsertIntoTable(Node node)
        {
            int indexToInsertAt = getIndex(node.key);
            ref LinkedList<Node> listToInsert = Table[indexToInsertAt];
            listToInsert.AddFirst(node);
            if (LoadFactor() > 0.7)
            {
                reHash();
            }

        }
        private int getIndex(string key)
        {
            int ans = -1;
            int multiply = 1;


        }
        double LoadFactor()
        {
            return  ;
        }
        public void rehash()
        {

        }
    }
}
