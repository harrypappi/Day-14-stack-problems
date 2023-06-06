﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class LinkedListExample
{
    static void Main(string[] args)
    {
        // Create the nodes
        Node node70 = new Node(70);
        Node node30 = new Node(30);
        Node node56 = new Node(56);

        // Set up the links between nodes
        node56.Next = node30;
        node30.Next = node70;

        // Print the linked list
        PrintLinkedList(node56);
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