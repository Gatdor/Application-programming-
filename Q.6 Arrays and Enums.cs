using System;

class ArrayAndEnumDemo
{
    static void Main()
    {
        // Single-dimensional array
        int[] numbers = { 1, 2, 3 };

        // Jagged array
        int[][] jaggedArray = new int[2][];
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5 };

        // 2D Array Sum
        int[,] matrix = { { 1, 2 }, { 3, 4 } };
        Console.WriteLine(Sum2DArray(matrix));
    }

    static int Sum2DArray(int[,] array)
    {
        int sum = 0;
        foreach (int value in array)
        {
            sum += value;
        }
        return sum;
    }
}
