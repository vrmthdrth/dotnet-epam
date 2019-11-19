namespace GeometricShapes
{
    using System;

    /// <summary>
    /// A class describing properties and methods of a point.
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Gets or sets and sets an abscissa of the point.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets and sets an ordinate of the point.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="x">Abscissa.</param>
        /// <param name="y">Ordinate.</param>
        public Point(double x = 0, double y = 0)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// A method to calculate distance between two points.
        /// </summary>
        /// <param name="a">First point.</param>
        /// <param name="b">Second point.</param>
        /// <returns>Distance.</returns>
        public static double GetDistance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }
}
