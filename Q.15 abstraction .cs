using System;

// Abstract base class
abstract class Shape
{
    public abstract void Draw();  // Abstract method

    // Concrete method
    public void Describe()
    {
        Console.WriteLine("I am a shape.");
    }
}

// Derived class Circle
class Circle : Shape
{
    public int Radius { get; set; }

    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }

    public void DisplayRadius()
    {
        Console.WriteLine($"Radius: {Radius}");
    }
}

// Derived class Square
class Square : Shape
{
    public int SideLength { get; set; }

    public override void Draw()
    {
        Console.WriteLine("Drawing a square.");
    }

    public void DisplaySideLength()
    {
        Console.WriteLine($"Side Length: {SideLength}");
    }
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle { Radius = 5 };
        Shape square = new Square { SideLength = 4 };

        circle.Draw();
        square.Draw();
        
        // Using derived class methods
        if (circle is Circle c)
        {
            c.DisplayRadius();
        }
        if (square is Square s)
        {
            s.DisplaySideLength();
        }
    }
}
