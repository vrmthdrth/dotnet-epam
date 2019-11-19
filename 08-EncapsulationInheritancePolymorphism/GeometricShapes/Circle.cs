namespace GeometricShapes
{
    using System;

    /// <summary>
    /// A class describing properties and methods of a circle.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Gets or sets an central point of a circle.
        /// </summary>
        public Point Center { get; set; }

        /// <summary>
        /// Gets or sets a radius of circle.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="center">Central point.</param>
        /// <param name="radius">Radius of a circle.</param>
        public Circle(Point center, double radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        /// <summary>
        /// A method allowing to get area of a circle.
        /// </summary>
        /// <returns>Area.</returns>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        /// <summary>
        /// A method allowing to get perimeter of a circle.
        /// </summary>
        /// <returns>Perimeter.</returns>
        public override double GetPerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}
