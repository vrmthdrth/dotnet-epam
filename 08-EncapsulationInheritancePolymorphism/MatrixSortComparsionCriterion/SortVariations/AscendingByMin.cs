namespace MatrixSortComparisonCriterion
{
    /// <summary>
    /// A class that contains one of array rows sorting options(one of concrete strategies).
    /// </summary>
    public class AscendingByMin : ISort
    {
        /// <summary>
        /// A method of sorting matrix rows by ascending minimal elements of rows.
        /// </summary>
        /// <param name="matrix">Input array.</param>
        /// <returns>Sorted array.</returns>
        public Matrix SortMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.Values.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.Values.GetLength(0); j++)
                {
                    int previousMin = SortHelper.FindMinInRow(matrix.Values, j - 1),
                        currentMin = SortHelper.FindMinInRow(matrix.Values, j);

                    if (previousMin > currentMin)
                    {
                        SortHelper.SwapCurrentStringWithPrevious(matrix.Values, j);
                    }
                }
            }

            return matrix;
        }
    }
}
