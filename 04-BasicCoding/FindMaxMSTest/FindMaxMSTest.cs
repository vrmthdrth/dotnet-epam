using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMaxTask.MSTest
{
    [TestClass]
    public class FindMaxMSTest
    {

        [TestMethod]
        public void FindMax_inputArray_leftElem_rightElem_returnsMax3()
        {

            int[] inputArray = { 1, 2, 3 };

            int expectedMax = 3;

            int outputMax = FindMax.RecursiveMaxSearch(inputArray, 0, inputArray.Length - 1);

            Assert.AreEqual(expectedMax, outputMax);

        }

        [TestMethod]
        public void FindMax_inputArray_leftElem_rightElem_returnsMax0()
        {

            int[] inputArray = { 0, 0, 0, 0 };

            int expectedMax = 0;

            int outputMax = FindMax.RecursiveMaxSearch(inputArray, 0, inputArray.Length - 1);

            Assert.AreEqual(expectedMax, outputMax);

        }

        [TestMethod]
        public void FindMax_inputArray_leftElem_rightElem_returnsMax101()
        {

            int[] inputArray = { -49, 5, 1, 0, 92, -544, 101, 22, -1 };

            int expectedMax = 101;

            int outputMax = FindMax.RecursiveMaxSearch(inputArray, 0, inputArray.Length - 1);

            Assert.AreEqual(expectedMax, outputMax);

        }

    }
}
