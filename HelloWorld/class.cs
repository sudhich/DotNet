/*
using System;
class Dog
{
    // Field (make it public or use property if needed outside)
    public string breed;
    // Method
    public void bark()
    {
        Console.WriteLine("Bark Bark !!");
    }
    // Main Method
    static void Main(string[] args)
    {
        // Create Dog object
        Dog Dog = new Dog();
        // Assign value to breed
        Dog.breed = "German Shepherd";
        Console.WriteLine(Dog.breed);
        // Call method
        Dog.bark();
        Console.ReadLine();
    }
}
*/
/*
using System;
// Define interface
public interface IAnimal
{
    void MakeSound();   // Method without body
    string Name { get; set; } // Property without implementation
}
// Implement interface in Dog class
public class Dog : IAnimal
{
    public string Name { get; set; }

    public Dog(string name)
    {
        Name = name;
    }
    public void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}
// Implement interface in Cat class
public class Cat : IAnimal
{
    public string Name { get; set; }
    public Cat(string name)
    {
        Name = name;
    }

    public void MakeSound()
    {
        Console.WriteLine("Meow! Meow!");
    }
}

class Program
{
    static void Main()
    {
        IAnimal dog = new Dog("Buddy");
        IAnimal cat = new Cat("Kitty");

        Console.WriteLine($"Dog Name: {dog.Name}");
        dog.MakeSound();

        Console.WriteLine($"Cat Name: {cat.Name}");
        cat.MakeSound();
    }
}
*/
