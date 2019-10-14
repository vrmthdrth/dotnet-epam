namespace MatrixStringsBubbleSort
{
    /// <summary>
    /// A class that contains one of array rows sorting options(one of concrete strategies).
    /// </summary>
    public class AscendingSortBySums : ISortStrategy
    {
        /// <summary>
        /// A method of sorting matrix rows by ascending sums of row elements.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>Sorted array.</returns>
        public int[,] SortArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(0); j++)
                {
                    int previousSum = SortHelper.FindSumInRow(array, j - 1),
                        currentSum = SortHelper.FindSumInRow(array, j);

                    if (previousSum > currentSum)
                    {
                        SortHelper.SwapCurrentStringWithPrevious(array, j);
                    }
                }
            }

            return array;
        }
    }
}
