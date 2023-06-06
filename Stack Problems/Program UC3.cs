using System;
using System.Collections.Generic;

class QueueExample
{
    static void Main(string[] args)
    {
        // Create a new queue using a linked list
        LinkedList<int> queue = new LinkedList<int>();

        Enqueue(queue, 56);
        Enqueue(queue, 30);
        Enqueue(queue, 70);
        Console.WriteLine("Queue:");
        PrintQueue(queue);
    }

    static void Enqueue(LinkedList<int> queue, int value)
    {

        queue.AddLast(value);
    }

    static void PrintQueue(LinkedList<int> queue)
    {
        foreach (int element in queue)
        {
            Console.WriteLine(element);
        }
    }
}
