using System;
using System.IO;

class FileOperations
{
    static void Main()
    {
        string path = "books.txt";

        // Write to file
        string[] books = { "Book1", "Book2", "Book3" };
        File.WriteAllLines(path, books);

        // Read from file
        string[] readBooks = File.ReadAllLines(path);
        foreach (string book in readBooks)
        {
            Console.WriteLine(book);
        }
    }
}
