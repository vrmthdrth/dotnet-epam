using NUnit.Framework;
using System;

namespace GreatestCommonDivisorDelegates.Tests
{
    public class GCDSearchNUnitTests
    {
        GCDSearchMethodForArrayOfIntegers gcdDelegate = GCDSearchDelegates.EuclideanGCDOfArray;
        GCDSearchMethodForArrayOfIntegers gcdBinaryDelegate = GCDSearchDelegates.BinaryGCDOfArray;

        [TestCase(81, 99, 72, 108, -36, ExpectedResult = 9)]
        [TestCase(99, 358, 2, ExpectedResult = 1)]
        [TestCase(132, 36, -66, 18, ExpectedResult = 6)]
        [TestCase(15, 25, ExpectedResult = 5)]
        [TestCase(25, 50, ExpectedResult = 25)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        public int EuclideanGCDOfArray_Numbers_ReturnsGCD(params int[] numbers)
        {
            return gcdDelegate(numbers);
        }

        [TestCase(81, 99, 72, 108, -36, ExpectedResult = 9)]
        [TestCase(99, 358, 2, ExpectedResult = 1)]
        [TestCase(132, 36, -66, 18, ExpectedResult = 6)]
        [TestCase(15, 25, ExpectedResult = 5)]
        [TestCase(25, 50, ExpectedResult = 25)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        public int BinaryGCDOfArray_Numbers_ReturnsGCD(params int[] numbers)
        {   
            return gcdBinaryDelegate(numbers);
        }

        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { })]
        public void EuclideanGCDOfArray_Numbers_ArgumentOutOfRangeException(params int[] numbers)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => gcdDelegate(numbers));
        }

        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { })]
        public void BinaryGCDOfArray_Numbers_ArgumentOutOfRangeException(params int[] numbers)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => gcdBinaryDelegate(numbers));
        }

    }
}