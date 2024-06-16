using System;

public class Animal
{
    // Method that prints a generic sound
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

public class Dog : Animal
{
    // Override the MakeSound method to print "Bark"
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    //Override MakeSound method to print "Meow"
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}
class Program
{
    static void Main()
    {
        // Create an instance of the Animal class
        Animal animal = new Animal();
        animal.MakeSound();

        // Create an instance of the Dog class
        Dog dog = new Dog();
        dog.MakeSound();  

        // Create an instance of the Cat class
        Cat cat = new Cat();
        cat.MakeSound();
    }
}
