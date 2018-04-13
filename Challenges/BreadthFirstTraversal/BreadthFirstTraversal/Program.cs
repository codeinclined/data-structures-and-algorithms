using BinaryTree;
using StackAndQueue;
using System;

namespace BreadthFirstTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            BreadthFirstTraversal(ConstructTestTree());

            Console.WriteLine("\nPlease press any key to exit this program...");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Constructs a test binary tree matching the one provided in the challenge prompt
        /// </summary>
        /// <returns>A new tree with nodes and structure matching the challenge prompt</returns>
        public static Tree<int> ConstructTestTree()
        {
            Tree<int> tree = new Tree<int>(2);

            BinaryTree.Node<int> left = tree.Root.Left = new BinaryTree.Node<int>(7);
            BinaryTree.Node<int> right = tree.Root.Right = new BinaryTree.Node<int>(5);

            BinaryTree.Node<int> leftLeft = left.Left = new BinaryTree.Node<int>(2);
            BinaryTree.Node<int> leftRight = left.Right = new BinaryTree.Node<int>(6);

            BinaryTree.Node<int> leftRightleft = leftRight.Left = new BinaryTree.Node<int>(5);
            BinaryTree.Node<int> leftRightRight = leftRight.Right = new BinaryTree.Node<int>(11);

            BinaryTree.Node<int> rightRight = right.Right = new BinaryTree.Node<int>(9);
            BinaryTree.Node<int> rightRightLeft = rightRight.Left = new BinaryTree.Node<int>(4);

            return tree;
        }

        /// <summary>
        /// Performs breadth first traversal on a binary tree and writes each node's value
        /// in the order of traversal.
        /// </summary>
        /// <typeparam name="T">The type of values held by the provided tree</typeparam>
        /// <param name="tree">A tree with nodes to be traversed in breadth first order</param>
        public static void BreadthFirstTraversal<T>(Tree<T> tree)
        {
            MyQueue<BinaryTree.Node<T>> queue = new MyQueue<BinaryTree.Node<T>>();

            queue.Enqueue(tree.Root);

            while (queue.Length > 0)
            {
                BinaryTree.Node<T> node = queue.Dequeue();
                Console.WriteLine(node.Value);

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
        }
    }
}
