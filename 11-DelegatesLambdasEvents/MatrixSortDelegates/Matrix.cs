namespace MatrixSortDelegatesTask
{
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