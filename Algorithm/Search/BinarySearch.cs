namespace Algorithm.Search
{
    public class BinarySearch : SearchBase
    {
        public override int Search(int[] arr, int value)
        {
            int res = -1;
            int min = 0;
            int max = arr.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (arr[mid] == value)
                    return mid;
                if (arr[mid] > value)
                    max = mid - 1;
                if (arr[mid] < value)
                    min = mid + 1;
            }

            return res;
        }
    }
}
