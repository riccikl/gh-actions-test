using Xunit;

namespace WebApp.Test
{
    public class SimpleTests
    {
        [Fact]
        public void TestAdd()
        {
            var result = 4 + 4;

            Assert.Equal(8, result);
        }

        [Fact]
        public void TestMultiply()
        {
            var result = 3 * 7;

            Assert.Equal(21, result);
        }
    }
}
