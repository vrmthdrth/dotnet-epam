namespace UniqueInOrderTask.Tests
{
    using NUnit.Framework;
    using System.Collections.Generic;

    public class OrderMethodsNUnitTest
    {
        [TestCase("AAAABBBCCDAABBB", "ABCDAB")]
        [TestCase("ABBCcAD", "ABCcAD")]
        [TestCase("12233", "123")]
        public void UniqueInOrder_SequenceAsAString_FilteredSequence(string testString, string expectedString)
        {
            CollectionAssert.AreEqual(expectedString, OrderMethods.UniqueInOrder(testString));
        }

        [TestCase]
        public void UniqueInOrder_SequenceAsAList_FilteredSequence()
        {
            List<double> testList = new List<double> { 1.1, 2.2, 2.2, 3.3 };
            List<double> expectedList = new List<double> { 1.1, 2.2, 3.3 };
            CollectionAssert.AreEqual(expectedList, OrderMethods.UniqueInOrder(testList));
        }

    }
}