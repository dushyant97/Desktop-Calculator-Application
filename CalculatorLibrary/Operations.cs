using System;


namespace CalculatorLibrary
{
    public static class Operations
    {
        #region public methods

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
            foreach(double c in nums)
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
            double output =  a - b;
            foreach(double c in nums)
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
            return -a;
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
        #endregion
    }
}
