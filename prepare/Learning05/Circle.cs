public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double pi = Math.PI;
        double area = pi * (_radius * _radius);
        return Math.Round(area, 2);
    }
}