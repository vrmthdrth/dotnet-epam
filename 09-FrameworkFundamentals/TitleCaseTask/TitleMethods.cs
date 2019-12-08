namespace TitleCaseTask
{
    using System;
    using System.Threading;

    /// <summary>
    /// A class containing methods to work with titles.
    /// </summary>
    public class TitleMethods
    {

        /// <summary>
        /// A method that converts a string into title case.
        /// </summary>
        /// <param name="inputString">The original string to be converted.</param>
        /// <param name="minorWordsString">Minor words.</param>
        /// <returns>Converted string.</returns>
        public static string TitleCase(string inputString, string minorWordsString = "")
        {
            string resultString = string.Empty;

            inputString = inputString.Trim();

            for (int i = 0; i < inputString.Length; i++)
            {
                char currentSymbol = Convert.ToChar(inputString.Substring(i, 1));

                if (i == 0 && inputString.Substring(i, 1) != " ")
                {
                    resultString += char.ToUpper(currentSymbol);
                }
                else if (inputString.Substring(i - 1, 1) != " ")
                {
                    resultString += char.ToLower(currentSymbol);
                }
                else
                {
                    resultString += char.ToUpper(currentSymbol);
                }
            }

            string[] exceptionsArray = minorWordsString.Split(' ');

            string[] result = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(resultString).Split(' ');

            for (int i = 1; i < result.Length; i++)
            {
                for (int j = 0; j < exceptionsArray.Length; j++)
                {
                    if (result[i] == Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(exceptionsArray[j]))
                    {
                        result[i] = result[i].ToLower();
                    }
                }
            }

            return string.Join(" ", result);
        }
    }
}
