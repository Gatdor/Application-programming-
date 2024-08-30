using System;

class StringComparisonDemo
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "Hello";
        string str3 = new string(new char[] { 'H', 'e', 'l', 'l', 'o' });

        Console.WriteLine(str1 == str2);       // True
        Console.WriteLine(str1 == str3);       // True
        Console.WriteLine(str1.Equals(str3));  // True
    }
}
