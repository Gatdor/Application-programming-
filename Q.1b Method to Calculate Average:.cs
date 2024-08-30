using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        double average = CalculateAverage(numbers);
        Console.WriteLine($"Average: {average}");
    }

    static double CalculateAverage(int[] scores)
    {
        if (scores.Length == 0) return 0;
        double sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }
        return sum / scores.Length;
    }
}
