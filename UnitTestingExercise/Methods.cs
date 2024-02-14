using System;
namespace UnitTestingExercise.Tests
{
	public class Methods
	{
		public int Add(int num1, int num2, int num3, int expected)
		{
			return expected = num1 + num2 + num3;
		}

        public int Subtract(int minuend, int subtrhend, int expected)
        {
            return expected = minuend - subtrhend;
        }

        public int Multiply(int num1, int num2, int expected)
        {
            return expected = num1 * num2;

        }
        public int Divide(int num1, int num2, int expected)
        {
            return expected = num1 / num2;
        }
    }
}

