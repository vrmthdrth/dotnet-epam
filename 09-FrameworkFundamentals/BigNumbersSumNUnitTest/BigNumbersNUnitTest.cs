namespace BigNumbersSumTask.Tests
{
    using NUnit.Framework;

    public class BigNumbersNUnitTest
    {
        [TestCase("1", "9999999999999999999999999999999999999999", ExpectedResult = "10000000000000000000000000000000000000000")]
        [TestCase("9999999999999999999999999999999999999999", "1", ExpectedResult = "10000000000000000000000000000000000000000")]
        [TestCase("9999999999999999999999999999999999999999", "9999999999999999999999999999999999999999", ExpectedResult = "19999999999999999999999999999999999999998")]    
        [TestCase("2435679057081050", "7490511111789", ExpectedResult = "2443169568192839")]
        [TestCase("3333311111111111", "44422222221111", ExpectedResult = "3377733333332222")]
        [TestCase("7777555511111111", "3332222221111", ExpectedResult = "7780887733332222")]

        [TestCase("-10000000000000000000000000000000000000000", "1", ExpectedResult = "-9999999999999999999999999999999999999999")]
        [TestCase("-1", "10000000000000000000000000000000000000000", ExpectedResult = "9999999999999999999999999999999999999999")]
        [TestCase("-1", "-9999999999999999999999999999999999999999", ExpectedResult = "-10000000000000000000000000000000000000000")]
        [TestCase("-1", "1", ExpectedResult = "0")]
        [TestCase("-1", "1", ExpectedResult = "0")]
        [TestCase("1", "-1", ExpectedResult = "0")]
        [TestCase("-1", "-1", ExpectedResult = "-2")]
        public string GetSumOfTwoBigNumbers_FirstNumber_SecondNumber_Sum(string firstNumber, string secondNumber)
        {
            return BigNumbers.GetSumOfTwoBigNumbers(firstNumber, secondNumber);
        }
    }
}