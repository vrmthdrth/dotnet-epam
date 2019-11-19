namespace MatrixSortComparisonCriterion
{
    /// <summary>
    /// Interface containing a method which is implemented in classes of strategies.
    /// </summary>
    public interface ISort
    {
        /// <summary>
        /// A method of sorting.
        /// </summary>
        /// <param name="matrix">Input array.</param>
        /// <returns>Sorted array.</returns>
        Matrix SortMatrix(Matrix matrix);
    }
}
