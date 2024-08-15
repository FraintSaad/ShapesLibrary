using NUnit.Framework;
using TestLibrary.Shapes;



namespace TestProject
{
    internal class ShapeTests
    {
        [TestFixture]
        public class SomeTests
        {
            [Test]
            public void CircleAreaTest()
            {
                var circle = new Circle(5);
                Assert.AreEqual(Math.PI * 25, circle.CalculateArea(), 1e-10);
            }

            [Test]
            public void TriangleAreaTest()
            {
                var triangle = new Triangle(3, 4, 5);
                Assert.AreEqual(6, triangle.CalculateArea(), 1e-10);
            }

            [Test]
            public void RightAngledTriangleTest()
            {
                var triangle = new Triangle(3, 4, 5);
                Assert.IsTrue(triangle.IsRightAngled());
            }

            [Test]
            public void NotRightAngledTriangleTest()
            {
                var triangle = new Triangle(3, 4, 6);
                Assert.IsFalse(triangle.IsRightAngled());
            }

        }
    }
}
