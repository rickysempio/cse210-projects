using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");


        List<Shape> shapes = new List<Shape>();

        Square squareShape = new Square("Red", 5);
        shapes.Add(squareShape);


        Rectangle rectangleShape = new Rectangle("Blue", 4, 6);
        shapes.Add(rectangleShape);
        
         Circle circleShape = new Circle("Green", 8);
        shapes.Add(circleShape);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();


            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        
        }
    }
}