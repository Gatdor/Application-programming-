using System;

enum DayOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class WeekdayChecker
{
    static void Main()
    {
        DayOfWeek today = DayOfWeek.Friday;

        if (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
        {
            Console.WriteLine("It's the weekend!");
        }
        else
        {
            Console.WriteLine("It's a weekday.");
        }
    }
}
