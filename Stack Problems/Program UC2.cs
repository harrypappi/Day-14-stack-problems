using System;
using System.Collections.Generic;

class StackExample
{
    static void Main(string[] args)
    {

        LinkedList<int> stack = new LinkedList<int>();

        stack.AddLast(56);
        stack.AddLast(30);
        stack.AddLast(70);

        Console.WriteLine("Initial Stack:");
        PrintStack(stack);

        while (stack.Count > 0)
        {
            int poppedElement = stack.Last.Value;
            stack.RemoveLast();
            Console.WriteLine("Popped: " + poppedElement);
        }

        Console.WriteLine("Final Stack:");
        PrintStack(stack);
    }

    static void PrintStack(LinkedList<int> stack)
    {
        foreach (int element in stack)
        {
            Console.WriteLine(element);
        }
    }
}
