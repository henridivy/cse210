using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("red", 4);
        Square square2 = new Square("pink", 8);

        Rectangle rect1 = new Rectangle("yellow", 6, 9);
        Rectangle rect2 = new Rectangle("orange", 3, 5);

        Circle circ1 = new Circle("blue", 3.5);
        Circle circ2 = new Circle("purple", 7);

        // Console.WriteLine($"Area of your square: {square1.GetArea()}");
        // Console.WriteLine($"Area of your rectangle: {rect1.GetArea()}");
        // Console.WriteLine($"Area of your circle: {circ1.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(square2);
        shapes.Add(rect1);
        shapes.Add(rect2);
        shapes.Add(circ1);
        shapes.Add(circ2);

        foreach (Shape shape in shapes)
        {
            // Console.WriteLine($"Shape: {shape.GetType()}");
            // Console.WriteLine($"Color: {shape.GetColor()}");
            // Console.WriteLine($"Area: {shape.GetArea()}");
            // Console.WriteLine();

            Console.WriteLine($"The {shape.GetColor()} {shape.GetType()} has an area of {shape.GetArea()}.");
        }
    }
}