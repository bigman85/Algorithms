using Algorithm.Sort;
using Xunit;


namespace AlgorithmTests.Sort
{
    public class CountingSortTest : SortBaseTest
    {
        public CountingSortTest()
        {
            Sort = new CountingSort();
        }

        [Theory(Skip = "计数排序法不支持负数")]
        [InlineData(new int[] { 4, 2, 7, 998, 23, 4, 8, 3, 1, -40 }, new int[] { -40, 1, 2, 3, 4, 4, 7, 8, 23, 998 })]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, new int[] { -5, -4, -3, -2, -1 })]
        public override void SortTest_IncludingMinus(int[] sourceArr, int[] expectArr)
        {
            base.SortTest_IncludingMinus(sourceArr, expectArr);
        }
    }
}
