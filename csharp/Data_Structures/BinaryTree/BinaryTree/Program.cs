using System;
using System.Collections.Generic;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The following are examples of traversing a binary tree.");
            Console.WriteLine("The nodes are numbered starting with 1 at the root");
            Console.WriteLine("2 left, 3 left-left, 4 left-right, 5 right, 6 right-left");
            Console.WriteLine("7 right-right, 8 left-left-left, 9 left-left-right.");
            Console.WriteLine();

            // Create the tree and nodes
            Tree<int> tree = new Tree<int>(1);

            Node<int> left = tree.Root.Left = new Node<int>(2);
            Node<int> leftLeft = left.Left = new Node<int>(3);
            Node<int> leftRight = left.Right = new Node<int>(4);

            Node<int> right = tree.Root.Right = new Node<int>(5);
            Node<int> rightLeft = right.Left = new Node<int>(6);
            Node<int> rightRight = right.Right = new Node<int>(7);

            Node<int> leftLeftLeft = leftLeft.Left = new Node<int>(8);
            Node<int> leftLeftRight = leftLeft.Right = new Node<int>(9);

            List<int> values = new List<int>();

            // Show the results of all three traversal types
            values = tree.PreOrderTraversal(tree.Root, values);
            Console.WriteLine("Pre-order Traversal:");
            Console.WriteLine($"[{string.Join(", ", values)}]");
            Console.WriteLine();
            values.Clear();

            values = tree.InOrderTraversal(tree.Root, values);
            Console.WriteLine("In-order Traversal:");
            Console.WriteLine($"[{string.Join(", ", values)}]");
            Console.WriteLine();
            values.Clear();

            values = tree.PostOrderTraversal(tree.Root, values);
            Console.WriteLine("Post-order Traversal:");
            Console.WriteLine($"[{string.Join(", ", values)}]");

            Console.WriteLine();
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
        }
    }
}
