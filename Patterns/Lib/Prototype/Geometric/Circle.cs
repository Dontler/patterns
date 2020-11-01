namespace Patterns.Lib.Prototype.Geometric
{
    public class Circle : IFigure
    {
        private int _radius;
        
        public int Radius => _radius;
        public Point Center { get; set; }

        public Circle(int radius, int x, int y)
        {
            _radius = radius;
            Center = new Point(x, y);
        }

        public IFigure Clone() => MemberwiseClone() as Circle;

        public IFigure DeepClone()
        {
            var circle = Clone() as Circle;
            circle.Center = new Point(Center.X, Center.Y);
            return circle;
        }

        public string GetPrintableInfo() => $"Figure: Circle. Radius: {Radius}. Center: {Center}";
    }
}