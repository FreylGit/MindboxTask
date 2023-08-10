using TaskLibrary;

namespace TaslTests
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void TestCircleSquare()
        {
            // Arrange
            double radius = 10;
            IShape circle = new Circle(radius);

            // Act
            double expectedSquare = Math.PI * radius * radius;

            // Assert
            Assert.AreEqual(circle.CalculateSquare(), expectedSquare, 0.001);
        }

        [TestMethod]
        public void TestTriangleSquare()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            IShape triangle = new Triangle(a, b, c);

            // Act
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            // Assert
            Assert.AreEqual(triangle.CalculateSquare(), s, 0.001);
        }
        [TestMethod]
        public void TestTriangleIsRightAngle()
        {
            // Arrange
            double a = 12;
            double b = 9;
            double c = 15;
            IRightAngle triangle = new Triangle(a, b, c);

            // Act
            var isRightAngle = triangle.IsRightAngleTriangle();

            // Assert
            Assert.IsTrue(isRightAngle);
        }

        [TestMethod]
        public void TestTriangleNotRightAngle()
        {
            // Arrange
            double a = 11;
            double b = 9;
            double c = 15;
            IRightAngle triangle = new Triangle(a, b, c);

            // Act
            var isRightAngle = triangle.IsRightAngleTriangle();

            // Assert
            Assert.IsFalse(isRightAngle);
        }

        [TestMethod]
        public void TestTriangleNotValid()
        {
            // Arrange
            double a = 5;
            double b = 10;
            double c = 25;
            var triangle = new Triangle(a, b, c);

            // Act and Assert
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                double square = triangle.CalculateSquare();
            });
        }
        [TestMethod]
        public void TestCircleNotValid()
        {
            // Arrange
            double radius = -1;
            var circle1 = new Circle(radius);

            // Act and Assert
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                double square = circle1.CalculateSquare();
            });
        }
    }
}

