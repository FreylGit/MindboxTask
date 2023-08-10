namespace TaskLibrary
{
    public struct Triangle : IShape, IRightAngle
    {
        private double _a { get; }
        private double _b { get; }
        private double _c { get; }

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double CalculateSquare()
        {
            if (!IsValid())
            {
                throw new InvalidOperationException("Треугольник не существует");
            }
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRightAngleTriangle()
        {
            double[] sides = { _a, _b, _c };
            Array.Sort(sides);
            double a = sides[0];
            double b = sides[1];
            double c = sides[2];

            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }


        public bool IsValid()
        {
            double[] sides = { _a, _b, _c };
            Array.Sort(sides);
            if(!(sides[0] + sides[1] > sides[2]))
            {
                return false;
            }
            if (sides[0] <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
