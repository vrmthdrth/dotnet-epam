using NUnit.Framework;
using System;

namespace ConcatenateStringsTask.NUnitTests
{
    [TestFixture]
    public class ConcatenateNUnitTests
    {
        [TestCase("строка", "string")]
        [TestCase("string", "str%ng")]
        [TestCase("01234", "56789")]
        public void ConcatenateStringsTest_InputStringsAreContainNonLatinLettersOrOtherSymbolsOrEmpty_ThrowsException(string firstString, string secondString)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Concatenate.ConcatenateStrings(firstString, secondString));
        }

        [TestCase("string", "string", ExpectedResult = "string")]
        [TestCase("abcd", "abcdABCD", ExpectedResult = "abcdABCD")]
        [TestCase("abcd", "efg", ExpectedResult = "abcdefg")]
        [TestCase("abbb", "cbCdd", ExpectedResult = "abcCd")]
        [TestCase("EEFG", "", ExpectedResult = "EFG")]
        [TestCase("", "hiiggk", ExpectedResult = "higk")]
        public string ConcatenateStringsTest(string firstString, string secondString)
        {
            return Concatenate.ConcatenateStrings(firstString, secondString);
        }
    }
}