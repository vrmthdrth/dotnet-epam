namespace TitleCaseTask.Tests
{
    using NUnit.Framework;

    public class TitleMethodsNUnitTest
    {
        [TestCase("a clash of KINGS", "a an the of", ExpectedResult = "A Clash of Kings")]
        [TestCase("THE WIND IN THE WILLOWS", "The In", ExpectedResult = "The Wind in the Willows")]
        [TestCase("the quick brown fox", ExpectedResult = "The Quick Brown Fox")]
        public string TitleCase_String_MinorWords_FormattedString(string testInputString, string testMinorWords = "")
        {
            return TitleMethods.TitleCase(testInputString, testMinorWords);
        }
    }
}