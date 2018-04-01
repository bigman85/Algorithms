using System;

namespace Algorithm.Sort
{
    public class QuickSort : SortBase
    {
        public override void Sort(int[] arr)
        {
            SubArraySort(arr, 0, arr.Length-1);
        }


        void SubArraySort(int[] arr, int start, int end)
        {
            if (end-start <1)
            {
                return;
            }

            int storeIndex = GetPartion(arr, start, end);
            SubArraySort(arr, start, storeIndex - 1);
            SubArraySort(arr, storeIndex + 1, end);
        }
        int GetPartion(int[] array, int start, int end)
        {
            int pivot = (int)(start + new Random().NextDouble() * (end - start + 1));
            int smallIndex = start - 1;
            for (int i = start; i <= end; i++)
                if (array[i] <= array[end])
                {
                    smallIndex++;
                    if (i > smallIndex)
                        Swap(array, i, smallIndex);
                }
            return smallIndex;
        }
    }
}
