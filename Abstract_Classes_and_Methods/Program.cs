using System;

public abstract class Shape
{
    // Abstract method to calculate the area
    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Implement the GetArea method to calculate the area of a circle
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Implement the GetArea method to calculate the area of a rectangle
    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Circle class
        Circle circle = new Circle(5);
        Console.WriteLine($"Area of the circle: {circle.GetArea()}");

        // Create an instance of the Rectangle class
        Rectangle rectangle = new Rectangle(7, 12);
        Console.WriteLine($"Area of the rectangle: {rectangle.GetArea()}");
    }
}
