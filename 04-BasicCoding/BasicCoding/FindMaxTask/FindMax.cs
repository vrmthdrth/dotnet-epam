namespace FindMaxTask
{
    using System;

    /// <summary>
    /// Contains method to find maximum in arrays.
    /// </summary>
    public class FindMax
    {
        /// <summary>
        /// Method that use recursion in order to find max element.
        /// </summary>
        /// <param name="arr">Array of integer numbers.</param>
        /// <param name="left">Array element to compare.</param>
        /// <param name="right">Another array element to compare.</param>
        /// <returns>Maximal element.</returns>
        public static int RecursiveMaxSearch(int[] arr, int left, int right)
        {
            if (left == right)
            {
                return arr[left];
            }
            else
            {
                int leftMax = RecursiveMaxSearch(arr, left, (left + right) / 2),
                    rightMax = RecursiveMaxSearch(arr, ((left + right) / 2) + 1, right);

                if (leftMax > rightMax)
                {
                    return leftMax;
                }
                else
                {
                    return rightMax;
                }
            }
        }
    }
}