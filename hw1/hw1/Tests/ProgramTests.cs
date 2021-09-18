using hw1;
using Xunit;

namespace Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(new string[]{"3245", "+", "(*&hf3702"},1)]
        [InlineData(new string[]{"1", "/", "4", "12fwfwef"},1)]
        public void Main_WrongInput_NotReturnZero(string[] args,int a)
        {
            var result = Program.Main(args);
            Assert.True(result > 0);
        }
        
        [Fact]
        public void Main_CorrectInput_ReturnZero()
        {
            var args = new[] { "100", "+", "200" };
            var result = Program.Main(args);
            Assert.True(result == 0);
        }
    }
}