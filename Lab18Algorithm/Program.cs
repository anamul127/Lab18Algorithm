using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18Algorithm
{
    class Program
    {
        const int Size = 14;
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 1, 2, 2, 3, 4, 5, 6, 7, 10, 5, 2, 3, 10 };

            int[] Count = new int[10 + 1];
            int i = 0;

            for (i = 0; i < Size - 1; i++)
            {
                if (num[i] > 0 && num[i] < Size)
                {
                    // Use value from numbers as the index for Count and increment the count
                    Count[num[i]]++;
                }
            }

            for (i = 0; i < Count.Length; i++)
            {
                // Check all values in Count, printing the ones where the count is 4
                if (Count[i] > 1)
                    Console.WriteLine($"{1}");


            }
        }
    }
}
