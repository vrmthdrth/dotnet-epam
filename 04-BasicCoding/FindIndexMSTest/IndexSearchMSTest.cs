using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindIndexTask.MSTest
{
    [TestClass]
    public class IndexSearchMSTest
    {

        [TestMethod]
        public void FindIndex_inputArray_returnsMinusOne()
        {

            double[] inputArray = { };

            int expected = -1;

            int output = IndexSearch.FindIndex(inputArray);

            Assert.AreEqual(expected, output);

        }

        [TestMethod]
        public void FindIndex_inputArray_returnsIndex1()
        {

            double[] inputArray = { 1, 2, 1 };

            int expected = 1;

            int output = IndexSearch.FindIndex(inputArray);

            Assert.AreEqual(expected, output);

        }

        [TestMethod]
        public void FindIndex_inputArray_returnsIndex54()
        {

            double[] inputArray = { 49.2, 35.36, 38.94, 45.37, 44.16, 35.41, 21.61,
                27.89, 28.58, 34.82, 28.17, 9.27, 5.41, 37.19, 30.55, 29.23, 37.3,
                15.71, 21.33, 13.25, 18.05, 13.61, 30.12, 23.14, 10.89, 26.24,
                10.04, 15.75, 38.75, 4.01, 15.17, 23.89, 5.22, 43.34, 37.06, 3.04,
                47.04, 40.42, 31, 15.31, 10.22, 40.34, 36.42, 4.05, 28.47, 29.61,
                16.67, 5.99, 28.92, 43.35, 7.33, 46.36, 14.77, 4.66, 3.26, 25.13,
                32.78, 6.94, 22.42, 18.88, 4.15, 38.17, 21.95, 33.69, 8.03, 16.45,
                19.66, 19.92, 22, 45.47, 8.33, 43.63, 40.46, 32.27, 43.01, 37.07,
                39.08, 42.76, 32.63, 35.82, 38.75, 17.93, 7.82, 29.3, 33.04, 33.17,
                37.29, 26.2, 43.23, 31.5, 11.73, 42.44, 6.11, 2.81, 1.43, 21.72,
                38.86, 16.75, 26.05, 36.74, 18.63, 20, 8.48, 45.89, 38.02, 33.4, 0.01 };

            int expected = 54;

            int output = IndexSearch.FindIndex(inputArray);

            Assert.AreEqual(expected, output);

        }
    }
}
