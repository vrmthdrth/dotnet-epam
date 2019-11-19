namespace GeometricShapes
{
    /// <summary>
    /// An abstract class describing common methods of different shapes.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// An abstract method of getting area of shape.
        /// </summary>
        /// <returns>Area.</returns>
        public abstract double GetArea();

        /// <summary>
        /// An abstract method of getting perimeter of shape.
        /// </summary>
        /// <returns>Perimeter.</returns>
        public abstract double GetPerimeter();
    }
}
