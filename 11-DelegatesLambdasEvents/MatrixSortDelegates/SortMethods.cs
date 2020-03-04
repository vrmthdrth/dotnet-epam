namespace MatrixSortDelegatesTask
{
    public class SortMethods
    {
        /// <summary>
        /// A method of sorting matrix rows by ascending maximal elements of rows.
        /// </summary>
        /// <param name="matrix">Input array.</param>
        /// <returns>Sorted array.</returns>
        public static Matrix AscendingByMax(Matrix matrix)
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

        /// <summary>
        /// A method of sorting matrix rows by ascending minimal elements of rows.
        /// </summary>
        /// <param name="matrix">Input array.</param>
        /// <returns>Sorted array.</returns>
        public static Matrix AscendingByMin(Matrix matrix)
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

        /// <summary>
        /// A method of sorting matrix rows by ascending sums of row elements.
        /// </summary>
        /// <param name="matrix">Input array.</param>
        /// <returns>Sorted array.</returns>
        public static Matrix AscendingBySum(Matrix matrix)
        {
            for (int i = 0; i < matrix.Values.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.Values.GetLength(0); j++)
                {
                    int previousSum = SortHelper.FindSumInRow(matrix.Values, j - 1),
                        currentSum = SortHelper.FindSumInRow(matrix.Values, j);

                    if (previousSum > currentSum)
                    {
                        SortHelper.SwapCurrentStringWithPrevious(matrix.Values, j);
                    }
                }
            }

            return matrix;
        }

        /// <summary>
        /// A method of sorting matrix rows by descending maximal elements of rows.
        /// </summary>
        /// <param name="matrix">Input array.</param>
        /// <returns>Sorted array.</returns>
        public static Matrix DescendingByMax(Matrix matrix)
        {
            for (int i = 0; i < matrix.Values.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.Values.GetLength(0); j++)
                {
                    int previousMax = SortHelper.FindMaxInRow(matrix.Values, j - 1),
                        currentMax = SortHelper.FindMaxInRow(matrix.Values, j);

                    if (previousMax < currentMax)
                    {
                        SortHelper.SwapCurrentStringWithPrevious(matrix.Values, j);
                    }
                }
            }

            return matrix;
        }

        /// <summary>
        /// A method of sorting matrix rows by descending minimal elements of rows.
        /// </summary>
        /// <param name="matrix">Input array.</param>
        /// <returns>Sorted array.</returns>
        public static Matrix DescendingByMin(Matrix matrix)
        {
            for (int i = 0; i < matrix.Values.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.Values.GetLength(0); j++)
                {
                    int previousMin = SortHelper.FindMinInRow(matrix.Values, j - 1),
                        currentMin = SortHelper.FindMinInRow(matrix.Values, j);

                    if (previousMin < currentMin)
                    {
                        SortHelper.SwapCurrentStringWithPrevious(matrix.Values, j);
                    }
                }
            }

            return matrix;
        }

        /// <summary>
        /// A method of sorting matrix rows by descending sums of row elements.
        /// </summary>
        /// <param name="matrix">Input array.</param>
        /// <returns>Sorted array.</returns>
        public static Matrix DescendingBySum(Matrix matrix)
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
