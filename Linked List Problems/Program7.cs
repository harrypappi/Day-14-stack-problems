// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class LinkedListExample
{
    static void Main(string[] args)
    {
       
        Node node56 = new Node(56);
        Node node30 = new Node(30);
        Node node70 = new Node(70);

        node56.Next = node30;
        node30.Next = node70;

        
        Node foundNode = SearchLinkedList(node56, 30);

        if (foundNode != null)
        {
            Console.WriteLine("Node with value 30 found!");
        }
        else
        {
            Console.WriteLine("Node with value 30 not found!");
        }
    }

    static Node SearchLinkedList(Node head, int searchValue)
    {
        Node current = head;

        while (current != null)
        {
            if (current.Value == searchValue)
            {
                return current;
            }

            current = current.Next;
        }

        return null;
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
