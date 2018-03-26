using System;

namespace Algorithm.Sort
{
    public class QuickSort : SortBase
    {
        public override void Sort(int[] arr)
        {
            SubArraySort(arr, 0, arr.Length - 1);
        }

        public void SubArraySort(int[] arr, int start, int end)
        {
            if (end - start < 2)
            {
                return;
            }

            int pivot = arr[arr.Length - 1];
            int storeIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > pivot)
                {
                    Swap(arr, i, storeIndex);
                    storeIndex++;
                }
            }

            SubArraySort(arr, 0, storeIndex - 1);
            SubArraySort(arr, storeIndex + 1, arr.Length - 1);

        }
    }
}
