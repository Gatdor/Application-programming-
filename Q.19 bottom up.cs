using System;

class UtilityComponent
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Application
{
    static void Main()
    {
        UtilityComponent utility = new UtilityComponent();
        int sum = utility.Add(5, 3);
        int product = utility.Multiply(4, 2);
        Console.WriteLine($"Sum: {sum}, Product: {product}");
    }
}
