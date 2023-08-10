using TaskLibrary;

IShape triangle = new Triangle(3, 4, 5);
Console.WriteLine("Площадь треугольника: " + triangle.CalculateSquare());
if (triangle is IRightAngle rightAngleTriangle)
{
    bool isRightAngle = rightAngleTriangle.IsRightAngleTriangle();
    Console.WriteLine("Этот треугольник прямоугольный: " + isRightAngle);
}