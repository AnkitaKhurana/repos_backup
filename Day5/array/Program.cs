using System;
using System.Collections;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            int[] array = { 1, 3 , -3, 4, 5 , 6,-2,-4};
           // 1 4 1 5 11 9 5

            int sum = array[0];
            int ans = 0;
            for(int i = 0; i < array.Length; i++)
            {
                h.Add(sum, array[i]);
                sum += array[i];
                if (sum == 0)
                {
                    Console.WriteLine("0 to" + i);
                }
                if (h.Contains(sum))
                {
                    Console.WriteLine(h[sum] + "to" + i);
                }
                
            }

            Console.Write(ans);
            Console.ReadKey();

        }
    }
}
