using System;
using NUnit.Framework;

namespace InsertNumberTask.NUnitTests
{
    [TestFixture]
    public class NumberInsertionNUnitTests
    {
        [TestCase(16, 15, 0, 0)]
        [TestCase(15, 16, 0, 0)]
        [TestCase(7, 8, 0, 0)]
        [TestCase(8, 7, 0, 0)]
        [TestCase(16, 16, 0, 0)]
        [TestCase(7, 7, 0, 0)]
        public void InsterNumberTest_InputNumbersAreMoreThan15OrLessThan8_ThrowsException(sbyte numberSource, sbyte numberIn, int i, int j)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NumberInsertion.InsertNumber(numberSource, numberIn, i, j));
        }

        [TestCase(10, 10, 1, 0)]
        public void InsterNumberTest_JPositionLessThanIPosition_ThrowsException(sbyte numberSource, sbyte numberIn, int i, int j)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NumberInsertion.InsertNumber(numberSource, numberIn, i, j));
        }

        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        public int InsertNumberTest(sbyte numberSource, sbyte numberIn, int i, int j)
        {
            return NumberInsertion.InsertNumber(numberSource, numberIn, i, j);
        }
    }
}