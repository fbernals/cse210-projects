using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shape = new List<Shape>();
        shape.Add(new Square(2, "red"));
        shape.Add(new Rectangle(3, 2, "yellow"));
        shape.Add(new Circle(2, "blue"));

        foreach(Shape shapes in shape){

            Console.WriteLine($"The {shapes} area is {shapes.GetArea()} square cm and color is {shapes.GetColor()}.");

        }
        

    }
}