namespace MatrixStringsBubbleSort
{
    /// <summary>
    /// A class that stores a link to ISortStrategy object.
    /// </summary>
    public class SortContext
    {
        /// <summary>
        /// A link to one of strategy objects.
        /// </summary>
        private ISortStrategy _sortStrategy;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SortContext()
        {
        }

        /// <summary>
        /// Second constructor that recieves a concrete strategy.
        /// </summary>
        /// <param name="sortStrategy">Concrete strategy.</param>
        public SortContext(ISortStrategy sortStrategy)
        {
            this._sortStrategy = sortStrategy;
        }

        /// <summary>
        /// Method that allows to change strategy at program runtime.
        /// </summary>
        /// <param name="sortStrategy">Concrete strategy.</param>
        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            this._sortStrategy = sortStrategy;
        }

        /// <summary>
        /// A method that invokes a method of specific sort strategy execution.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>Output array.</returns>
        public int[,] ExecuteSort(int[,] array)
        {
            return this._sortStrategy.SortArray(array);
        }

    }
}
