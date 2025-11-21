
/*
using System;
namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; // Array of 10 integers
            int i, j;
            
            // Initialize elements of array n
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            
            // Output each array element's value
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
        }
    }
}
*/
//ENTER BY USER
/*
using System;
namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]; // Array of 10 integers
            int i, j;
            
            // Get elements from user input
            Console.WriteLine("Enter 10 integers:");
            for (i = 0; i < 10; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine()); // Convert string input to integer
            }
            
            Console.WriteLine("\nPrint after array after enter elenemt:");
            // Output each array element's value
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, arr[j]);
            }
        }
    }
}
*/
/*
using System;

class One_D_Arr
{
    static void Main(string[] args)
    {
        //Declaring single dimensional array
        string[] Books = new string[5];
        Books[0] = "C#";
        Books[1] = "Java";
        Books[2] = "VB.NET";
        Books[3] = "C++";
        Books[4] = "C";
        
        Console.WriteLine("All the elements of Books array is:");
        
        int i = 0;
        //Formatting Output
        Console.Write("\t1\t2\t3\t4\t5\n\n\t");
        
        for (i = 0; i < 5; i++)
        {
            Console.Write("{0}\t", Books[i]);
        }
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        int[,] ar = {
            {10, 20, 30},
            {40, 50, 60}
        };

        Console.WriteLine("Element at [1,2]: " + ar[1, 2]);  // Output: 60

        Console.WriteLine("All elements:");
        for (int i = 0; i < 2; i++)  // rows
        {
            for (int j = 0; j < 3; j++)  // columns
            {
                Console.Write(ar[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/
/*
array.GetLength(dimensionIndex)
dimensionIndex = 0 → rows
dimensionIndex = 1 → columns
onsole.WriteLine(matrix.GetLength(0));  // Output: 2 (rows)
Console.WriteLine(matrix.GetLength(1));  // Output: 3 (columns)

*/
/*
using System;
class Program
{
    static void Main()
    {
        string[] names = { "Alice", "Bob", "Charlie" };
        Console.WriteLine("First name: " + names[0]);
        Console.WriteLine("All names:");
        foreach (string val in names)
        {
            Console.WriteLine(val);
        }
    }
}
*/
/*
using System;
public class MatrixMultiplication
{
    public static void Main()
    {
        int i, j, k, r1, c1, r2, c2, sum = 0;
        int[,] arr1 = new int[50, 50];
        int[,] brr1 = new int[50, 50];
        int[,] crr1 = new int[50, 50];
        
        Console.Write("Multiplication of two Matrices\n");
        Console.Write("----------------------------\n");
        Console.Write("Input the number of rows and columns of the first matrix\n");
        Console.Write("Rows: ");
        r1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Columns: ");
        c1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Input the number of rows and columns of the second matrix\n");
        Console.Write("Rows: ");
        r2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Columns: ");
        c2 = Convert.ToInt32(Console.ReadLine());
        
        if (c1 != r2)
        {
            Console.Write("Multiplication of Matrix is not possible.\n");
            Console.Write("Column of first matrix and row of second matrix must be same.\n");
        }
        else
        {
            Console.Write("Input elements in the first matrix:\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write("element - [{0}],[{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.Write("Input elements in the second matrix:\n");
            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    Console.Write("element - [{0}],[{1}]: ", i, j);
                    brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.Write("\nThe First matrix is:\n");
            for (i = 0; i < r1; i++)
            {
                Console.Write("\n");
                for (j = 0; j < c1; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);
                }
            }
            
            Console.Write("\nThe Second matrix is:\n");
            for (i = 0; i < r2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < c2; j++)
                {
                    Console.Write("{0}\t", brr1[i, j]);
                }
            }
            
            // Multiplication of matrix
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    crr1[i, j] = 0;
                    for (k = 0; k < c1; k++)
                    {
                        crr1[i, j] += arr1[i, k] * brr1[k, j];
                    }
                }
            }
            
            Console.Write("\nThe multiplication of two matrices is:\n");
            for (i = 0; i < r1; i++)
            {
                Console.Write("\n");
                for (j = 0; j < c2; j++)
                {
                    Console.Write("{0}\t", crr1[i, j]);
                }
            }
            Console.Write("\n");
        }
    }
}
*/