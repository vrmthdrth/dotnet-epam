namespace ReverseWordsTask
{
    /// <summary>
    /// A class containing a method to reverse string words.
    /// </summary>
    public class StringsReversionMethods
    {
        /// <summary>
        /// Method that reverses words order in string.
        /// </summary>
        /// <param name="str">String.</param>
        /// <returns>String with reversed word order.</returns>
        public static string ReverseString(string str)
        {
            string[] strArray = str.Split(' ');
            string[] resultStrArray = new string[strArray.Length];

            for (int i = strArray.Length - 1; i >= 0; i--)
            {
                resultStrArray[strArray.Length - 1 - i] = strArray[i];
            }

            return string.Join(" ", resultStrArray);
        }
    }
}
