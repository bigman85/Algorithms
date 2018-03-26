using Algorithm.Sort;
using Xunit;

namespace AlgorithmTests.Sort
{
    public class SortBaseTest
    {
        public ISort Sort;

        [Theory]
        [InlineData(new int[] { 4, 2, 7, 998, 23, 4, 8, 3, 1, -40 }, new int[] { -40, 1, 2, 3, 4, 4, 7, 8, 23, 998 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 4, 5, 3, 4, 3 },new int[] { 3, 3, 4, 4, 5 })]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, new int[] { -5, -4, -3, -2, -1 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { }, new int[] { })]
        public virtual void SortTest_Normal(int[] sourceArr, int[] expectArr)
        {
            if (Sort == null)
            {
                Assert.Null(Sort);
                return;
            }

            Sort.Sort(sourceArr);

            Assert.Equal(expectArr.Length, sourceArr.Length);
            for (int i = 0; i < expectArr.Length; i++)
            {
                Assert.Equal(expectArr[i], sourceArr[i]);
            }

        }
    }
}
