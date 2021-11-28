using hw4;
using Xunit;

namespace Tests
{
    public class ProgramTests
    {    
        [Fact]
        public void Main_CorrectInput_ReturnZero()
        {
            var args = new[] { "100", "+", "200" };
            var result = Program.main(args);
            Assert.True(result == 0);
        }

        [Fact]
        public void Main_InCorrectInput_ReturnOne()
        {
            var args = new[] { "1&0", "+", "200" };
            var result = Program.main(args);
            Assert.True(result == 1);
        }

        [Fact]
        public void Main_InCorrectInput_ReturnTwo()
        {
            var args = new[] { "100", "||", "200" };
            var result = Program.main(args);
            Assert.True(result == 2);
        }
    }
}