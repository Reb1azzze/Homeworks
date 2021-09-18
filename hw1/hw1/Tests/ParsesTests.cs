using hw1;
using Xunit;

namespace Tests
{
    public class ParsesTests
    {
        [Theory]
        [InlineData(new string[]{"2","/","/"},1)]
        [InlineData(new string[]{",","*","4"},1)]
        public void InputWrongArguments(string[] args, int expected)
        {
            var result = Parser.CheckInput(args,
                out var firstArg,
                out var operation,
                out var secondArg);
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(new string[]{"2","v","3"},2)]
        [InlineData(new string[]{"1","^","4"},2)]
        public void InputWrongOperation(string[] args, int expected)
        {
            var result = Parser.CheckInput(args,
                out var firstArg,
                out var operation,
                out var secondArg);
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(new string[]{"2","+","3"},0)]
        [InlineData(new string[]{"1","/","4"},0)]
        public void ParserReturnsZero(string[] args, int expected)
        {
            var result = Parser.CheckInput(args,
                out var firstArg,
                out var operation,
                out var secondArg);
            Assert.Equal(expected, result);
        }

    }
}