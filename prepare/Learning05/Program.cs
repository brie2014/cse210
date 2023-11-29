using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        Square square = new("purple", 3.5);
        Rectangle rectangle = new("red", 4, 6.2);
        Circle circle = new("yellow", 5.3);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}