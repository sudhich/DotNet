using System;
class Program
{
static void Main()
{
// Signed integral types
sbyte sbyteVar = -100; // Range: -128 to 127
short shortVar = -30000; // Range: -32,768 to 32,767
int intVar = -2000000000; // Range: -2,147,483,648 to 2,147,483,647
long longVar = -9000000000000000000L; // Range: –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
// Unsigned integral types
byte byteVar = 200; // Range: 0 to 255
ushort ushortVar = 60000; // Range: 0 to 65,535
uint uintVar = 4000000000; // Range: 0 to 4,294,967,295
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


