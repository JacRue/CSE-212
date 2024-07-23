# Stacks

Welcome to the Stacks module. This tutorial will guide you through understanding stacks, their benefits, and how to use them in C# programming.

## Introduction
A stack is a linear data structure that follows the Last In First Out (LIFO) principle. Elements are added (pushed) and removed (popped) from the same end called the "top."

## Benefits of Stacks
- **LIFO Structure**: Ideal for problems that require reverse order processing.
- **Memory Management**: Helps manage function calls and recursion.
- **Backtracking**: Useful in scenarios like undo mechanisms in text editors.

## Using Stacks in C#

### Creating a Stack
To create a stack in C#, use the `Stack<T>` class from the `System.Collections.Generic` namespace.
```csharp
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
    }
}
Pushing and Popping Elements
csharp
Copy code
stack.Push(4); // Adding an element to the stack
Console.WriteLine("Popped element is: " + stack.Pop()); // Removing and returning the top element
Checking Stack Size
csharp
Copy code
Console.WriteLine("Stack size is: " + stack.Count);
Example Problem
Problem: Balancing Parentheses
Given an expression string, write a function to check if parentheses are balanced using a stack.

Solution
csharp
Copy code
public bool AreParenthesesBalanced(string expression)
{
    Stack<char> stack = new Stack<char>();
    
    foreach (char c in expression)
    {
        if (c == '(')
        {
            stack.Push(c);
        }
        else if (c == ')')
        {
            if (stack.Count == 0 || stack.Pop() != '(')
            {
                return false;
            }
        }
    }
    
    return stack.Count == 0;
}
Practice Problem for Students
Problem: Reverse a String Using a Stack
Write a function to reverse a string using a stack.

Solution Link
--Reverse String Solution--

Conclusion
Stacks are a versatile data structure useful in many scenarios like function call management, backtracking, and parsing expressions. Practice using stacks to strengthen your understanding and ability to solve problems efficiently.

--Return to Welcome Page--