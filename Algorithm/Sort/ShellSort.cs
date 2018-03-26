namespace Algorithm.Sort
{
    public class ShellSort : SortBase
    {
        public override void Sort(int[] arr)
        {
            //增量每次都/2
            for (int step = arr.Length / 2; step >= 1; step = step / 2)
            {
                //从增量那组开始进行插入排序，直至完毕
                for (int i = step; i < arr.Length; i++)
                {

                    for (int j = i, cur = arr[i]; j >= 0; j -= step)
                    {
                        if (j < step || cur >= arr[j - step])
                        {
                            arr[j] = cur;
                            break;
                        }
                        else
                        {
                            arr[j] = arr[j - step];
                        }
                    }
                }
            }
        }
    }
}
