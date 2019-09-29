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
            double rightSum = 0, leftSum = 0;
            int indexCnt = 0;
            int[] indexArray = new int[indexCnt];

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
                            rightSum += arr[j];
                        }

                        for (int j = i - 1; j >= 0; j--)
                        {
                            leftSum += arr[j];
                        }

                        if (rightSum == leftSum)
                        {
                            indexCnt++;
                            Array.Resize(ref indexArray, indexCnt);
                            indexArray[indexCnt - 1] = i;
                        }
                    }
                }
            }

            if (indexArray.Length != 0)
            {
                return indexArray[0];
            }
            else
            {
                return -1;
            }
        }
    }
}
