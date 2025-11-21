

using System;
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}
class Dog: Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}
class Program
{
    static void Main()
    {
        Animal a = new Animal();
        a.Sound();   // Calls base class method
        Animal d = new Dog();
        d.Sound();   // Calls derived class method (runtime overriding)
    }
}
