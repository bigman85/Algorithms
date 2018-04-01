using Algorithm.Sort;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var hs = new QuickSort();
            var arr = new int[] { 14, 5, 13, 125, 4, 3 };
            hs.Sort(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
