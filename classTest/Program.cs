using System;
using System.Threading;

class Program
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Worker Thread: " + i);
            Thread.Sleep(0);
        }
    }

    static void printAlphabates()
    {
        for (char c = 'A'; c <= 'Z'; c++)
        {
            Console.WriteLine("Alphabet thread : " + c);
            Thread.Sleep(0);
        }
    }
    static void Main()
    {
        Thread t1 = new Thread(PrintNumbers);
        t1.Priority = ThreadPriority.AboveNormal;
        t1.Start();

        Thread t2 = new Thread(printAlphabates);
        t2.Priority = ThreadPriority.AboveNormal;
        t2.Start();

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Main Thread: " + i);
            Thread.CurrentThread.Priority = ThreadPriority.BelowNormal;
            Thread.Sleep(0);
        }
    }
}