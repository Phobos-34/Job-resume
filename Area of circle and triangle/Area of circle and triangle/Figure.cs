namespace Area_of_circle_and_triangle
{
    public class Figure
    {
        public Circle? _circle { get; set; }
        public Triangle? _triangle { get; set; }
        public Figure(double x)
        {
            Circle circle = new Circle(x);
            _circle = circle;
        }

        public Figure(double x, double y, double c)
        {
            Triangle triangle = new Triangle(x, y, c);
            _triangle = triangle;
        }

        public void Calculate(Circle circle)
        {
            circle.area = circle.radius * circle.radius * Circle.π;
        }

        public void Calculate(Triangle triangle)
        {
            double p = (triangle.side1 + triangle.side2 + triangle.side3) / 2;
            triangle.area = Math.Sqrt(p * (p - triangle.side1) * (p - triangle.side2) * (p - triangle.side3));
            double[] sides = { triangle.side1, triangle.side2, triangle.side3 };
            Array.Sort(sides);
            triangle.side1 = sides[0];
            triangle.side2 = sides[1];
            triangle.side3 = sides[2];
            triangle.rightTriangle = Math.Abs(triangle.side3 * triangle.side3 - (triangle.side1 * triangle.side1 + triangle.side2 * triangle.side2)) < 1e-10;
        }
    }
}
