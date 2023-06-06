// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class LinkedListExample
{
    static void Main(string[] args)
    {
        
        Node node1 = new Node(56);
        Node node2 = new Node(30);
        Node node3 = new Node(70);

   
        node1.Next = node2;
        node2.Next = node3;
        PrintLinkedList(node1);
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

