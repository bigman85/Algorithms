namespace Algorithm.Search
{
    public class SequenceSearch : SearchBase
    {
        public override int Search(int[] arr, int value)
        {
            int res = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == value)
                {
                    res = i;
                    break;
                }
            }
            return res;
        }
    }
}
