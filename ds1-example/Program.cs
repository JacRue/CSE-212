using System;
using System.Collections.Generic;

public class StackExample
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        
        Console.WriteLine("Top element is: " + stack.Peek());
        
        stack.Push(4); // Adding an element to the stack
        Console.WriteLine("Popped element is: " + stack.Pop()); // Removing and returning the top element
        Console.WriteLine("Stack size is: " + stack.Count);
    }
}