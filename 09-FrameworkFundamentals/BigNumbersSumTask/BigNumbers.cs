namespace BigNumbersSumTask
{
    using System;
    using System.Linq;

    /// <summary>
    /// A class containing methods to work with big numbers in string representation.
    /// </summary>
    public class BigNumbers
    {
        /// <summary>
        /// A method that sums two big numbers.
        /// </summary>
        /// <param name="firstNumber">First number.</param>
        /// <param name="secondNumber">Second number.</param>
        /// <returns>Sum of numbers as a string.</returns>
        public static string GetSumOfTwoBigNumbers(string firstNumber, string secondNumber)
        {
            if (firstNumber == null || secondNumber == null)
            {
                throw new ArgumentNullException();
            }

            int maxLength = Math.Max(firstNumber.Length, secondNumber.Length);

            if (firstNumber.Length > secondNumber.Length)
            {
                secondNumber = secondNumber.PadLeft(maxLength, '0');
            }
            else if (firstNumber.Length < secondNumber.Length)
            {
                firstNumber = firstNumber.PadLeft(maxLength, '0');
            }

            string result = string.Empty;
            int units = 0, tens = 0;
            for (int i = Math.Max(firstNumber.Length, secondNumber.Length) - 1; i >= 0; i--)
            {
                units = (tens + (int)char.GetNumericValue(firstNumber[i]) + (int)char.GetNumericValue(secondNumber[i])) % 10;
                tens = (tens + (int)char.GetNumericValue(firstNumber[i]) + (int)char.GetNumericValue(secondNumber[i])) / 10;
                result += units.ToString();
            }

            if (tens != 0)
            {
                result += "1";
            }

            return new string(result.Reverse().ToArray());
        }
    }
}
