using System;

class ExceptionDemo
{
    static void Main()
    {
        try
        {
            int[] arr = new int[2];
            try
            {
                Console.WriteLine(arr[5]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Caught an IndexOutOfRangeException: " + e.Message);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Caught an exception: " + e.Message);
        }
    }
}
