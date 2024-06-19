namespace Area_of_circle_and_triangle
{
    public class Circle
    {
        public const double π = 3.14159;
        public double radius { get; private set; }
        public double area { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
            area = 0;
        }
    }
}
