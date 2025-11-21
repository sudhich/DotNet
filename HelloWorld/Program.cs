/*
//dotnet run
using System;

class Program {
    static void Main() {
        Console.WriteLine("Hello World");
    }
}
*/
/*
public class Program
{
    public static void Main(string[] args)
    {
        
        System.Console.WriteLine("Hello, World!");
    }
}
*/
//Example: How to use WriteLine() and Write() method?
/*using System;
 
namespace Sample
{
	class Test
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Prints on ");
			Console.WriteLine("New line");

			Console.Write("Prints on ");
			Console.Write("Same line");
		}
	}
}
*/
/*
using System;

class BlockExample
{
    public static void Main(string[] args)
    {
        double temperature = 42.05;
        if (temperature > 32)
        {	// Start of block
            Console.WriteLine("Current temperature = {0}",temperature);
            //2 way
            //Console.WriteLine($"Current temperature = {temperature}");
            //3 
            // way Console.WriteLine("Current temperature = " + temperature);
            //    Thia is incorrect.
            // Console.WriteLine("Current temperature = ", temperature);
            Console.WriteLine("It's hot");
        }	// End of block
    }
}

*/
/*
//Example 1: Get Input From User(String/integer/float)
using System;
namespace Sample
{
	class Test
	{
		public static void Main(string[] args)
		{
			string testString;
			Console.Write("Enter a string - ");
			testString = Console.ReadLine();
			Console.WriteLine("You entered '{0}'", testString);
		}
	}
}
*/
/*
//Example 2: Difference between Read() and ReadKey() method
using System;
namespace Sample
{
	class Test
	{
		public static void Main(string[] args)
		{
			int userInput;

			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
			Console.WriteLine();

			Console.Write("Input using Read() - ");
			userInput = Console.Read();
			Console.WriteLine("Ascii Value = {0}",userInput);
		}
	}
}
*/
//comment
/*
public class Program
{
    public static void Main(string[] args)
    {
        /// <summary>
        ///  This is a hello world program.
        /// </summary>

        System.Console.WriteLine("Hello, World!");
    }
}
*/
/*
//Datatype Singed and Unsigned
using System;

class Program
{
    static void Main()
    {
        // Signed integral types
        sbyte sbyteVar = -100;          // Range: -128 to 127
        short shortVar = -30000;        // Range: -32,768 to 32,767
        int intVar = -2000000000;       // Range: -2,147,483,648 to 2,147,483,647
        long longVar = -9000000000000000000L; // Range: –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

        // Unsigned integral types
        byte byteVar = 200;             // Range: 0 to 255
        ushort ushortVar = 60000;       // Range: 0 to 65,535
        uint uintVar = 4000000000;      // Range: 0 to 4,294,967,295
        ulong ulongVar = 18000000000000000000UL; // Range: 0 to 18,446,744,073,709,551,615

        // Display the values
        Console.WriteLine("Signed Types:");
        Console.WriteLine($"sbyte: {sbyteVar}");
        Console.WriteLine($"short: {shortVar}");
        Console.WriteLine($"int: {intVar}");
        Console.WriteLine($"long: {longVar}");

        Console.WriteLine("\nUnsigned Types:");
        Console.WriteLine($"byte: {byteVar}");
        Console.WriteLine($"ushort: {ushortVar}");
        Console.WriteLine($"uint: {uintVar}");
        Console.WriteLine($"ulong: {ulongVar}");
    }
}
*/
/*
// Floating-point datatype
using System;

class Program
{
    static void Main()
    {
        // Floating-point types
        float floatVar = 3.14159f;      // 'f' suffix is required for float literals
        double doubleVar = 3.141592653589793; // More precision than float

        // Display the values
        Console.WriteLine("Floating-Point Types:");
        Console.WriteLine($"float: {floatVar}");
        Console.WriteLine($"double: {doubleVar}");
    }
}
*/
/*
//// char datatype
using System;

class Program
{
    static void Main()
    {
        char letter = 'A';
        char digit = '5';
        char symbol = '#';
        char unicodeChar = '\u03A9'; // Greek capital letter Omega (Ω)

        Console.WriteLine("Character Examples:");
        Console.WriteLine($"Letter: {letter}");
        Console.WriteLine($"Digit: {digit}");
        Console.WriteLine($"Symbol: {symbol}");
        Console.WriteLine($"Unicode Character: {unicodeChar}");
    }
}
*/
/*
//decimal data type
using System;

class Program
{
    static void Main()
    {
        decimal price = 199.99m;     // 'm' suffix indicates decimal
        decimal taxRate = 0.18m;
        decimal total = price + (price * taxRate);

        Console.WriteLine("Decimal Example:");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Tax Rate: {taxRate}");
        Console.WriteLine($"Total Price with Tax: {total}");
    }
}
*/
/*
//Boolean Data type
using System;

class Program
{
    static void Main()
    {
        bool isStudent = true;
        bool hasGraduated = false;

        Console.WriteLine("Boolean Example:");
        Console.WriteLine($"Is Student: {isStudent}");
        Console.WriteLine($"Has Graduated: {hasGraduated}");

        // Using bool in condition
        if (isStudent)
        {
            Console.WriteLine("Welcome, student!");
        }

        if (!hasGraduated)
        {
            Console.WriteLine("You have not graduated yet.");
        }
    }
}
*/

//References Data Types–
/*
using System;

class Student
{
    public string Name;
}

class Program
{
    static void Main()
    {
        // string is a reference type
        string message = "Hello, world!";
        Console.WriteLine("String Example: " + message);

        // object is the base type of all types
        object obj = 42;
        Console.WriteLine("Object Example: " + obj);

        // array (reference type)
        int[] numbers = { 1, 2, 3 };
        Console.WriteLine("Array Example: " + numbers[0]);

        // class (custom reference type)
        Student s1 = new Student();
        s1.Name = "Aditya";
        Console.WriteLine("Class Example: " + s1.Name);

        // Demonstrating reference behavior
        Student s2 = s1;
        s2.Name = "Sudhir";
        Console.WriteLine("After modifying s2:");
        Console.WriteLine("s1.Name: " + s1.Name); 
    }
}
*/

//enum
/*
using System;

enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main()
    {
        Days today = Days.Monday;

        Console.WriteLine("Enum Example:");
        Console.WriteLine($"Today is: {today}");
        Console.WriteLine($"Numeric value of {today}: {(int)today}");
    }
}
*/
//Pointer
//dotnet build -p:AllowUnsafeBlocks=true
/*
using System;

class Program
{
    unsafe static void Main()
    {
        int num = 42;
        int* ptr = &num;

        Console.WriteLine($"Value of num: {num}");
        Console.WriteLine($"Address of num: {(int)ptr}");
        Console.WriteLine($"Value at pointer: {*ptr}");
    }
}
*/
//Inference 
/*
using System;

class Program
{
    static void Main()
    {
        var name = "Aditya";     // Compiler infers: string
        var age = 25;            // Compiler infers: int
        var pi = 3.14;           // Compiler infers: double
        var isStudent = true;    // Compiler infers: bool

        Console.WriteLine($"Name: {name}, Age: {age}, Pi: {pi}, Student: {isStudent}");
    }
}
*/
/*
//Accessing Array Elements
int[] ages = { 20, 25, 30, 35 };
Console.WriteLine(ages[0]);  // Output: 20
ages[2] = 32;                // Update index 2 to 32
*/
















/*
dotnet build -p:AllowUnsafeBlocks=true
dotnet run
dotnet build -p:StartupObject=forloop
dotnet run

*/