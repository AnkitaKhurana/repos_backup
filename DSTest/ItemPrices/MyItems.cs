using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ItemPrices
{
    /// <summary>
    ///  Class to handle all the Items List 
    /// </summary>
    class MyItems
    {
        // ListOfItems with Dictionary
        Dictionary<string, int> ListOfItems;
        /// <summary>
        /// Constructor of MyItems
        /// </summary>
        public MyItems()
        {
            ListOfItems = new Dictionary<string, int>();
        }

        /// <summary>
        /// Add new Items to the list
        /// </summary>
        /// <param name="item"></param>
        /// </summary>
        public void AddItems(Item item)
        {
            if (!ListOfItems.ContainsKey(item.Name)){
                ListOfItems.Add(item.Name, item.Price);
            }            
        }

        /// <summary>
        /// Check for Price 
        /// </summary>
        /// <param name="itemToCheck"></param>
        /// <returns></returns>
        public bool ItemPriceMatch(Item itemToCheck)
        {
            if (ListOfItems.ContainsKey(itemToCheck.Name)){
                if (ListOfItems[itemToCheck.Name] == itemToCheck.Price)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Return Total Size of List
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return ListOfItems.Count;
        }

        /// <summary>
        /// Find Element in List
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Item FindElement(int index)
        {
            return new Item(ListOfItems.ElementAt(index).Key,ListOfItems.ElementAt(index).Value);
        }

        /// <summary>
        /// Print List 
        /// </summary>
        public void PrintList()
        {
            for(int i = 0; i < ListOfItems.Count; i++)
            {
                Console.WriteLine(ListOfItems.ElementAt(i).Key + " " + ListOfItems.ElementAt(i).Value);
            }
        }
    }
}
