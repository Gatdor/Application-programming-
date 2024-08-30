using System;
using System.Collections.Generic;

class UniqueSumCalculator
{
    static void Main()
    {
        HashSet<int> uniqueNumbers = new HashSet<int>();
        int number;
        Console.WriteLine("Enter integers (negative number to stop):");

        while ((number = Convert.ToInt32(Console.ReadLine())) >= 0)
        {
            uniqueNumbers.Add(number);
        }

        int sum = 0;
        foreach (int num in uniqueNumbers)
        {
            sum += num;
        }

        Console.WriteLine($"Sum of unique numbers: {sum}");
    }
}
