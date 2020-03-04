namespace GreatestCommonDivisorDelegates
{
    using System;
    using System.Diagnostics;
  
    /// <summary>
    /// Delegate for GCD methods with two parameters only.
    /// </summary>
    /// <param name="first">First number.</param>
    /// <param name="second">Second number.</param>
    /// <returns>GCD.</returns>
    public delegate int GCDSearchMethodForTwoNumbers(int first, int second);

    /// <summary>
    /// Delegate for GCD methods with array or many parameters as arguments.
    /// </summary>
    /// <param name="numbers">Input numbers.</param>
    /// <returns>GCD.</returns>
    public delegate int GCDSearchMethodForArrayOfIntegers(params int[] numbers);

    /// <summary>
    /// Delegate for GCD methods with array or many parameters as arguments.
    /// Provides an additional opportunity to return the runtime.
    /// </summary>
    /// <param name="time">Runtime duration.</param>
    /// <param name="numbers">Input numbers.</param>
    /// <returns>GCD.</returns>
    public delegate int GCDSearchMethodForArrayOfIntegersReturnTime(out double time, params int[] numbers);

    /// <summary>
    /// A class containing methods for finding greatest common divisor.
    /// </summary>
    public static class GCDSearchDelegates
    {
        /// <summary>
        /// Method describing Euclidean algorithm for finding GCD of two numbers.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>Result.</returns>
        public static int EuclideanGCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 && b != 0)
            {
                return b;
            }

            if (b == 0 && a != 0)
            {
                return a;
            }

            if (b == 0 && a == 0)
            {
                return 0;
            }

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }

            return a;
        }

        /// <summary>
        /// Method that uses Euclidean algorithm to find GCD of two or more integers.
        /// </summary>
        /// <param name="numbers">Input numbers.</param>
        /// <returns>Result.</returns>
        public static int EuclideanGCDOfArray(params int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentOutOfRangeException();
            }

            int result = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                result = EuclideanGCD(result, numbers[i + 1]);
            }

            return result;
        }

        /// <summary>
        /// Method describing Stein's binary algorithm for finding GCD of two numbers.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>Result.</returns>
        public static int BinaryGCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == b)
            {
                return a;
            }

            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            if ((~a & 1) != 0)
            {
                if ((b & 1) != 0)
                {
                    return BinaryGCD(a >> 1, b);
                }
                else
                {
                    return BinaryGCD(a >> 1, b >> 1) << 1;
                }
            }

            if ((~b & 1) != 0)
            {
                return BinaryGCD(a, b >> 1);
            }

            if (a > b)
            {
                return BinaryGCD((a - b) >> 1, b);
            }

            return BinaryGCD((b - a) >> 1, a);
        }

        /// <summary>
        /// Method that uses Stein's binary algorithm to find GCD of two or more integers.
        /// </summary>
        /// <param name="numbers">Input numbers.</param>
        /// <returns>Result.</returns>
        public static int BinaryGCDOfArray(params int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentOutOfRangeException();
            }

            int result = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                result = BinaryGCD(result, numbers[i + 1]);
            }

            return result;
        }

        /// <summary>
        /// Method that uses Euclidean algorithm to find GCD of two or more integers and returns elapsed time in milliseconds.
        /// </summary>
        /// <param name="time">Output parameter of elapsed time.</param>
        /// <param name="numbers">Input numbers.</param>
        /// <returns>Result and elapsed time.</returns>
        public static int EuclideanGCDOfArray(out double time, params int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentOutOfRangeException();
            }

            Stopwatch watch = new Stopwatch();
            watch.Start();

            int result = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                result = EuclideanGCD(result, numbers[i + 1]);
            }

            watch.Stop();
            time = watch.Elapsed.TotalMilliseconds;
            return result;
        }

        /// <summary>
        /// Method that uses Stein's binary algorithm to find GCD of two or more integers and returns elapsed time in milliseconds.
        /// </summary>
        /// <param name="time">Output parameter of elapsed time.</param>
        /// <param name="numbers">Input numbers.</param>
        /// <returns>Result and elapsed time.</returns>
        public static int BinaryGCDOfArray(out double time, params int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentOutOfRangeException();
            }

            Stopwatch watch = new Stopwatch();
            watch.Start();

            int result = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                result = BinaryGCD(result, numbers[i + 1]);
            }

            watch.Stop();
            time = watch.Elapsed.TotalMilliseconds;
            return result;
        }
    }
}
