using System;
public class Circle : Shape
{
    private double _radius = 0;

    public Circle(string color, double radius) : base(color)
    {
        SetColor(color);
        _radius = radius;
    }

    public override double GetArea()
    {
        return System.Math.PI * _radius * _radius;
    }
}