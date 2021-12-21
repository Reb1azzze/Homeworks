using Xunit;

namespace hw8.Tests
{
    public class CalcTests
    {
        [Theory]
        [InlineData(1, 2, "3")]
        [InlineData(-1, -1, "-2")]
        [InlineData(5.4, 1.3, "6.7")]
        public void Plus_TwoNumbers_ReturnSum(double val1, double val2, string expResult)
        {
            //arrange
            Calculator.Calculator calculator = new Calculator.Calculator();

            //act
            var actual = calculator.Plus(val1, val2);

            //assert
            Assert.Equal(actual, expResult);
        }

        [Theory]
        [InlineData(1, 2, "-1")]
        [InlineData(-5.5, 2, "-7.5")]
        [InlineData(10, -24.3, "34.3")]
        public void Minus_TwoNumbers_ReturnDiff(double val1, double val2, string expResult)
        {
            //arrange
            Calculator.Calculator calculator = new Calculator.Calculator();

            //act
            var actual = calculator.Minus(val1, val2);

            //assert
            Assert.Equal(actual, expResult);
        }

        [Theory]
        [InlineData(1, 2, "2")]
        [InlineData(-5.5, 2, "-11")]
        [InlineData(0, 24.3, "0")]
        public void Multiply_TwoNumbers_ReturnMultiplication(double val1, double val2, string expResult)
        {
            //arrange
            Calculator.Calculator calculator = new Calculator.Calculator();

            //act
            var actual = calculator.Multiply(val1, val2);

            //assert
            Assert.Equal(actual, expResult);
        }

        [Theory]
        [InlineData(1, 2, "0.5")]
        [InlineData(-5, 2, "-2.5")]
        [InlineData(110, 0, "divide by zero")]
        public void Divide_TwoNumbers_ReturnQuotient(double val1, double val2, string expResult)
        {
            //arrange
            Calculator.Calculator calculator = new Calculator.Calculator();

            //act
            var actual = calculator.Divide(val1, val2);

            //assert
            Assert.Equal(actual, expResult);
        }
    }
}