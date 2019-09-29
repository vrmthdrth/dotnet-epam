namespace InsertNumberTask
{
    using System;

    /// <summary>
    /// Contains method to insert one 4-byte number into second.
    /// </summary>
    public class NumberInsertion
    {
        /// <summary>
        /// This method returns a number after insertion.
        /// </summary>
        /// <param name="numberSource">Source number.</param>
        /// <param name="numberIn">Inserting number.</param>
        /// <param name="i">The "i" position of byte.</param>
        /// <param name="j">The "j" position of byte.</param>
        /// <returns>New number as a result of insertion.</returns>
        public static int InsertNumber(sbyte numberSource, sbyte numberIn, int i, int j)
        {
            if (numberSource > 15 || numberIn > 15 || numberSource < 8 || numberIn < 8)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (i > j)
            {
                throw new ArgumentOutOfRangeException();
            }

            int middle = ((2 << (j - i)) - 1) << i;
            int nsrc = numberSource & ~middle;
            int nin = (numberIn << i) & middle;
            return nsrc | nin;
        }
    }
}