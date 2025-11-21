/*
using System;

public class ArrayPropertiesAndMethodsDemo
{
    // Helper method to print an array without string.Join
    public static void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("--- Demonstrating Array Class Properties ---");

        // --- 1. Length Property ---
        Console.WriteLine("\n1. Length Property:");
        int[] lengthArray = { 1, 2, 3, 4, 5 };
        Console.Write("The array is: ");
        PrintArray(lengthArray);
        Console.WriteLine($"Array.Length: {lengthArray.Length}");
        Console.WriteLine("----------------------------------------");

        // --- 2. IsFixedSize Property ---
        Console.WriteLine("\n2. IsFixedSize Property:");
        int[] fixedSizeArray = { 10, 20, 30 };
        Console.Write("The array is: ");
        PrintArray(fixedSizeArray);
        Console.WriteLine($"Array.IsFixedSize: {fixedSizeArray.IsFixedSize}");
        Console.WriteLine("----------------------------------------");

        // --- 3. IsReadOnly Property ---
        Console.WriteLine("\n3. IsReadOnly Property:");
        int[] readOnlyExampleArray = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Is a standard array read-only? {readOnlyExampleArray.IsReadOnly}");
        Console.WriteLine("----------------------------------------");

        // --- 4. Rank Property ---
        Console.WriteLine("\n4. Rank Property:");
        int[] oneDimArray = { 1, 2, 3 };
        Console.WriteLine($"The rank of a 1D array is: {oneDimArray.Rank}");
        int[,] twoDimArray = new int[2, 3];
        Console.WriteLine($"The rank of a 2D array is: {twoDimArray.Rank}");
        Console.WriteLine("========================================\n");

        Console.WriteLine("--- Demonstrating Array Class Methods ---");

        // --- 5. Sort() Method ---
        Console.WriteLine("\n5. Sort() Method:");
        int[] sortArray = { 5, 1, 4, 2, 8 };
        Console.Write("Original array: ");
        PrintArray(sortArray);
        Array.Sort(sortArray);
        Console.Write("Sorted array:   ");
        PrintArray(sortArray);
        Console.WriteLine("----------------------------------------");

        // --- 6. BinarySearch() Method ---
        Console.WriteLine("\n6. BinarySearch() Method:");
        int[] searchArray = { 1, 2, 4, 5, 8 };
        int itemToFind = 4;
        int index = Array.BinarySearch(searchArray, itemToFind);
        Console.Write("Array to search: ");
        PrintArray(searchArray);
        Console.WriteLine($"Searching for item: {itemToFind}");
        Console.WriteLine($"Item found at index: {index}");
        Console.WriteLine("----------------------------------------");

        // --- 7. Copy() Method ---
        Console.WriteLine("\n7. Copy() Method:");
        int[] sourceArray = { 1, 2, 3, 4, 5 };
        int[] destinationArray = new int[5];
        Array.Copy(sourceArray, destinationArray, 3);
        Console.Write("Source array:      ");
        PrintArray(sourceArray);
        Console.Write("Destination array after copying 3 elements: ");
        PrintArray(destinationArray);
        Console.WriteLine("----------------------------------------");

        // --- 8. Reverse() Method ---
        Console.WriteLine("\n8. Reverse() Method:");
        int[] reverseArray = { 1, 2, 3, 4, 5 };
        Console.Write("Original array: ");
        PrintArray(reverseArray);
        Array.Reverse(reverseArray);
        Console.Write("Reversed array: ");
        PrintArray(reverseArray);
        Console.WriteLine("----------------------------------------");

        // --- 9. IndexOf() Method ---
        Console.WriteLine("\n9. IndexOf() Method:");
        int[] indexOfArray = { 10, 20, 30, 40, 50, 30 };
        int itemToGetIndex = 30;
        int firstIndex = Array.IndexOf(indexOfArray, itemToGetIndex);
        Console.Write("Array: ");
        PrintArray(indexOfArray);
        Console.WriteLine($"First index of '{itemToGetIndex}': {firstIndex}");
        Console.WriteLine("----------------------------------------");

        // --- 10. Resize() Method ---
        Console.WriteLine("\n10. Resize() Method:");
        int[] resizeArray = { 1, 2, 3 };
        Console.Write("Original array: ");
        PrintArray(resizeArray);
        Console.WriteLine($"Length: {resizeArray.Length}");
        Array.Resize(ref resizeArray, 5);
        resizeArray[3] = 4;
        resizeArray[4] = 5;
        Console.Write("Resized array:  ");
        PrintArray(resizeArray);
        Console.WriteLine($"New Length: {resizeArray.Length}");
        Console.WriteLine("----------------------------------------");
    }
}
*/