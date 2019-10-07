namespace FindIndexTask
{
    using System;

    /// <summary>
    /// Contains method for searching indexes in arrays.
    /// </summary>
    public class IndexSearch
    {
        /// <summary>
        /// A method for finding an index of array element for which sums of elements on it's left and on it's right are equal.
        /// </summary>
        /// <param name="arr">Input array.</param>
        /// <returns>Index.</returns>
        public static int FindIndex(double[] arr)
        {
            decimal rightSum = 0, leftSum = 0;
            int result = -1;

            if (arr.Length > 2)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    rightSum = 0;
                    leftSum = 0;
                    if ((i != 0) && (i != arr.Length - 1))
                    {
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            rightSum += (decimal)arr[j];
                        }

                        for (int j = i - 1; j >= 0; j--)
                        {
                            leftSum += (decimal)arr[j];
                        }

                        if (rightSum == leftSum)
                        {
                            result = i;
                            break;
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentException();
            }

            return result;
        }
    }
}
