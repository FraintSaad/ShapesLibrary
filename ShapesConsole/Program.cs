using ShapesLibrary.Shapes;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var circle = new Circle(10);
            Console.WriteLine($"Площадь круга с радиусом 10: {circle.CalculateArea()}");

            var triangle = new Triangle(3, 4, 5 );
            Console.WriteLine($"Площадь треугольника со сторонами 3, 4, 5: {triangle.CalculateArea()}");
            if (triangle.IsRightAngled() == true)
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            else if (triangle.IsRightAngled() == false)
            {
                Console.WriteLine("Треугольник не прямоугольный");
            }
        }
    }
}
