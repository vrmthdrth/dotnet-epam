namespace DoubleExtensionMethods
{
    /// <summary>
    /// A class containing extension methods for a double type.
    /// </summary>
    public static class DoubleExtension
    {
        /// <summary>
        /// A method that returns string representation of IEEE754 format of input double.
        /// </summary>
        /// <param name="number">Input double.</param>
        /// <returns>IEEE754 string.</returns>
        public static unsafe string ConvertToIEEE754(this double number)
        {
            string str = string.Empty;
            ulong i = *(ulong*)&number;
            for (int j = 63; j >= 0; j--)
            {
                str += (i >> j) & 1;
            }

            return str;
        }
    }
}
