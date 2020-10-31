using Xunit;

namespace WebApp.Test
{
    public class CalculatorServiceTests
    {
        [Fact]
        public void TestAdd()
        {
            var svc = new CalculatorService();

            var result = svc.Add(4, 4);

            Assert.Equal(8, result);
        }

        [Fact]
        public void TestMultiply()
        {
            var svc = new CalculatorService();

            var result = svc.Multiply(3, 7);

            Assert.Equal(21, result);
        }

        [Fact]
        public void TestSubtraction()
        {
            var svc = new CalculatorService();

            var result = svc.Subtract(39, 12);

            Assert.Equal(27, result);
        }
    }
}
