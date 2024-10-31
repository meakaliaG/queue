
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

        Console.WriteLine("Print Queue:");
        while (printQueue.Count > 0)
        {
            Console.WriteLine($"Printing: {printQueue.Dequeue()}");
        }

        // Browser History
        Stack<string> browserHistory = new Stack<string>();

        // Visit pages
        string userInput = Console.ReadLine();
        browserHistory.Push(userInput);

        browserHistory.Push("Page1");
        browserHistory.Push("Page2");
        browserHistory.Push("Page3");

        Console.WriteLine("\nBrowser History:");
        while (browserHistory.Count > 0)
        {
            Console.WriteLine($"Going back to: {browserHistory.Pop()}");
        }
    }
}