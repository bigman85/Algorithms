using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmTests.Search
{
    public class OrderedListSearchBaseTest : SearchBaseTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, 2)]
        [InlineData(new int[] { 3, 4, 5, 13, 14, 125 }, 125, 5)]
        [InlineData(new int[] { 3, 4, 5, 13, 14, 125 }, 3, 0)]
        [InlineData(new int[] { 3, 4, 5, 13, 14, 125 }, 14, 4)]
        [InlineData(new int[] { -40, 1, 2, 3, 4, 4, 7, 8, 23, 998 }, -40, 0)]
        [InlineData(new int[] { -40, 1, 2, 3, 4, 4, 7, 8, 23, 998 }, 997, -1)]
        public override void searchTest_Normal(int[] sourceArr, int searchValue, int expect)
        {
            base.searchTest_Normal(sourceArr, searchValue, expect);

        }
    }
}
