using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Red", 4);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Blue", 5, 6);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Green", 3);
        shapes.Add(shape3);


        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.Color}, Area: {shape.GetArea()}");
        }
    }
}