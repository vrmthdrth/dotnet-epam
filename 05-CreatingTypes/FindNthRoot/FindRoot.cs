namespace NumberOperations
{
    using System;

    /// <summary>
    /// Class that contains methods to find number's roots.
    /// </summary>
    public class FindRoot
    {
        /// <summary>
        /// Function that realises Newton's method for finding the root of n-th degree of an input number with determined precision.
        /// </summary>
        /// <param name="number">Number.</param>
        /// <param name="degree">Root degree.</param>
        /// <param name="precision">Precision.</param>
        /// <returns>Result.</returns>
        public static double FindNthRoot(double number, int degree, double precision)
        {

            if (precision > 1 || precision < 0 || degree < 0 || (number <= 0 && degree % 2 == 0))
            {
                throw new ArgumentOutOfRangeException();
            }

            var x = number / degree;
            var x1 = (1 / (double)degree) * (((degree - 1) * x) + (number / Math.Pow(x, degree - 1)));

            while (Math.Abs(x - x1) > precision || Math.Abs(x - x1) != 0)
            {
                x = x1;
                x1 = (1 / (double)degree) * (((degree - 1) * x) + (number / Math.Pow(x, degree - 1)));
            }

            int count = 0;
            while (precision != 1)
            {
                precision *= 10;
                count++;
            }

            return Math.Round(x1, count);
        }
    }
}
