using System;
using testcaseslibrary;
using Xunit;

namespace TestMathLib
{
    public class TestMathLibrary
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(6,2,8)]
        [InlineData(0,1,1)]
        [InlineData(-1,-2, -3)]
        [InlineData(1, -4, -3)]
        [InlineData(int.MaxValue, int.MinValue, -1)]        
        public void TestAdd(int i, int j, int ans)
        {
            var mathlib = new MathLib();
            Assert.Equal(ans, mathlib.Add(i, j));
        }

        [Theory]
        [InlineData(7,5,2)]
        [InlineData(-3,-4,1)]
        [InlineData(3,0,3)]
        public void TestSubtract(int i, int j, int ans)
        {
            var mathlib = new MathLib();
            Assert.Equal(ans, mathlib.Subtract(i, j));
        }

        [Theory]
        [InlineData(1,2,2)]
        [InlineData(4,-4,-16)]
        [InlineData(0,4,0)]
        public void TestMultiply(int i, int j, int ans)
        {
            var mathlib = new MathLib();
            Assert.Equal(ans, mathlib.Multiply(i, j));
        }

        [Theory]
        [InlineData(8,2,4)]
        [InlineData(10,-2,-5)]        
        public void TestDivide(int i, int j, int ans)
        {
            var mathlib = new MathLib();
            if(j==0)
            {
                Assert.ThrowsAny<DivideByZeroException>(() => mathlib.Divide(i, j));
                return;
            }
            Assert.Equal(ans, mathlib.Divide(i, j));
        }

        [Theory]
        [InlineData(2,4)]
        [InlineData(4,16)]
        [InlineData(-2,4)]
        public void TestSquare(int i, int ans)
        {
            var mathlib = new MathLib();
            Assert.Equal(ans, mathlib.Square(i));
        }

        [Theory]
        [InlineData(1,4,1)]
        [InlineData(2,4,16)]
        [InlineData(4,3,64)]
        public void TestPower(int i, int j, int ans)
        {
            var mathlib = new MathLib();
            Assert.Equal(ans, mathlib.Power(i, j));
        }

        [Theory]
        [InlineData(3,6)]
        [InlineData(5,120)]
        public void TestFactorial(int i, int ans)
        {
            var mathlib = new MathLib();
            Assert.Equal(ans, mathlib.Factorial(i));
        }

        [Theory]
        [InlineData(6,2,0)]
        [InlineData(6,4,2)]
        public void TestModulo(int i, int j, int ans)
        {
            var mathlib = new MathLib();
            Assert.Equal(ans, mathlib.Modulo(i, j));
        }
    }
}
