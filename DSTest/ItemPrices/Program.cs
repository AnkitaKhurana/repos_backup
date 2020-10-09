
using System;
namespace ItemPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyItems listA = new MyItems();
                if (!int.TryParse(Console.ReadLine(), out int NumberOfItemsA))
                {
                    throw new Exception("Invalid Input");
                }
                for (int indexA = 0; indexA < NumberOfItemsA; indexA++)
                {
                    string entry = Console.ReadLine();
                    string[] splitEntry = entry.Split(' ');
                    listA.AddItems(new Item(splitEntry[0], Int32.Parse(splitEntry[1])));
                }

                MyItems listB = new MyItems();
                if (!int.TryParse(Console.ReadLine(), out int NumberOfItemsB))
                {
                    throw new Exception("Invalid Input");
                }
                for (int indexB = 0; indexB < NumberOfItemsB; indexB++)
                {
                    string entry = Console.ReadLine();
                    string[] splitEntry = entry.Split(' ');
                    listB.AddItems(new Item(splitEntry[0], Int32.Parse(splitEntry[1])));
                }

                int TotalWrongPrices = 0;
                for (int i = 0; i < listB.Count(); i++)
                {
                    if (listA.ItemPriceMatch(listB.FindElement(i)) == false)
                    {
                        TotalWrongPrices += 1;
                    }
                }
                Console.Write(TotalWrongPrices);
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
