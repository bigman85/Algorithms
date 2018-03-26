namespace Algorithm.Sort
{
    public class MergeSort : SortBase
    {
        public override void Sort(int[] arr)
        {
            if (arr.Length < 2)
            {
                return;
            }

            var arrHeader = new int[arr.Length / 2];
            var arrFooter = new int[arr.Length - arrHeader.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arrHeader.Length)
                {
                    arrHeader[i] = arr[i];
                }
                else
                {
                    arrFooter[i - arrHeader.Length] = arr[i];
                }
            }
            Sort(arrHeader);
            Sort(arrFooter);
            Merge(arr, arrHeader, arrFooter);
        }

        private void Merge(int[] arr, int[] arrHeader, int[] arrFooter)
        {
            for (int i = 0, j = 0; i + j < arr.Length;)
            {
                if (j == arrFooter.Length || (i < arrHeader.Length && arrHeader[i] < arrFooter[j]))
                {
                    arr[i + j] = arrHeader[i];
                    i++;
                }
                else
                {
                    arr[i + j] = arrFooter[j];
                    j++;
                }
            }
        }
    }
}
