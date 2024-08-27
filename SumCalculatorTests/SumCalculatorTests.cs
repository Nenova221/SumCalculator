using Newtonsoft.Json.Linq;
using SumCalculator;
namespace SumCalculatorTests
{
    public class SumCalculatorTests
    {
        [Theory]
        [InlineData(0.001, 0.694)]
        [InlineData(0.0001, 0.693)]
        public void CalculatingSum_WithCalculatingSum_ShouldReturnCorrectSum(double input, double expectedSum)
        {
            double result = Sum.CalculatingSum(input, expectedSum);
            Assert.Equal(expectedSum, result, 3);
        }
        [Theory]
        [InlineData(-0.001, 0.639)]
        [InlineData(-0.9751, 0.355)]
        public void CalculatingSum_WithInvalidInput_ShouldThrowExeption(double input, double expectedSum)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Sum.CalculatingSum(input, expectedSum));
        }
    }
}