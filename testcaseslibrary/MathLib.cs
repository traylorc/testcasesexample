using System;

namespace testcaseslibrary
{
    public class MathLib : IMathLibrary
    {
        public int Add(int i, int j)
        {
            return i + j;
            throw new NotImplementedException();
        }

        public int Divide(int i, int j)
        {
            return i / j;
            throw new NotImplementedException();
        }

        public int Factorial(int i)
        {
            return i!;
            throw new NotImplementedException();
        }

        public int Modulo(int i, int j)
        {
            return i % j;
            throw new NotImplementedException();
        }

        public int Multiply(int i, int j)
        {
            return i * j;
            throw new NotImplementedException();
        }

        public int Power(int i, int j)
        {
            return (int)Math.Pow(i, j);
            throw new NotImplementedException();
        }

        public int Square(int i)
        {
            return i * i;
            throw new NotImplementedException();
        }

        public int Subtract(int i, int j)
        {
            return i - j;
            throw new NotImplementedException();
        }
    }
}
