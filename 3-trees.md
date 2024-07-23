# Trees

Welcome to the Trees module. This tutorial will guide you through understanding trees, their benefits, and how to use them in C# programming.

## Introduction
A tree is a hierarchical data structure that consists of nodes, with a single node serving as the root from which all other nodes descend. Each node contains a value and references to child nodes, forming a parent-child relationship.

## Benefits of Trees
- **Hierarchical Structure**: Represents data with a natural hierarchy.
- **Efficient Searching**: Enables fast search, insertion, and deletion operations.
- **Data Organization**: Useful for organizing data such as file systems, databases, and more.

## Using Trees in C#

### Creating a Binary Tree
To create a binary tree in C#, you can define a `Node` class and a `BinaryTree` class.
```csharp
using System;

public class Node
{
    public int Data;
    public Node? Left;
    public Node? Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

public class BinaryTree
{
    public Node? Root;

    public BinaryTree()
    {
        Root = null;
    }

    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node? root, int data)
    {
        if (root == null)
        {
            root = new Node(data);
            return root;
        }

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }
}
Traversing the Tree
In-Order Traversal
csharp
Copy code
public void InOrderTraversal(Node? node)
{
    if (node != null)
    {
        InOrderTraversal(node.Left);
        Console.Write(node.Data + " ");
        InOrderTraversal(node.Right);
    }
}
Example Problem
Problem: Finding the Height of a Binary Tree
Write a function to find the height of a binary tree.

Solution
csharp
Copy code
public int GetHeight(Node? node)
{
    if (node == null)
        return 0;
    else
    {
        int leftHeight = GetHeight(node.Left);
        int rightHeight = GetHeight(node.Right);

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}
Practice Problem for Students
Problem: Finding the Lowest Common Ancestor
Write a function to find the lowest common ancestor (LCA) of two nodes in a binary tree.

Solution Link
--Lowest Common Ancestor Solution--

Conclusion
Trees are a versatile data structure essential for representing hierarchical data and enabling efficient searching and data organization. Practice using trees to enhance your understanding and problem-solving abilities.

--Return to Welcome Page--