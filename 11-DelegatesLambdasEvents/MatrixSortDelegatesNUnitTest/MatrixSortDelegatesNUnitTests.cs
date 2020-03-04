namespace MatrixSortDelegatesTask.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MatrixSortDeleMSTest
    {
        static int[,] inputArray =
        {
             { 4, 19, -5},
             { 7, 1, 0},
             { 16, 5, 13 },
             { 9, 6, 2 }
         };

        static Matrix inputMatrix = new Matrix(inputArray);

        [TestMethod]
        public void SortArray_AscendingSortBySum_ReturnsOutputArray()
        {
            SortMatrixDelegate sortMatrix = SortMethods.AscendingBySum;
            int[,] expectedArray =
            {
                { 7, 1, 0},
                { 9, 6, 2 },
                { 4, 19, -5},
                { 16, 5, 13 }
            };
            Matrix expectedMatrix = new Matrix(expectedArray);
            Matrix outputMatrix = sortMatrix(inputMatrix);
            Assert.IsTrue(outputMatrix.Equals(expectedMatrix));
        }

        [TestMethod]
        public void SortArray_DescendingSortBySum_ReturnsOutputArray()
        {
            SortMatrixDelegate sortMatrix = SortMethods.DescendingBySum;
            int[,] expectedArray =
            {
                { 16, 5, 13 },
                { 4, 19, -5},
                { 9, 6, 2 },
                { 7, 1, 0}
            };
            Matrix expectedMatrix = new Matrix(expectedArray);
            Matrix outputMatrix = sortMatrix(inputMatrix);
            Assert.IsTrue(outputMatrix.Equals(expectedMatrix));
        }

        [TestMethod]
        public void SortArray_AscendingSortByMax_ReturnsOutputArray()
        {
            SortMatrixDelegate sortMatrix = SortMethods.AscendingByMax;
            int[,] expectedArray =
            {
                { 7, 1, 0},
                { 9, 6, 2 },
                { 16, 5, 13 },
                { 4, 19, -5}
            };
            Matrix expectedMatrix = new Matrix(expectedArray);
            Matrix outputMatrix = sortMatrix(inputMatrix);
            Assert.IsTrue(outputMatrix.Equals(expectedMatrix));
        }

        [TestMethod]
        public void SortArray_DescendingSortByMax_ReturnsOutputArray()
        {
            SortMatrixDelegate sortMatrix = SortMethods.DescendingByMax;
            int[,] expectedArray =
            {
                { 4, 19, -5},
                { 16, 5, 13 },
                { 9, 6, 2 },
                { 7, 1, 0}
            };
            Matrix expectedMatrix = new Matrix(expectedArray);
            Matrix outputMatrix = sortMatrix(inputMatrix);
            Assert.IsTrue(outputMatrix.Equals(expectedMatrix));
        }

        [TestMethod]
        public void SortArray_AscendingSortByMin_ReturnsOutputArray()
        {
            SortMatrixDelegate sortMatrix = SortMethods.AscendingByMin;
            int[,] expectedArray =
            {
                { 4, 19, -5},
                { 7, 1, 0},
                { 9, 6, 2 },
                { 16, 5, 13 }
            };
            Matrix expectedMatrix = new Matrix(expectedArray);
            Matrix outputMatrix = sortMatrix(inputMatrix);
            Assert.IsTrue(outputMatrix.Equals(expectedMatrix));
        }

        [TestMethod]
        public void SortArray_DescendingSortByMin_ReturnsOutputArray()
        {
            SortMatrixDelegate sortMatrix = SortMethods.DescendingByMin;
            int[,] expectedArray =
            {
                { 16, 5, 13 },
                { 9, 6, 2 },
                { 7, 1, 0},
                { 4, 19, -5}
            };
            Matrix expectedMatrix = new Matrix(expectedArray);
            Matrix outputMatrix = sortMatrix(inputMatrix);
            Assert.IsTrue(outputMatrix.Equals(expectedMatrix));
        }
    }
}
