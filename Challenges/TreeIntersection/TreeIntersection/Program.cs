using BinaryTree;
using HashTables;
using System.Collections.Generic;
using System;
using StackAndQueue;

namespace TreeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> treeA = new Tree<int>(150);
            #region Populate treeA with nodes per this challenge's examples
            {
                BinaryTree.Node<int> left = treeA.Root.Left = new BinaryTree.Node<int>(100);
                BinaryTree.Node<int> leftLeft = left.Left = new BinaryTree.Node<int>(75);
                BinaryTree.Node<int> leftRight = left.Right = new BinaryTree.Node<int>(160);
                BinaryTree.Node<int> leftRightLeft = leftRight.Left = new BinaryTree.Node<int>(125);
                BinaryTree.Node<int> leftRightRight = leftRight.Right = new BinaryTree.Node<int>(175);

                BinaryTree.Node<int> right = treeA.Root.Right = new BinaryTree.Node<int>(250);
                BinaryTree.Node<int> rightLeft = right.Left = new BinaryTree.Node<int>(200);
                BinaryTree.Node<int> rightRight = right.Right = new BinaryTree.Node<int>(350);
                BinaryTree.Node<int> rightRightLeft = rightRight.Left = new BinaryTree.Node<int>(300);
                BinaryTree.Node<int> rightRightRight = rightRight.Right = new BinaryTree.Node<int>(500);
            }
            #endregion

            Console.WriteLine("Tree A in-order traversal values:");
            Console.WriteLine($"[{string.Join(", ", treeA.InOrderTraversal(treeA.Root, new List<int>()))}]");

            Tree<int> treeB = new Tree<int>(42);
            #region Populate treeB with nodes per this challenge's examples
            {
                BinaryTree.Node<int> left = treeB.Root.Left = new BinaryTree.Node<int>(100);
                BinaryTree.Node<int> leftLeft = left.Left = new BinaryTree.Node<int>(15);
                BinaryTree.Node<int> leftRight = left.Right = new BinaryTree.Node<int>(160);
                BinaryTree.Node<int> leftRightLeft = leftRight.Left = new BinaryTree.Node<int>(125);
                BinaryTree.Node<int> leftRightRight = leftRight.Right = new BinaryTree.Node<int>(175);

                BinaryTree.Node<int> right = treeB.Root.Right = new BinaryTree.Node<int>(600);
                BinaryTree.Node<int> rightLeft = right.Left = new BinaryTree.Node<int>(200);
                BinaryTree.Node<int> rightRight = right.Right = new BinaryTree.Node<int>(350);
                BinaryTree.Node<int> rightRightLeft = rightRight.Left = new BinaryTree.Node<int>(4);
                BinaryTree.Node<int> rightRightRight = rightRight.Right = new BinaryTree.Node<int>(500);
            }
            #endregion

            Console.WriteLine();
            Console.WriteLine("Tree B in-order traversal values:");
            Console.WriteLine($"[{string.Join(", ", treeB.InOrderTraversal(treeB.Root, new List<int>()))}]");

            Console.WriteLine();
            Console.WriteLine("Set intersection of node values contained by trees A & B:");
            Console.WriteLine($"[{string.Join(", ", TreeIntersection(treeA, treeB))}]");

            Console.WriteLine();
            Console.WriteLine("Please press any key to exit this demonstration...");
            Console.ReadKey();
        }

        /// <summary>
        /// Returns the set of values contained by both treeA and treeB.
        /// </summary>
        /// <typeparam name="T">The type of values held by the binary trees and the returned set</typeparam>
        /// <param name="treeA">The first binary tree</param>
        /// <param name="treeB">The second binary tree</param>
        /// <returns>Set of values contained by both trees as a collection</returns>
        public static ICollection<T> TreeIntersection<T>(Tree<T> treeA, Tree<T> treeB)
        {
            HashTable<T, int> hashTable = new HashTable<T, int>();
            MyQueue<BinaryTree.Node<T>> nodeQueue = new MyQueue<BinaryTree.Node<T>>(treeA.Root);
            // Holds the intersection set of values to be returned to the caller
            List<T> intersectionSet = new List<T>();

            // Breadth-first traversal of treeA, adding each node's value to the hash table
            while (nodeQueue.Length > 0)
            {
                BinaryTree.Node<T> currentNode = nodeQueue.Dequeue();

                // HashTable's indexer will either add a new node or set the existing node's
                // value by index (i.e. no duplicate nodes should result from this)
                hashTable[currentNode.Value] = 0;

                if (currentNode.Left != null)
                {
                    nodeQueue.Enqueue(currentNode.Left);
                }
                if (currentNode.Left != null)
                {
                    nodeQueue.Enqueue(currentNode.Right);
                }
            }

            // Enqueue the root of treeB to start our traversal of the second tree
            nodeQueue.Enqueue(treeB.Root);

            // Breadth-first traversal of treeB. Will add values to intersectionSet
            // that are contained by both trees only once to fit the return value
            // being defined as a set.
            while (nodeQueue.Length > 0)
            {
                BinaryTree.Node<T> currentNode = nodeQueue.Dequeue();

                // Since the output is meant to be a set of values that appear in
                // both trees, ensure that these values only appear once in the
                // returned set by incrementing their hash tree values
                if (hashTable.Contains(currentNode.Value).found &&
                    hashTable[currentNode.Value]++ == 0)
                {
                    intersectionSet.Add(currentNode.Value);
                }

                if (currentNode.Left != null)
                {
                    nodeQueue.Enqueue(currentNode.Left);
                }
                if (currentNode.Left != null)
                {
                    nodeQueue.Enqueue(currentNode.Right);
                }
            }

            return intersectionSet;
        }
    }
}
