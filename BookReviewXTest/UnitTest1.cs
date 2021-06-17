using System;
using Xunit;

namespace BookReviewXTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Contains("shaz", "shaz");
        }
    }
}
