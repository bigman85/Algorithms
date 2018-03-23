namespace Algorithm.Sort
{
    public abstract class SortBase : ISort
    {
        public abstract void Sort(int[] arr);

        public void Swap(int[] arr, int i, int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }
    }
}
