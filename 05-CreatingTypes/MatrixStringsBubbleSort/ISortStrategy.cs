namespace MatrixStringsBubbleSort
{
    /// <summary>
    /// Interface containing a method which is described in classes of strategies.
    /// </summary>
    public interface ISortStrategy
    {
        /// <summary>
        /// A method of sorting.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>Sorted array.</returns>
        int[,] SortArray(int[,] array);
    }
}
