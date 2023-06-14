using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Square sqr = new Square("Green", 4);
        Rectangle rec = new Rectangle("Yellow", 3, 9);
        Circle circle = new Circle("White", 7);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(sqr);
        shapes.Add(rec);
        shapes.Add(circle);

        foreach (Shape obj in shapes)
        {
            Console.WriteLine($"The area of the {obj.Color} shape is {obj.GetArea()}.");
        }
    }
}