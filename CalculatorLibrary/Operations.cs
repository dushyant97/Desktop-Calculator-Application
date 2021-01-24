using System;

namespace Grapecity.Internship.Assignments.CalculatorLibrary
{
    public class ArithmaticOperations
    {
        /// <summary>
        /// Add method for two or more decimal numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static double Add(double a, double b, params double[] nums)

        {
            double output = a + b;
            foreach (double c in nums)
            {
                output += c;
            }

            return output;
        }

        /// <summary>
        /// Subtract method for two or more decimal numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Subtract(double a, double b, params double[] nums)
        {
            double output = a - b;
            foreach (double c in nums)
            {
                output -= c;
            }
            return output;
        }

        /// <summary>
        /// Returns multiple of two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// returns division of two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Divide(double a, double b)
        {
            return a / b;
        }

        /// <summary>
        /// Returns SquareRoot of a number
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }

        /// <summary>
        /// Returns number with opposite sign
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double PlusMinus(double a)
        {
            if(a == 0)
            {
                return 0;
            }
            else
            {
                return -a;
            }
        }
    }

    public class ScientificOperations : ArithmaticOperations

    {
        /// <summary>
        /// Returns Cosine of the input parameter
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Cos(double a)
        {
            return Math.Cos(a);

        }

        /// <summary>
        /// Returns Sine of the input parameter
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Sin(double a)
        {
            return Math.Sin(a);
        }

        /// <summary>
        /// Returns Tangent of the input parameter
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Tan(double a)
        {
            return Math.Tan(a);
        }

        /// <summary>
        /// This method performs increment operation on a number
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Increment(double a)
        {
            return a + 1;
        }

        /// <summary>
        /// This method performs decrement operation on a number
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Decrement(double a)
        {
            return a - 1;
        }

        /// <summary>
        /// This method returns factorial of a number
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int Factorial(int a)
        {
            int result = 1;
            if(a == 0)
            {
                return result;
            }
            else if(a < 0)
            {
                return 0;
            }
            else
            {
                while (a != 1)
                {
                    result *= a;
                    a -= 1;
                }
                return result;

            }
        }

        /// <summary>
        /// This method returns inverse of a number
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Inverse(double a)
        {
            return (1 / a);
        }

        /// <summary>
        /// This method returns Log to base 10 for a number
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Log10(double a)
        {
            return Math.Log10(a);
        }

        /// <summary>
        /// This method returns Log to the base e for a number
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Ln(double a)
        {
            return Math.Log(a);
        }
    }
}
