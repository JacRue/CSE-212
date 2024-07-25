using System;
using System.Collections.Generic;

public class StackSolution
{
    public static void Main()
    {
        string input = "Hello, World!";
        string reversed = ReverseString(input);
        Console.WriteLine($"Original: {input}");
        Console.WriteLine($"Reversed: {reversed}");
    }

    public static string ReverseString(string input)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in input)
        {
            stack.Push(c);
        }

        char[] reversedChars = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            reversedChars[i] = stack.Pop();
        }

        return new string(reversedChars);
    }
}