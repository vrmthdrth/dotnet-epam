using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixStringsBubbleSort.MSTest
{
    [TestClass]
    public class MatrixStringsBubbleSortMSTest
    {

        int[,] inputArray =
            {
                { 4, 19, -5},
                { 7, 1, 0},
                { 16, 5, 13 },
                { 9, 6, 2 }
            };

        [TestMethod]
        public void SortArray_AscendingSortBySums_ReturnsOutputArray()
        {
            var sortContext = new SortContext();

            sortContext.SetSortStrategy(new AscendingSortBySums());

            int[,] expectedArray =
            {
                { 7, 1, 0},
                { 9, 6, 2 },
                { 4, 19, -5},
                { 16, 5, 13 }
            };

            int[,] outputArray = sortContext.ExecuteSort(inputArray);

            CollectionAssert.AreEqual(expectedArray, outputArray);

        }

        [TestMethod]
        public void SortArray_DescendingSortBySums_ReturnsOutputArray()
        {
            var sortContext = new SortContext();

            sortContext.SetSortStrategy(new DescendingSortBySums());

            int[,] expectedArray =
            {
                { 16, 5, 13 },
                { 4, 19, -5},
                { 9, 6, 2 },
                { 7, 1, 0}
            };

            int[,] outputArray = sortContext.ExecuteSort(inputArray);

            CollectionAssert.AreEqual(expectedArray, outputArray);

        }

        [TestMethod]
        public void SortArray_AscendingSortByMax_ReturnsOutputArray()
        {
            var sortContext = new SortContext();

            sortContext.SetSortStrategy(new AscendingSortByMax());

            int[,] expectedArray =
            {
                { 7, 1, 0},
                { 9, 6, 2 },
                { 16, 5, 13 },
                { 4, 19, -5}
            };

            int[,] outputArray = sortContext.ExecuteSort(inputArray);

            CollectionAssert.AreEqual(expectedArray, outputArray);

        }

        [TestMethod]
        public void SortArray_DescendingSortByMax_ReturnsOutputArray()
        {
            var sortContext = new SortContext();

            sortContext.SetSortStrategy(new DescendingSortByMax());

            int[,] expectedArray =
            {
                { 4, 19, -5},
                { 16, 5, 13 },
                { 9, 6, 2 },
                { 7, 1, 0}
            };

            int[,] outputArray = sortContext.ExecuteSort(inputArray);

            CollectionAssert.AreEqual(expectedArray, outputArray);

        }

        [TestMethod]
        public void SortArray_AscendingSortByMin_ReturnsOutputArray()
        {
            var sortContext = new SortContext();

            sortContext.SetSortStrategy(new AscendingSortByMin());

            int[,] expectedArray =
            {
                { 4, 19, -5},
                { 7, 1, 0},
                { 9, 6, 2 },
                { 16, 5, 13 }
            };

            int[,] outputArray = sortContext.ExecuteSort(inputArray);

            CollectionAssert.AreEqual(expectedArray, outputArray);

        }

        [TestMethod]
        public void SortArray_DescendingSortByMin_ReturnsOutputArray()
        {
            var sortContext = new SortContext();

            sortContext.SetSortStrategy(new DescendingSortByMin());

            int[,] expectedArray =
            {
                { 16, 5, 13 },
                { 9, 6, 2 },
                { 7, 1, 0},
                { 4, 19, -5}
            };

            int[,] outputArray = sortContext.ExecuteSort(inputArray);

            CollectionAssert.AreEqual(expectedArray, outputArray);

        }

    }
}
