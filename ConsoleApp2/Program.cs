using TestLibrary.Shapes;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var circle = new Circle(10);
            Console.WriteLine(circle.CalculateArea());

            var triangle = new Triangle(3, 4, 5 );
            Console.WriteLine(triangle.CalculateArea());
            Console.WriteLine(triangle.IsRightAngled());
        }
    }
}
