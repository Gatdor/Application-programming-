using System;
using System.Collections.Generic;

class DataStructuresDemo
{
    static void Main()
    {
        // Queue example
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Customer1");
        queue.Enqueue("Customer2");
        Console.WriteLine(queue.Dequeue()); // First in, first out

        // Stack example
        Stack<string> stack = new Stack<string>();
        stack.Push("Customer1");
        stack.Push("Customer2");
        Console.WriteLine(stack.Pop()); // Last in, first out

        // List example
        List<string> list = new List<string> { "Item1", "Item2" };
        list.Add("Item3");
        Console.WriteLine(string.Join(", ", list));
    }
}
