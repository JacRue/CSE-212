using System;
using System.Collections.Generic;

public class StackProblem
{
    public static void Main()
    {
        string expression = "(1+2)*(3/4)";
        bool result = AreParenthesesBalanced(expression);
        Console.WriteLine($"Are parentheses balanced in '{expression}'? {result}");
    }

    public static bool AreParenthesesBalanced(string expression)
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
}