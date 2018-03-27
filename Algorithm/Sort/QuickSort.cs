using System;

namespace Algorithm.Sort
{
    public class QuickSort : SortBase
    {
        public override void Sort(int[] arr)
        {
            SubArraySort(arr, 0, arr.Length);
        }


        void SubArraySort(int[] arr, int start, int length)
        {
            if (length <= 1)
            {
                return;
            }

            int storeIndex = GetPartion(arr, start, length);

            SubArraySort(arr, start, storeIndex - start);
            SubArraySort(arr, storeIndex + 1, start + length - storeIndex - 1);

        }
        int GetPartion(int[] arr, int start, int length)
        {
            int res = start + length - 1;
            int pivot = arr[start + length - 1];
            for (int i = 0; i < length && res < start + length; i++)
            {
                if (arr[start + i] > pivot)
                {
                    for (int j = i; j < length; j++)
                    {
                        if (arr[start + j] <= pivot)
                        {
                            Swap(arr, start + i, start + j);
                            res = start + i;
                            break;
                        }
                    }
                }
            }

            return res;
        }
    }
}
