using System;

public class LinkedListSolution
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

        public int FindMiddle()
        {
            if (Head == null)
                throw new InvalidOperationException("List is empty");

            Node slow = Head;
            Node fast = Head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow.Data;
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
        list.AddFirst(4);
        list.AddFirst(5);
        list.PrintList();
        Console.WriteLine($"Middle element is: {list.FindMiddle()}");
    }
}