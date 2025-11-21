
/*
using System;
namespace JaggedAry
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[] { 1, 2, 3 };
            jaggedArr[1] = new int[] {10};
            jaggedArr[2] = new int[] {20, 22, 33};
                

            int i, j;

            //output each array element's value 
            Console.WriteLine("The Elements in Jagged Array are:");

            for (i = 0; i < jaggedArr.Length; i++)
            {
                Console.WriteLine(); // new line between rows
                for (j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.WriteLine($"jaggedArr[{i}][{j}] = {jaggedArr[i][j]}");
                }
            }
        }
    }
}
*/

/*
using System;
namespace JaggedAry
{
    class Program
    {
        static void Main(string[] args)
        {
            // a jagged array of 5 array of integers 
            int[][] a = new int[][]
            {
                new int[] {10},
                new int[] {20, 22, 33},
                new int[] {12, 14},
                new int[] {63, 46, 16, 78},
                new int[] {94, 88, 25}
            };

            int i, j;

            // output each array element's value 
            Console.WriteLine("The Elements in Jagged Array are:");

            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine(); // new line between rows
                for (j = 0; j < a[i].Length; j++)
                {
                    Console.WriteLine($"a[{i}][{j}] = {a[i][j]}");
                }
            }

            Console.ReadLine();
        }
    }
}
*/