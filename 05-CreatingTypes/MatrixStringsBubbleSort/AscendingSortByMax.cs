namespace MatrixStringsBubbleSort
{
    /// <summary>
    /// A class that contains one of array rows sorting options(one of concrete strategies).
    /// </summary>
    public class AscendingSortByMax : ISortStrategy
    {
        /// <summary>
        /// A method of sorting matrix rows by ascending maximal elements of rows.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>Sorted array.</returns>
        public int[,] SortArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(0); j++)
                {
                    int previousMax = SortHelper.FindMaxInRow(array, j - 1),
                        currentMax = SortHelper.FindMaxInRow(array, j);

                    if (previousMax > currentMax)
                    {
                        SortHelper.SwapCurrentStringWithPrevious(array, j);
                    }
                }
            }

            return array;
        }
    }
}
