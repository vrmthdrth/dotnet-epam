using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilterDigitTask.MSTest
{
    [TestClass]
    public class FilterMSTest
    {
        [TestMethod]
        public void FilterDigit_inputArray_returnsOutputArray1()
        {

            int[] inputArray = { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };

            int[] outputArray = Filter.FilterDigit(inputArray, 7);

            CollectionAssert.AreEqual(new int[] { 7, 7, 70, 17 }, outputArray);

        }

        [TestMethod]
        public void FilterDigit_inputArray_returnsOutputArray2()
        {

            int[] inputArray = { 4, 103, 2, 0, -14, 5, -30, 68, 69, 79, 15, 55 };

            int[] outputArray = Filter.FilterDigit(inputArray, 0);

            CollectionAssert.AreEqual(new int[] { 103, 0, -30 }, outputArray);

        }

        [TestMethod]
        public void FilterDigit_inputArray_returnsOutputArray3()
        {

            int[] inputArray = { 1 };

            int[] outputArray = Filter.FilterDigit(inputArray, 0);

            CollectionAssert.AreEqual(new int[] { }, outputArray);

        }
    }
}
