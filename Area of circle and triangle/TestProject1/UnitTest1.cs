using Area_of_circle_and_triangle;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircleAreaCalculate()
        {
            double radius = 5;
            double expectedArea = 78.53975;

            Figure circle = new Figure(radius);
            circle.Calculate(circle._circle);

            double actualArea = circle._circle.area;
            Assert.AreEqual(expectedArea, actualArea, 0.001, "площадь круга не верна");
        }

        [TestMethod]
        public void TestTriangleAreaCalculate()
        {
            double a = 5;
            double b = 6;
            double c = 7;
            double expectedArea = 14.696938;

            Figure triangle = new Figure(a, b, c);
            triangle.Calculate(triangle._triangle);

            double actualArea = triangle._triangle.area;
            Assert.AreEqual(expectedArea, actualArea, 0.001, "площадь треугольника не верна");
        }

        [TestMethod]
        public void TestRightTriangleMessage()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            Figure triangle = new Figure(c, a, b);
            triangle.Calculate(triangle._triangle);

            bool actualValue = triangle._triangle.rightTriangle;
            Assert.IsTrue(actualValue, "неправильное значение");
        }
    }
}