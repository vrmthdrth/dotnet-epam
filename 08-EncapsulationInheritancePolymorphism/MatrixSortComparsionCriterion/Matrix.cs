namespace MatrixSortComparisonCriterion
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class for working with matrices.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Gets an array of matrix elements.
        /// </summary>
        public int[,] Values { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class.
        /// </summary>
        /// <param name="values">Array of matrix elements.</param>
        public Matrix(int[,] values)
        {
            this.Values = values;
        }

        /// <summary>
        /// Indexer declaration. Gets and sets values of matrix elements.
        /// </summary>
        /// <param name="i">Row index.</param>
        /// <param name="j">Column index.</param>
        /// <returns>Value.</returns>
        public int this[int i, int j]
        {
            get
            {
                return this.Values[i, j];
            }

            set
            {
                this.Values[i, j] = value;
            }
        }

        /// <summary>
        /// An enumeration to define specific sort types.
        /// </summary>
        public enum SortCriterion
        {
            /// <summary>
            /// An enumeration element defining ascending sort by maximal element.
            /// </summary>
            AscByMax,

            /// <summary>
            /// An enumeration element defining ascending sort by minimal element.
            /// </summary>
            AscByMin,

            /// <summary>
            /// An enumeration element defining ascending sort by sum.
            /// </summary>
            AscBySum,

            /// <summary>
            /// An enumeration element defining descending sort by maximal element.
            /// </summary>
            DescByMax,

            /// <summary>
            /// An enumeration element defining descending sort by minimal element.
            /// </summary>
            DescByMin,

            /// <summary>
            /// An enumeration element defining descending sort by sum.
            /// </summary>
            DescBySum,
        }

        /// <summary>
        /// A method of sorting matrix rows depending on the sort criterion.
        /// </summary>
        /// <param name="criterion">A parameter defining specific sort type.</param>
        /// <returns>Matrix.</returns>
        public Matrix Sort(SortCriterion criterion)
        {
            switch (criterion)
            {
                case SortCriterion.AscByMax:
                    return new AscendingByMax().SortMatrix(this);
                case SortCriterion.AscByMin:
                    return new AscendingByMin().SortMatrix(this);
                case SortCriterion.AscBySum:
                    return new AscendingBySum().SortMatrix(this);
                case SortCriterion.DescByMax:
                    return new DescendingByMax().SortMatrix(this);
                case SortCriterion.DescByMin:
                    return new DescendingByMin().SortMatrix(this);
                case SortCriterion.DescBySum:
                    return new DescendingBySum().SortMatrix(this);
                default:
                    throw new ArgumentException();
            }
        }

        /// <summary>
        /// An overriding of Object.Equals() method to work with Matrix type.
        /// </summary>
        /// <param name="obj">Matrix for comparison.</param>
        /// <returns>"True" if matrices are equal and "False" if they are not.</returns>
        public override bool Equals(object obj)
        {
            var matrix = obj as Matrix;
            if (matrix == null || (this.Values.GetLength(0) != matrix.Values.GetLength(0) || this.Values.GetLength(1) != matrix.Values.GetLength(1)))
            {
                return false;
            }
            else
            {
                for (int i = 0; i < this.Values.GetLength(0); i++)
                {
                    for (int j = 0; j < this.Values.GetLength(1); j++)
                    {
                        if ((decimal)this.Values[i, j] != (decimal)matrix.Values[i, j])
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// An overriding of Object.GetHashCode() method to work with Polynomial type.
        /// </summary>
        /// <returns>Hash code of a current object.</returns>
        public override int GetHashCode()
        {
            return 1291433875 + EqualityComparer<int[,]>.Default.GetHashCode(this.Values);
        }
    }
}
