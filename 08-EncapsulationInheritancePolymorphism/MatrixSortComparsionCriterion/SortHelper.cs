namespace MatrixSortComparisonCriterion
{
    /// <summary>
    /// Class that contains various of array sort methods.
    /// </summary>
    public class SortHelper
    {
        /// <summary>
        /// Method that returns a maximal element in an array row.
        /// </summary>
        /// <param name="array">Array.</param>
        /// <param name="row">Row index.</param>
        /// <returns>Maximal element of a row.</returns>
        public static int FindMaxInRow(int[,] array, int row)
        {
            int max = int.MinValue;
            for (int column = 0; column < array.GetLength(1); column++)
            {
                if (array[row, column] > max)
                {
                    max = array[row, column];
                }
            }

            return max;
        }

        /// <summary>
        /// Method that returns a minimal element in an array row.
        /// </summary>
        /// <param name="array">Array.</param>
        /// <param name="row">Row index.</param>
        /// <returns>Minimal element of a row.</returns>
        public static int FindMinInRow(int[,] array, int row)
        {
            int min = int.MaxValue;
            for (int column = 0; column < array.GetLength(1); column++)
            {
                if (array[row, column] < min)
                {
                    min = array[row, column];
                }
            }

            return min;
        }

        /// <summary>
        /// Method that returns a sum of array row elements.
        /// </summary>
        /// <param name="array">Array.</param>
        /// <param name="row">Row index.</param>
        /// <returns>Sum of row elements.</returns>
        public static int FindSumInRow(int[,] array, int row)
        {
            int sum = 0;

            for (int column = 0; column < array.GetLength(1); column++)
            {
                sum += array[row, column];
            }

            return sum;
        }

        /// <summary>
        /// Method that swaps current row with previous row.
        /// </summary>
        /// <param name="array">Array.</param>
        /// <param name="row">Row.</param>
        public static void SwapCurrentStringWithPrevious(int[,] array, int row)
        {
            for (int column = 0; column < array.GetLength(1); column++)
            {
                int bubble = array[row - 1, column];
                array[row - 1, column] = array[row, column];
                array[row, column] = bubble;
            }
        }
    }
}
