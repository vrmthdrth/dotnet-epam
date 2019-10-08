namespace ConcatenateStringsTask
{
    using System;

    /// <summary>
    /// Contains methods to concatenate strings.
    /// </summary>
    public class Concatenate
    {
        /// <summary>
        /// Method that concatenates two latin strings and removes repeating letters(symbols).
        /// </summary>
        /// <param name="firstString">First string.</param>
        /// <param name="secondString">Second string.</param>
        /// <returns>New string.</returns>
        public static string ConcatenateStrings(string firstString, string secondString)
        {
            string newString = firstString + secondString;

            foreach (char ch in newString)
            {
                if (!((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')))
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            int i = 0;
            while (true)
            {
                var currentChar = newString[i].ToString();
                newString = newString.Replace(currentChar, "");
                newString = newString.Insert(i, currentChar);
                i++;
                if (newString.Length - 1 < i)
                {
                    break;
                }
            }

            return newString;
        }
    }
}
