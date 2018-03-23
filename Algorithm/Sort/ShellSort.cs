using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sort
{
    public class ShellSort : SortBase
    {
        public override void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i, cur = arr[i]; j >= 0; j--)
                {
                    if (j == 0 || cur >= arr[j - 1])
                    {
                        arr[j] = cur;
                        break;
                    }
                    else
                    {
                        arr[j] = arr[j - 1];
                    }
                }
            }
        }
    }
}
