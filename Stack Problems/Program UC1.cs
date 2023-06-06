// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

public class StackExample
{
    private LinkedList<int> stack;

    public StackExample()
    {
        stack = new LinkedList<int>();
    }

    public void Push(int value)
    {
        stack.AddFirst(value);
    }

    public int Pop()
    {
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        int topValue = stack.First.Value;
        stack.RemoveFirst();
        return topValue;
    }

    public int Peek()
    {
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return stack.First.Value;
    }

    public bool IsEmpty()
    {
        return stack.Count == 0;
    }

    public void PrintStack()
    {
        foreach (int value in stack)
        {
            Console.Write($"{value} -> ");
        }
        Console.WriteLine("null");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        StackExample stack = new StackExample();

        stack.Push(70);
        stack.Push(30);
        stack.Push(56);

        stack.PrintStack();

        int topValue = stack.Pop();
        Console.WriteLine($"Popped value: {topValue}");

        int peekValue = stack.Peek();
        Console.WriteLine($"Peeked value: {peekValue}");

        stack.PrintStack();
    }
}
