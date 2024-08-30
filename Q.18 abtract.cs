using System;
using System.Collections.Generic;

abstract class Animal
{
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal> { new Dog(), new Cat() };

        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }
}
