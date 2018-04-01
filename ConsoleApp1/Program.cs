using Algorithm.Sort;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var hs = new BucketSort();
            var arr = new int[] { 4, 5, 3, 4, 3};
            hs.Sort(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
