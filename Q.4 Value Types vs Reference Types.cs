using System;

class TypeDemo
{
    static void Main()
    {
        // Value types
        int value1 = 10;
        int value2 = value1;
        value2 = 20;
        Console.WriteLine($"Value1: {value1}, Value2: {value2}");

        // Reference types
        string[] array1 = { "A", "B", "C" };
        string[] array2 = array1;
        array2[0] = "X";
        Console.WriteLine($"Array1[0]: {array1[0]}, Array2[0]: {array2[0]}");

        Console.WriteLine($"Array1 Reference Equals Array2: {ReferenceEquals(array1, array2)}");
    }
}
