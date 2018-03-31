using Algorithm.Sort;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var hs = new CountingSort();
            var arr = new int[] { 1,2,3,4,5 };
            hs.Sort(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
