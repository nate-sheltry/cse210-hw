using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(new Square("blue", 4));
        shapeList.Add(new Rectangle("red", 5, 7));
        shapeList.Add(new Circle("yellow", 6));

        foreach(Shape shape in shapeList){
            Console.Write("Color of Shape:");
            Console.WriteLine(shape.GetColor());
            Console.Write("Area of Shape:");
            Console.WriteLine(shape.GetArea());
        }
    }
}