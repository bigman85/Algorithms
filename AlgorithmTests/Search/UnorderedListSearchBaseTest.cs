using Xunit;

namespace AlgorithmTests.Search
{
    public class UnorderedListSearchBaseTest : SearchBaseTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, 2)]
        [InlineData(new int[] { 14, 5, 13, 125, 4, 3 }, 125, 3)]
        [InlineData(new int[] { 14, 5, 13, 125, 4, 3 }, 3, 5)]
        [InlineData(new int[] { 14, 5, 13, 125, 4, 3 }, 14, 0)]
        [InlineData(new int[] { 4, 2, 7, 998, 23, 4, 8, 3, 1, -40 }, -40, 9)]
        [InlineData(new int[] { 4, 2, 7, 998, 23, 4, 8, 3, 1, -40 }, 997, -1)]
        public override void searchTest_Normal(int[] sourceArr, int searchValue, int expect)
        {
            base.searchTest_Normal(sourceArr, searchValue, expect);
        }
    }
}
