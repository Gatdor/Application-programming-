using System;
using System.Linq;

class ListAnalysis
{
    public static (int? Max, int? Min) FindMaxMin(int[] numbers)
    {
        if (numbers.Length == 0)
            return (null, null);

        int max = numbers.Max();
        int min = numbers.Min();
        return (max, min);
    }

    static void Main()
    {
        int[] numbers = { 5, 3, 8, 1, 9, 2 };
        var result = FindMaxMin(numbers);
        Console.WriteLine($"Max: {result.Max}, Min: {result.Min}");
    }
}
