using System;

public interface IMovable
{
    // Method to be implemented by classes that implement this interface
    void Move();
}

public class Car : IMovable
{
    // Implement the Move method 
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

public class Bicycle : IMovable
{
    // Implement the Move method 
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Car class
        IMovable car = new Car();
        car.Move(); 

        // Create an instance of the Bicycle class
        IMovable bicycle = new Bicycle();
        bicycle.Move();  
    }
}
