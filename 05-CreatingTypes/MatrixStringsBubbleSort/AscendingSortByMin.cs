namespace MatrixStringsBubbleSort
{
    /// <summary>
    /// A class that contains one of array rows sorting options(one of concrete strategies).
    /// </summary>
    public class AscendingSortByMin : ISortStrategy
    {
        /// <summary>
        /// A method of sorting matrix rows by ascending minimal elements of rows.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>Sorted array.</returns>
        public int[,] SortArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(0); j++)
                {
                    int previousMin = SortHelper.FindMinInRow(array, j - 1),
                        currentMin = SortHelper.FindMinInRow(array, j);

                    if (previousMin > currentMin)
                    {
                        SortHelper.SwapCurrentStringWithPrevious(array, j);
                    }
                }
            }

            return array;
        }
    }
}
