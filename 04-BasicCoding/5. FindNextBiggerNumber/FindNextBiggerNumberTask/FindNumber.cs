namespace FindNextBiggerNumberTask
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Includes methods to find numbers in arrays.
    /// </summary>
    public class FindNumber
    {
        /// <summary>
        /// Method to find next bigger number that consists of digits of input number.
        /// </summary>
        /// <param name="number">Input number.</param>
        /// <returns>Next bigger number.</returns>
        public static int FindNextBiggerNumber(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int result = 0, position = -1;
            int[] digits = new int[number.ToString().Length];

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }

            for (int i = digits.Length - 1; i > 0; i--)
            {
                if (digits[i - 1] < digits[i])
                {
                    int bubble = digits[i - 1];
                    digits[i - 1] = digits[i];
                    digits[i] = bubble;
                    position = i;
                    break;
                }
            }

            if (position != -1)
            {
                for (int i = position; i < digits.Length; i++)
                {
                    for (int j = position; j < digits.Length - 1; j++)
                    {
                        if (digits[j] > digits[j + 1])
                        {
                            int bubble = digits[j];
                            digits[j] = digits[j + 1];
                            digits[j + 1] = bubble;
                        }
                    }
                }

                int power = 1;
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    result += digits[i] * power;
                    power *= 10;
                }
            }
            else
            {
                result = position;
            }

            return result;
        }
    }
}
