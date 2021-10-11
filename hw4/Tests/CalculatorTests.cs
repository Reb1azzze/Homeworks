using hw4;
using Xunit;

namespace Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(5,"+", 7, 12)]
        [InlineData(-8,"+", 3, -5)]
        public void Calculate_Plus(int val1, string operation, int val2, int expected)
        {
            var result = Calculator.calculate(val1, operation, val2);
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(49,"-", 53, -4)]
        [InlineData(-63,"-", -53, -10)]
        public void Calculate_Minus(int val1, string operation, int val2, int expected)
        {
            var result = Calculator.calculate(val1, operation, val2);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(55,"*", 2, 110)]
        [InlineData(-8,"*", 0, 0)]
        public void Calculate_Multiply(int val1, string operation, int val2, int expected)
        {
            var result = Calculator.calculate(val1, operation, val2);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(14,"/", 7, 2)]
        [InlineData(50,"/", 1, 50)]
        public void Calculate_Divide(int val1, string operation, int val2, int expected)
        {
            var result = Calculator.calculate(val1, operation, val2);
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(5,"9", 7, 0)]
        [InlineData(-8,"l", 3, 0)]
        public void Calculate_SomethingAnother(int val1, string operation, int val2, int expected)
        {
            var result = Calculator.calculate(val1, operation, val2);
            Assert.Equal(expected, result);
        }
    }
}