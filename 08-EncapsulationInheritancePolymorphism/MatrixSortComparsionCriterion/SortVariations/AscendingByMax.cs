namespace MatrixSortComparisonCriterion
{
    /// <summary>
    /// A class that contains one of array rows sorting options(one of concrete strategies).
    /// </summary>
    public class AscendingByMax : ISort
    {
        /// <summary>
        /// A method of sorting matrix rows by ascending maximal elements of rows.
        /// </summary>
        /// <param name="matrix">Input array.</param>
        /// <returns>Sorted array.</returns>
        public Matrix SortMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.Values.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.Values.GetLength(0); j++)
                {
                    int previousMax = SortHelper.FindMaxInRow(matrix.Values, j - 1),
                        currentMax = SortHelper.FindMaxInRow(matrix.Values, j);

                    if (previousMax > currentMax)
                    {
                        SortHelper.SwapCurrentStringWithPrevious(matrix.Values, j);
                    }
                }
            }

            return matrix;
        }
    }
}
