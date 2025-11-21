/*
using System;
// Define an interface
public interface IVehicle
{
    void Drive();
    void Brake();  // fixed method name and added ;
}
// Class implementing the interface
public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving...");
    }

    public void Brake()
    {
        Console.WriteLine("Applying brake on Car...");
    }
}
// Class implementing the interface
public class Bike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Bike is driving...");
    }
    public void Brake()
    {
        Console.WriteLine("Applying brake on Bike...");
    }
}

class Program
{
    static void Main()
    {
        IVehicle myCar = new Car();
        IVehicle myBike = new Bike();
        myCar.Drive();
        myCar.Brake();
        myBike.Drive();
        myBike.Brake();
    }
}
*/
// Signatures here are:
// Add(int, int)
// Add(double, double)
/*
using System;
class Dog
{
    // Field (make it public or use property if needed outside)
    public string breed;
    // Method
    public void bark()
    {
        Console.WriteLine("Dog id Barking !!");
    }
    public void run()
    {
        Console.WriteLine("Dog is running !!");
    }
    
    // Main Method
    static void Main(string[] args)
    {
        // Create Dog object
        Dog d1 = new Dog();
        Dog d2 = new Dog();
        // Assign value to breed
        d1.breed = "German Shepherd";
        d2.breed = "Pitbul";
        Console.WriteLine(d1.breed);
        Console.WriteLine(d2.breed);
        // Call method
        d1.bark();
        d2.bark();
        d1.run();
        Console.ReadLine();
    }
}
*/