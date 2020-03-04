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
        /// A method that finds sum of two big numbers in string representation.
        /// </summary>
        /// <param name="firstNumber">First number.</param>
        /// <param name="secondNumber">Second number.</param>
        /// <returns>Sum.</returns>
        public static string GetSumOfTwoBigNumbers(string firstNumber, string secondNumber)
        {
            if (firstNumber == null || secondNumber == null)
            {
                throw new ArgumentNullException();
            }

            if ((!firstNumber.StartsWith("-") && !secondNumber.StartsWith("-")) || (firstNumber.StartsWith("-") && secondNumber.StartsWith("-")))
            {
                bool bothNegative = firstNumber.StartsWith("-") && secondNumber.StartsWith("-") ? true : false;

                if (bothNegative)
                {
                    firstNumber = firstNumber.Replace("-", string.Empty);
                    secondNumber = secondNumber.Replace("-", string.Empty);
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

                return bothNegative ? new string((result + "-").Reverse().ToArray()) : new string(result.Reverse().ToArray());
            }
            else
            {
                string posNum = string.Empty, negNum = string.Empty;
                if (firstNumber.StartsWith("-"))
                {
                    firstNumber = firstNumber.Replace("-", string.Empty);
                    posNum = secondNumber;
                    negNum = firstNumber;
                }
                else if (secondNumber.StartsWith("-"))
                {
                    secondNumber = secondNumber.Replace("-", string.Empty);
                    posNum = firstNumber;
                    negNum = secondNumber;
                }

                int maxLength = Math.Max(posNum.Length, negNum.Length);

                string result = string.Empty;
                if (posNum.Length > negNum.Length)
                {
                    negNum = negNum.PadLeft(maxLength, '0');
                    result = new string(FindAbsoluteDifference(posNum, negNum).ToArray()).TrimStart('0');
                }
                else if (posNum.Length < negNum.Length)
                {
                    posNum = posNum.PadLeft(maxLength, '0');

                    result = "-" + new string(FindAbsoluteDifference(posNum, negNum).ToArray()).TrimStart('0');
                }
                else
                {
                    result = IsSmaller(posNum, negNum) ? "-" + new string(FindAbsoluteDifference(posNum, negNum).ToArray()).TrimStart('0') : new string(FindAbsoluteDifference(posNum, negNum).ToArray()).TrimStart('0');
                }

                return result == string.Empty ? "0" : result;
            }
        }

        /// <summary>
        /// A function that comparises two very long numbers in string representation.
        /// </summary>
        /// <param name="firstNumber">First number as a string.</param>
        /// <param name="secondNumber">Second number as a string.</param>
        /// <returns>True if first number is smaller than second and false otherwise.</returns>
        private static bool IsSmaller(string firstNumber, string secondNumber)
        {
            if (firstNumber.Length < secondNumber.Length)
            {
                return true;
            }

            if (secondNumber.Length < firstNumber.Length)
            {
                return false;
            }

            for (int i = 0; i < firstNumber.Length; i++)
            {
                if (firstNumber[i] < secondNumber[i])
                {
                    return true;
                }
                else if (firstNumber[i] > secondNumber[i])
                {
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// A function that finds difference between two non-negative numbers.
        /// </summary>
        /// <param name="firstNumber">First number as a string.</param>
        /// <param name="secondNumber">SecondNumber as a string.</param>
        /// <returns>Difference as a string.</returns>
        private static string FindAbsoluteDifference(string firstNumber, string secondNumber)
        {
            if (IsSmaller(firstNumber, secondNumber))
            {
                string bubble = firstNumber;
                firstNumber = secondNumber;
                secondNumber = bubble;
            }

            char[] firstNumberChars = firstNumber.ToCharArray();
            Array.Reverse(firstNumberChars);
            firstNumber = new string(firstNumberChars);
            char[] secondNumberChars = secondNumber.ToCharArray();
            Array.Reverse(secondNumberChars);
            secondNumber = new string(secondNumberChars);
            int units, tens = 0;
            string result = string.Empty;

            for (int i = 0; i < secondNumber.Length; i++)
            {
                units = firstNumber[i] - '0' - (secondNumber[i] - '0') - tens;

                if (units < 0)
                {
                    units = units + 10;
                    tens = 1;
                }
                else
                {
                    tens = 0;
                }

                result += (char)(units + '0');
            }

            for (int i = secondNumber.Length; i < firstNumber.Length; i++)
            {
                units = firstNumber[i] - '0' - tens;

                if (units < 0)
                {
                    units = units + 10;
                    tens = 1;
                }
                else
                {
                    tens = 0;
                }

                result += (char)(units  + '0');
            }

            char[] resultNumberChars = result.ToCharArray();
            Array.Reverse(resultNumberChars);
            return new string(resultNumberChars);
        }
    }
}
