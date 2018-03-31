namespace Algorithm.Sort
{
    public class HeapSort : SortBase
    {
        public override void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                GenerateHeap(arr, arr.Length - i);
                Swap(arr, 0, arr.Length - i - 1);
            }
        }

        private void GenerateHeap(int[] arr, int length)
        {
            for (int i = length / 2; i >= 0; i--)
            {
                if (2 * i + 1 < length && arr[i] < arr[2 * i + 1])
                {
                    Swap(arr, i, 2 * i + 1);
                }
                if (2 * i + 2 < length && arr[i] < arr[2 * i + 2])
                {
                    Swap(arr, i, 2 * i + 2);
                }
                if (2 * i + 2 < length && arr[2 * i + 1] < arr[2 * i + 2])
                {
                    Swap(arr, 2 * i + 1, 2 * i + 2);
                }
            }
        }
    }
}
