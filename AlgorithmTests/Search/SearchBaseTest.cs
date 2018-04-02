using Algorithm.Search;
using Xunit;

namespace AlgorithmTests.Search
{
    public class SearchBaseTest
    {
        public ISearch search;

        public virtual void searchTest_Normal(int[] sourceArr, int searchValue, int expect)
        {
            if (search == null)
            {
                Assert.Null(search);
                return;
            }

            int actual = search.Search(sourceArr, searchValue);

            Assert.Equal(expect, actual);

        }
    }
}
