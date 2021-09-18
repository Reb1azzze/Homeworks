using hw1;
using Xunit;

namespace Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_WrongInput_NotReturnZero()
        {
            var args = new[] { "3245", "+", "(*&hf3702" };
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