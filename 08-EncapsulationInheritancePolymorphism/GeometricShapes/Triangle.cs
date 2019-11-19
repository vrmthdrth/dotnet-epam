namespace GeometricShapes
{
    using System;

    /// <summary>
    /// A class describing properties and methods of a triangle.
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Gets "A" point of a rectangle.
        /// </summary>
        public Point A { get; private set; }

        /// <summary>
        /// Gets "B" point of a rectangle.
        /// </summary>
        public Point B { get; private set; }

        /// <summary>
        /// Gets "C" point of a rectangle.
        /// </summary>
        public Point C { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="a">First point.</param>
        /// <param name="b">Second point.</param>
        /// <param name="c">Third point.</param>
        public Triangle(Point a, Point b, Point c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        /// <summary>
        /// A method to calculate area of triangle.
        /// </summary>
        /// <returns>Area.</returns>
        public override double GetArea()
        {
            return (1.0d / 2.0d) * Math.Abs(((this.A.X - this.C.X) * (this.B.Y - this.C.Y)) - ((this.A.Y - this.C.Y) * (this.B.X - this.C.X)));
        }

        /// <summary>
        /// A method to calculate perimeter of triangle.
        /// </summary>
        /// <returns>Perimeter.</returns>
        public override double GetPerimeter()
        {
            return Point.GetDistance(this.A, this.B) + Point.GetDistance(this.B, this.C) + Point.GetDistance(this.C, this.A);
        }
    }
}
