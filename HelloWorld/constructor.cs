/*
using System;
class Car
{
    public string Model;
    public int Year;
    // Default constructor
    public void Abc()
    {
        Model = "Audi";
        Year = 2000;
    }
}
class Program
{
    static void Main()
    {  
        Car c1 = new Car(); // calls default constructor
        c1.Abc();
        Console.WriteLine($"Model: {c1.Model}, Year: {c1.Year}");
    }
}
*/
/*
using System;
class Student
{
    public string Name;
    public int Age;
    // Parameterized constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
class Program
{
    static void Main()
    {
        // Creating objects using parameterized constructor
        Student s1 = new Student("Rahul", 20);
        Student s2 = new Student("Priya", 22);
        Console.WriteLine($"Name: {s1.Name}, Age: {s1.Age}");
        Console.WriteLine($"Name: {s2.Name}, Age: {s2.Age}");
    }
}
*/
/*
using System;
class Student
{
    public string Name;
    public int Age;
    // Parameterized constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
    // Copy constructor
    public Student(Student s)
    {
        Name = s.Name;
        Age = s.Age;
    }
}
class Program
{
    static void Main()
    {
        // Create object using parameterized constructor
        Student s1 = new Student("Rahul", 20);
        // Create new object using copy constructor
        Student s2 = new Student(s1);
        Console.WriteLine($"s1 -> Name: {s1.Name}, Age: {s1.Age}");
        Console.WriteLine($"s2 -> Name: {s2.Name}, Age: {s2.Age}");
    }
}
*/
/*
using System;
class Student
{
    public static string SchoolName;
    public string Name;
    // Static constructor
    static Student()
    {
        Console.WriteLine("Static Constructor Called");
        SchoolName = "ABC International School";
    }
    // Normal constructor
    public Student(string name)
    {
        Name = name;
        Console.WriteLine("Normal Constructor Called");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Program Started");
        // First object
        Student s1 = new Student("Rahul");
        Console.WriteLine($"{s1.Name} - {Student.SchoolName}");
        // Second object
        Student s2 = new Student("Priya");
        Console.WriteLine($"{s2.Name} - {Student.SchoolName}");
    }
}
*/