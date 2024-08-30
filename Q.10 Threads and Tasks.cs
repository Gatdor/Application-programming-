using System;
using System.Threading;
using System.Threading.Tasks;

class ThreadDemo
{
    static void Main()
    {
        // Using Thread class
        Thread thread = new Thread(DoWork);
        thread.Start();
        thread.Join(); // Wait for the thread to complete

        // Using Task class
        Task task = Task.Run(() => DoWork());
        task.Wait(); // Wait for the task to complete
    }

    static void DoWork()
    {
        Console.WriteLine("Work done in thread.");
    }
}
