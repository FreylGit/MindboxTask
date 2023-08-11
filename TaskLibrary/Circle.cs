namespace TaskLibrary
{
    /// <summary>
    /// Круг
    /// </summary>
    public struct Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateSquare()
        {
            if(!IsValid())
            {
                throw new InvalidOperationException("Круг не существует");
            }
            return Math.PI * Math.Pow(_radius, 2);
        }

        public bool IsValid()
        {
            if(_radius < 0) 
                return false;
            return true;
        }
    }
    
}

