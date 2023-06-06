// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

class LinkedListExample
{
    static void Main(string[] args)
    {
        // Create the nodes
        Node node56 = new Node(56);
        Node node30 = new Node(30);
        Node node70 = new Node(70);

        // Set up the links between nodes
        node56.Next = node30;
        node30.Next = node70;

        // Print the initial linked list
        Console.WriteLine("Initial Linked List:");
        PrintLinkedList(node56);

        // Delete the first element
        Node newHead = Pop(node56);

        
        Console.WriteLine("Modified Linked List:");
        PrintLinkedList(newHead);
    }

    static Node Pop(Node head)
    {
       
        if (head == null)
        {
            return null;
        }

        
        Node newHead = head.Next;

       
        head.Next = null;

        return newHead;
    }

    static void PrintLinkedList(Node head)
    {
        Node current = head;

        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}

class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}
