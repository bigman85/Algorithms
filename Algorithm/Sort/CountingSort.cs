namespace Algorithm.Sort
{
    public class CountingSort : SortBase
    {
        public override void Sort(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                max = max > arr[i] ? max : arr[i];
            }

            int[] counting = new int[max + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                counting[arr[i]]++;
            }

            for (int i = 0, t = 0; i < counting.Length && t < arr.Length; i++)
            {
                for (int j = 0; j < counting[i]; j++, t++)
                {
                    arr[t] = i;
                }
            }

        }
    }
}
