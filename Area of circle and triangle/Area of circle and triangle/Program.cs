namespace Area_of_circle_and_triangle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("впишите данные (если их несколько, введите через пробел)");
            var text = Console.ReadLine();
            if (text == null)
            {
                Console.WriteLine("введите данные");
                return;
            }
            string[] numbers = text.Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!Double.TryParse(numbers[i]?.ToString(), out double result))
                {
                    Console.WriteLine("введены неправильные данные");   
                    return;
                }
            }

            if (numbers.Length == 1)
            {
                double radius = double.Parse(numbers[0]);
                Figure circle = new Figure(radius);
                circle.Calculate(circle._circle);
                Console.WriteLine("площадь круга " + circle._circle.area);
            }
            else if (numbers.Length == 3)
            {
                double x = double.Parse(numbers[0]);
                double y = double.Parse(numbers[1]);
                double z = double.Parse(numbers[2]);
                Figure triangle = new Figure(x, y, z);
                triangle.Calculate(triangle._triangle);
                if (triangle._triangle.area == 0)
                {
                    Console.WriteLine("треугольник с такими сторонами является вырожденным");
                }
                else if (Double.IsNaN(triangle._triangle.area))
                {
                    Console.WriteLine("треугольника с такими сторонами не существует");
                }
                else
                {
                    Console.WriteLine("площадь треугольника " + triangle._triangle.area);
                    if (triangle._triangle.rightTriangle == true)
                    {
                        Console.WriteLine("также этот треугольник прямоугольный");
                    }
                }
            }
            else
            {
                Console.WriteLine("неверные данные");
                return ;
            }
        }
    }
}