using Xunit;

namespace Calculator.Tests
{
    public class CalculationsTests
    {
        [Fact]
        public void TestProcessStatement()
        {
            Calculations calculation = new();
            string result = calculation.ProcessStatement(" ", " ");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("a", "a+a");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("", "-");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("a", "");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("", "999999999+1");
            Assert.Equal("EXCEEDED", result);
            result = calculation.ProcessStatement("-", "999999999-1");
            Assert.Equal("EXCEEDED", result);
        }
        [Fact]
        public void TestSum()
        {
            Calculations calculation = new();
            string result = calculation.ProcessStatement("", "2+3");
            Assert.Equal("5", result);
            result = calculation.ProcessStatement("", "6+16");
            Assert.Equal("22", result);
            result = calculation.ProcessStatement("", "1+1");
            Assert.Equal("2", result);
            result = calculation.ProcessStatement("-", "2+10");
            Assert.Equal("8", result);
            result = calculation.ProcessStatement("-", "5-5");
            Assert.Equal("-10",result);
        }
        [Fact]
        public void TestMultiple()
        {
            Calculations calculation = new();
            string result = calculation.ProcessStatement("", "2*2");
            Assert.Equal("4", result);
            result = calculation.ProcessStatement("", "5*2");
            Assert.Equal("10", result);
            result = calculation.ProcessStatement("", "2*");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("", "2*qwerty");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("", "2*+");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("-", "5*2");
            Assert.Equal("-10", result);
        }
        [Fact]
        public void TestSubtractResultFife()
        {
            Calculations calculation = new();
            string result = calculation.ProcessStatement("", "3+2");
            Assert.Equal("5", result);
        }
        [Fact]
        public void TestSubtractResultMinusOne()
        {
            Calculations calculation = new();
            string result = calculation.ProcessStatement("-", "3+2");
            Assert.Equal("-1", result);
        }            
        [Fact]
        public void TestSubtractResultMinusFour()
        {
            Calculations calculation = new();
            string result = calculation.ProcessStatement("", "1-5");
            Assert.Equal("-4", result);
        }
        [Fact]
        public void TestSubtractResultZero()
        {
            Calculations calculation = new();
            string result = calculation.ProcessStatement("", "3--");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("-", "47-f");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("", "2-3f");
            Assert.Equal("0", result);
        }
        [Fact]
        public void TestDivide()
        {
            Calculations calculation = new();
            string result = calculation.ProcessStatement("", "5/1");
            Assert.Equal("5", result);
            result = calculation.ProcessStatement("", "4/3");
            Assert.Equal("1", result);
            result = calculation.ProcessStatement("", "5/a");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("-", "14/2");
            Assert.Equal("-7", result);
            result = calculation.ProcessStatement("", "0/5");
            Assert.Equal("NOT ÷ 0", result);
            result = calculation.ProcessStatement("", "5/0");
            Assert.Equal("NOT ÷ 0", result);
        }
        [Fact]
        public void TestSign()
        {
            Calculations calculation = new();
            string result = calculation.ProcessStatement("-", "10-2");
            Assert.Equal("-12", result);
            result = calculation.ProcessStatement("-", "2+5");
            Assert.Equal("3", result);
            result = calculation.ProcessStatement("-", "10/2");
            Assert.Equal("-5", result);
            result = calculation.ProcessStatement("-", "10*5");
            Assert.Equal("-50", result);
        }
    }
}