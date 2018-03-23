using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sort
{
    public class BubbleSort : SortBase
    {
        public override void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
        }
    }
}
