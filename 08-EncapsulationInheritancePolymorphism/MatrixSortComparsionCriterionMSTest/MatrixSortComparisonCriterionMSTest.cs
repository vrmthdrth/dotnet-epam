namespace MatrixSortComparisonCriterion.MSTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MatrixStringsComparisonCriterionMSTest
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
            int[,] expectedArray =
            {
                { 7, 1, 0},
                { 9, 6, 2 },
                { 4, 19, -5},
                { 16, 5, 13 }
            };
            Matrix expectedMatrix = new Matrix(expectedArray);
            Matrix outputMatrix = inputMatrix.Sort(Matrix.SortCriterion.AscBySum);
            Assert.IsTrue(outputMatrix.Equals(expectedMatrix));
        }

        [TestMethod]
        public void SortArray_DescendingSortBySum_ReturnsOutputArray()
        {
            int[,] expectedArray =
            {
                { 16, 5, 13 },
                { 4, 19, -5},
                { 9, 6, 2 },
                { 7, 1, 0}
            };
            Matrix expectedMatrix = new Matrix(expectedArray);
            Matrix outputMatrix = inputMatrix.Sort(Matrix.SortCriterion.DescBySum);
            Assert.IsTrue(outputMatrix.Equals(expectedMatrix));
        }

        [TestMethod]
        public void SortArray_AscendingSortByMax_ReturnsOutputArray()
        {
            int[,] expectedArray =
            {
                { 7, 1, 0},
                { 9, 6, 2 },
                { 16, 5, 13 },
                { 4, 19, -5}
            };
            Matrix expectedMatrix = new Matrix(expectedArray);
            Matrix outputMatrix = inputMatrix.Sort(Matrix.SortCriterion.AscByMax);
            Assert.IsTrue(outputMatrix.Equals(expectedMatrix));
        }

        [TestMethod]
        public void SortArray_DescendingSortByMax_ReturnsOutputArray()
        {
            int[,] expectedArray =
            {
                { 4, 19, -5},
                { 16, 5, 13 },
                { 9, 6, 2 },
                { 7, 1, 0}
            };
            Matrix expectedMatrix = new Matrix(expectedArray);
            Matrix outputMatrix = inputMatrix.Sort(Matrix.SortCriterion.DescByMax);
            Assert.IsTrue(outputMatrix.Equals(expectedMatrix));
        }

        [TestMethod]
        public void SortArray_AscendingSortByMin_ReturnsOutputArray()
        {
            int[,] expectedArray =
            {
                { 4, 19, -5},
                { 7, 1, 0},
                { 9, 6, 2 },
                { 16, 5, 13 }
            };
            Matrix expectedMatrix = new Matrix(expectedArray);
            Matrix outputMatrix = inputMatrix.Sort(Matrix.SortCriterion.AscByMin);
            Assert.IsTrue(outputMatrix.Equals(expectedMatrix));
        }

        [TestMethod]
        public void SortArray_DescendingSortByMin_ReturnsOutputArray()
        {
            int[,] expectedArray =
            {
                { 16, 5, 13 },
                { 9, 6, 2 },
                { 7, 1, 0},
                { 4, 19, -5}
            };
            Matrix expectedMatrix = new Matrix(expectedArray);
            Matrix outputMatrix = inputMatrix.Sort(Matrix.SortCriterion.DescByMin);
            Assert.IsTrue(outputMatrix.Equals(expectedMatrix));
        }
    }
}
