namespace CustomerRepresentation
{
    using System.Globalization;

    /// <summary>
    /// A class containing methods which are helping to format Customer class objects string representation.
    /// </summary>
    public class FormatHelper
    {
        /// <summary>
        /// A method of formatting Revenue for Customer class.
        /// </summary>
        /// <returns>Format info.</returns>
        public static NumberFormatInfo RevenueFormat()
        {
            NumberFormatInfo formatInfo = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            formatInfo.CurrencyDecimalSeparator = ".";
            formatInfo.CurrencyDecimalDigits = 2;
            formatInfo.CurrencyPositivePattern = 0;
            formatInfo.CurrencyNegativePattern = 0;
            formatInfo.CurrencySymbol = string.Empty;
            formatInfo.CurrencyGroupSeparator = ",";
            return formatInfo;
        }
    }
}
