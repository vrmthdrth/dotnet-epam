namespace UniqueInOrderTask
{
    using System.Collections.Generic;

    /// <summary>
    /// A class containing methods to work with order of elements in IEnumerable types.
    /// </summary>
    public class OrderMethods
    {
        /// <summary>
        /// A method that takes as argument a sequence and returns a list of items without any elements
        /// with the same value next to each other and preserving the original order of elements.
        /// </summary>
        /// <typeparam name="T">Type of sequence.</typeparam>
        /// <param name="iterable">Sequence to filter.</param>
        /// <returns>Filtered sequence.</returns>
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
            bool first = true;
            T lastItem = default(T);
            foreach (T thisItem in iterable)
            {
                if (first || !comparer.Equals(thisItem, lastItem))
                {
                    first = false;
                    yield return thisItem;
                }

                lastItem = thisItem;
            }
        }
    }
}
