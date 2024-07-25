using System;

public class TreeSolution
{
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

        public bool IsBalanced(Node? node)
        {
            if (node == null)
                return true;

            int leftHeight = GetHeight(node.Left);
            int rightHeight = GetHeight(node.Right);

            if (Math.Abs(leftHeight - rightHeight) <= 1 &&
                IsBalanced(node.Left) &&
                IsBalanced(node.Right))
                return true;

            return false;
        }
    }

    public static void Main()
    {
        BinaryTree tree = new BinaryTree();
        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(70);
        tree.Insert(60);
        tree.Insert(80);

        int height = tree.GetHeight(tree.Root);
        bool isBalanced = tree.IsBalanced(tree.Root);

        Console.WriteLine($"Height of the tree is: {height}");
        Console.WriteLine($"Is the tree balanced? {isBalanced}");
    }
}
