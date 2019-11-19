namespace MatrixSortComparisonCriterion
{
    /// <summary>
    /// A class that contains one of array rows sorting options(one of concrete strategies).
    /// </summary>
    public class DescendingBySum : ISort
    {
        /// <summary>
        /// A method of sorting matrix rows by descending sums of row elements.
        /// </summary>
        /// <param name="matrix">Input array.</param>
        /// <returns>Sorted array.</returns>
        public Matrix SortMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.Values.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.Values.GetLength(0); j++)
                {
                    int previousSum = SortHelper.FindSumInRow(matrix.Values, j - 1),
                        currentSum = SortHelper.FindSumInRow(matrix.Values, j);

                    if (previousSum < currentSum)
                    {
                        SortHelper.SwapCurrentStringWithPrevious(matrix.Values, j);
                    }
                }
            }

            return matrix;
        }
    }
}
