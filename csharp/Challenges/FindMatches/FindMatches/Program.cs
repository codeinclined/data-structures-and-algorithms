using KAryTree;
using StackAndQueue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FindMatches
{
    public class Program
    {
        public static void Main(string[] args)
        {

            KAryTree<char> tree = new KAryTree<char>('A');

            #region Build up the tree with duplicate nodes (2 A, 2 B, 2 C, 3 D)
            tree.Add('A', 'A');
            tree.Add('B', 'A');
            tree.Add('C', 'A');
            tree.Add('B', 'B');
            tree.Add('C', 'B');
            tree.Add('D', 'C');
            tree.Add('D', 'D');
            tree.Add('D', 'B');
            #endregion

            // Find matches for the different values in the tree and place their
            // values into enumerables using LINQ
            IEnumerable<char> matchesA = FindMatches(tree, 'A').Select(m => m.Value);
            IEnumerable<char> matchesB = FindMatches(tree, 'B').Select(m => m.Value);
            IEnumerable<char> matchesC = FindMatches(tree, 'C').Select(m => m.Value);
            IEnumerable<char> matchesD = FindMatches(tree, 'D').Select(m => m.Value);

            Console.WriteLine("Finding all matches for a k-ary tree with duplicate values.");
            Console.WriteLine();

            // Print out the values taken from the nodes returned from FindMatches
            Console.WriteLine($"Expecting 2 A's, found: [{string.Join(", ", matchesA)}]");
            Console.WriteLine($"Expecting 2 B's, found: [{string.Join(", ", matchesB)}]");
            Console.WriteLine($"Expecting 2 C's, found: [{string.Join(", ", matchesC)}]");
            Console.WriteLine($"Expecting 3 D's, found: [{string.Join(", ", matchesD)}]");

            Console.WriteLine();
            Console.WriteLine("Please press any key to exit this demo...");
            Console.ReadKey();
        }

        /// <summary>
        /// For the provided k-ary tree, return all nodes containing the provided searchValue
        /// to the caller in the form of a collection.
        /// </summary>
        /// <typeparam name="T">The type of values held by nodes in the tree</typeparam>
        /// <param name="tree">The tree to perform the search on</param>
        /// <param name="searchValue">The search value to match against node values</param>
        /// <returns>A generic collection of KAryNode references of type T</returns>
        public static ICollection<KAryNode<T>> FindMatches<T>(KAryTree<T> tree, T searchValue)
        {
            MyQueue<KAryNode<T>> nodes = new MyQueue<KAryNode<T>>(tree.Root);
            List<KAryNode<T>> matches = new List<KAryNode<T>>(tree.Count);

            // Breadth-first traversal
            while (nodes.Length > 0)
            {
                KAryNode<T> currentNode = nodes.Dequeue();

                // The current node's value matches the searchValue! Add it to our list
                if (currentNode.Value.Equals(searchValue))
                {
                    matches.Add(currentNode);
                }

                foreach (KAryNode<T> node in currentNode.Children)
                {
                    nodes.Enqueue(node);
                }
            }

            return matches;
        }
    }
}
