namespace Area_of_circle_and_triangle
{
    public class Triangle
    {
        public double side1;
        public double side2;
        public double side3;
        public double area;
        public bool rightTriangle;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            area = 0;
        }
    }
}
