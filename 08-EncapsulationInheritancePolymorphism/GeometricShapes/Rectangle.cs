namespace GeometricShapes
{
    /// <summary>
    /// A class describing properties and methods of a rectangle.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Gets center of a rectangle.
        /// </summary>
        public Point Center { get; private protected set; }

        /// <summary>
        /// Gets "A" point of a rectangle.
        /// </summary>
        public Point A { get; private protected set; }

        /// <summary>
        /// Gets "B" point of a rectangle.
        /// </summary>
        public Point B { get; private protected set; }

        /// <summary>
        /// Gets "C" point of a rectangle.
        /// </summary>
        public Point C { get; private protected set; }

        /// <summary>
        /// Gets "D" point of a rectangle.
        /// </summary>
        public Point D { get; private protected set; }

        /// <summary>
        /// Gets a width of a rectangle.
        /// </summary>
        public double Width { get; private protected set; }

        /// <summary>
        /// Gets a height of a rectangle.
        /// </summary>
        public double Height { get; private protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        public Rectangle()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="center">A central point of a rectangle.</param>
        /// <param name="width">First side.</param>
        /// <param name="height">Second side.</param>
        public Rectangle(Point center, double width, double height)
        {
            this.Width = width;
            this.Height = height;
            this.Center = center;
            this.A = new Point(center.X - (width / 2), center.Y + (height / 2));
            this.C = new Point(center.X - (width / 2), center.Y - (height / 2));
            this.B = new Point(center.X + (width / 2), center.Y + (height / 2));
            this.D = new Point(center.X + (width / 2), center.Y - (height / 2));
        }

        /// <summary>
        /// A method to calculate area of rectangle.
        /// </summary>
        /// <returns>Area.</returns>
        public override double GetArea()
        {
            return this.Width * this.Height;
        }

        /// <summary>
        /// A method to calculate perimeter of rectangle.
        /// </summary>
        /// <returns>Perimeter.</returns>
        public override double GetPerimeter()
        {
            return 2 * (this.Width + this.Height);
        }
    }
}
