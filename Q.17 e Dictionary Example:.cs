using System;
using System.Collections.Generic;

class StudentGrades
{
    static void Main()
    {
        Dictionary<string, int> grades = new Dictionary<string, int>
        {
            { "Alice", 85 },
            { "Bob", 90 },
            { "Charlie", 78 }
        };

        // Retrieve and print grades
        foreach (var entry in grades)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}
