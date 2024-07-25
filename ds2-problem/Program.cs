using System;

public class LinkedListProblem
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

        public void Reverse()
        {
            Node? prev = null;
            Node? current = Head;
            Node? next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            Head = prev;
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
        list.Reverse();
        list.PrintList();
    }
}