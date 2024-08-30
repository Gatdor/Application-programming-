using System;

class LoopDemo
{
    static void Main()
    {
        // while loop
        int i = 0;
        while (i < 3)
        {
            Console.WriteLine(i);
            i++;
        }

        // do-while loop
        i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 3);

        // for loop
        for (int j = 0; j < 3; j++)
        {
            Console.WriteLine(j);
        }
    }
}
