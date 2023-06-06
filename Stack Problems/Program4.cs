using System;
using System.Collections.Generic;

class QueueExample
{
    static void Main(string[] args)
    {
        LinkedList<int> queue = new LinkedList<int>();

        Enqueue(queue, 56);
        Enqueue(queue, 30);
        Enqueue(queue, 70);

        Console.WriteLine("Initial Queue:");
        PrintQueue(queue);

     
        while (queue.Count > 0)
        {
            int dequeuedElement = Dequeue(queue);
            Console.WriteLine("Dequeued: " + dequeuedElement);
        }

        Console.WriteLine("Final Queue:");
        PrintQueue(queue);
    }

    static void Enqueue(LinkedList<int> queue, int value)
    {
        queue.AddLast(value);
    }

    static int Dequeue(LinkedList<int> queue)
    {
    
        int dequeuedValue = queue.First.Value;

        queue.RemoveFirst();
        return dequeuedValue;
    }

    static void PrintQueue(LinkedList<int> queue)
    {
        foreach (int element in queue)
        {
            Console.WriteLine(element);
        }
    }
}
