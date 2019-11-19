namespace GeometricShapes
{
    /// <summary>
    /// A class describing properties and methods of a square.
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        /// <param name="center">Central point.</param>
        /// <param name="side">Side.</param>
        public Square(Point center, double side)
            : base(center, side, side)
        {
            this.Width = side;
            this.Height = side;
            this.Center = center;
            this.A = new Point(center.X - (side / 2), center.Y + (side / 2));
            this.C = new Point(center.X - (side / 2), center.Y - (side / 2));
            this.B = new Point(center.X + (side / 2), center.Y + (side / 2));
            this.D = new Point(center.X + (side / 2), center.Y - (side / 2));
        }
    }
}
