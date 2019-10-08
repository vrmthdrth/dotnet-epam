namespace FilterDigitTask
{
    using System;

    /// <summary>
    /// Contains methods to filter arrays in different ways.
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// Method that filters input array and only remains elements which are contain input digit.
        /// </summary>
        /// <param name="arr">Input array.</param>
        /// <param name="number">Input digit.</param>
        /// <returns>Output array.</returns>
        public static int[] FilterDigit(int[] arr, int number)
        {
            int current, indexCount = 0;
            int[] resultArr = new int[0];

            for (int i = 0; i < arr.Length; i++)
            {
                current = arr[i];

                if (current < 0)
                {
                    current *= -1;
                }

                for (int j = current.ToString().Length - 1; j >= 0; j--)
                {
                    int digit = current % 10;
                    current /= 10;
                    if (digit == number)
                    {
                        Array.Resize(ref resultArr, indexCount + 1);
                        resultArr[indexCount] = arr[i];
                        indexCount++;
                        break;
                    }
                }
            }

            return resultArr;
        }
    }
}
