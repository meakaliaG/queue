using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Print Queue
        Queue<string> printQueue = new Queue<string>();

        // Add documents to print queue
        printQueue.Enqueue("Document1");
        printQueue.Enqueue("Document2");
        printQueue.Enqueue("Document3");

        Console.WriteLine("What would you like to do?");
        Console.WriteLine("Options:\n- 'Print' - Print documents in printer queue.\n-'Quit' - End program.");

        Console.WriteLine("Print Queue:");
        while (printQueue.Count > 0)
        {
            Console.WriteLine($"Printing: {printQueue.Dequeue()}");
        }
    }
}
