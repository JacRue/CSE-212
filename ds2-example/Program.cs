using System;

public class LinkedListExample
{
    public class Node
    {
        public int Data;
        public Node? Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        public Node? Head;

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = Head;
            Head = newNode;
        }

        public void PrintList()
        {
            Node? current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
        }
    }

    public static void Main()
    {
        LinkedList list = new LinkedList();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.PrintList();
    }
}