using System;

namespace Algorithm.Sort
{
    public class SelectionSort : SortBase
    {
        public override void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int tmp = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    tmp = arr[tmp] < arr[j] ? tmp : j;
                }

                if(tmp != i)
                {
                    Swap(arr, tmp, i);
                }
            }
        }
    }
}
