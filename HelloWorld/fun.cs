/*
using System;
class Forloop
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Count: " + i);
        }
    }
}
*/
/*
using System;

class Program
{
    // Function with parameters and return value
    public static int Sub(int a, int b)
    {
        return a - b;
    }
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Mul(int a, int b)
    {
        return a * b;
    }
    // Function without parameters (and no return value)
    public static void SayHello()
    {
        Console.WriteLine("Hello from C#!");
    }

    static void Main(string[] args)
    {
        SayHello(); // Calling function without parameters

        int result1 = Add(5, 3); // Calling function with parameters
        
        Console.WriteLine($"Sum: {result1}");
        int result2 = Sub(10, 20);
        Console.WriteLine($"Sub: {result2}");
        int result3 = Mul(10, 20);
        Console.WriteLine($"Sub: {result3}");
        SayHello();
    }
}
*/
/*
using System;
class Program
{
    // Method to add two numbers
    static int AddNumbers(int x, int y)
    {
        int sum = x + y;  // local variable inside method
        return sum;
    }


    static void Main()
    {
        int a = 5;  // local variable
        int b = 3;  // local variable
        // Calling method
        int result = AddNumbers(a, b);
        Console.WriteLine($"Sum is: {result}");
        
    }
}
*/
/*
using System;
class StudentDetails
{
    
    // Constructor
    //Note-In C# costructure do not have a return type,not even void.
    public StudentDetails()
    {
        Console.WriteLine("Constructor called!");
    }
    // Method
    public void ShowAge()
    {
        // local variable age
        int age = 0;
        age = age + 16;
        Console.WriteLine("Student age is: " + age);
    }
    // Main Method
    public static void Main(string[] args)
    {
        // Creating object
        StudentDetails obj = new StudentDetails();
        // calling the function
        obj.ShowAge();
    }
}
*/
/*
using System;
class StudentDetails
{
    // Instance variable (field)
    int age=5;
    // Constructor
    // Note: In C#, constructors do not have a return type, not even void.
    public StudentDetails()
    {
        Console.WriteLine("Constructor called!");
        age = 0;
        age = age + 16;
        // Call method using 'this'
        this.ShowAge();
    }

    // Method
    public void ShowAge()
    {
        Console.WriteLine("Student age is: " + age);
    }

    // Main Method
    public static void Main(string[] args)
    {
        // Creating object
        StudentDetails obj = new StudentDetails();
    }
}
*/
/*
using System;
class Program
{
    static int Factorial(int n)
    {
        if (n == 0) // Base case
            return 1;
        else
            return n * Factorial(n - 1); // Recursive case
    }
    static void Main()
    {
        Console.WriteLine("Factorial of 5: " + Factorial(5));
    }
}
*/
/*
using System;
class Program
{
    static void Main()
    {
        int n = 5;
        long fact = 1; // Use long for big results
        for (int i = 1; i <= n; i++)
        {
            fact *= i; // fact = fact * i
        }
        Console.WriteLine($"Factorial of {n} is: {fact}");
    }
}
*/