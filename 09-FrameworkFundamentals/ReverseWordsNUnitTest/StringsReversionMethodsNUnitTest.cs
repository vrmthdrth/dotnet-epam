namespace ReverseWordsTask.Tests
{
    using NUnit.Framework;

    public class StringsReversionMethodsNUnitTest
    {
        [TestCase("The greatest victory is that which requires no battle", ExpectedResult = "battle no requires which that is victory greatest The")]
        [TestCase("Appear weak when you are strong and strong when you are weak", ExpectedResult = "weak are you when strong and strong are you when weak Appear")]
        [TestCase("The supreme art of war is to subdue the enemy without fighting", ExpectedResult = "fighting without enemy the subdue to is war of art supreme The")]
        public string ReverseString_String_ReversedString(string str)
        {
            return StringsReversionMethods.ReverseString(str);
        }
    }
}