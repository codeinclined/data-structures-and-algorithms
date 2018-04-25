using System;

namespace KAryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("K-ary Tree Demonstration");
            Console.WriteLine("Operations followed by breadth-first traversal results:");
            Console.WriteLine();

            // Instantiate tree
            KAryTree<int> tree = new KAryTree<int>(5);
            string bftString = $"[{string.Join(", ", tree.BreadthFirstTraversal())}]";
            Console.WriteLine($"new KAryTree<int>(5)                    : {bftString}");

            // Adding a new node
            tree.Add(newValue: 10, parentValue: 5);
            bftString = $"[{string.Join(", ", tree.BreadthFirstTraversal())}]";
            Console.WriteLine($"tree.Add(newValue: 10, parentValue: 5)  : {bftString}");

            // Adding another new node
            tree.Add(newValue: 15, parentValue: 5);
            bftString = $"[{string.Join(", ", tree.BreadthFirstTraversal())}]";
            Console.WriteLine($"tree.Add(newValue: 15, parentValue: 5)  : {bftString}");

            // Adding another new node
            tree.Add(newValue: 20, parentValue: 10);
            bftString = $"[{string.Join(", ", tree.BreadthFirstTraversal())}]";
            Console.WriteLine($"tree.Add(newValue: 20, parentValue: 10) : {bftString}");

            // Adding another new node
            tree.Add(newValue: 15, parentValue: 10);
            bftString = $"[{string.Join(", ", tree.BreadthFirstTraversal())}]";
            Console.WriteLine($"tree.Add(newValue: 15, parentValue: 10) : {bftString}");

            // Adding another new node
            tree.Add(newValue: 25, parentValue: 20);
            bftString = $"[{string.Join(", ", tree.BreadthFirstTraversal())}]";
            Console.WriteLine($"tree.Add(newValue: 25, parentValue: 20) : {bftString}");

            // Adding another new node (showing BFT since there are two nodes with value 15)
            tree.Add(newValue: 30, parentValue: 15);
            bftString = $"[{string.Join(", ", tree.BreadthFirstTraversal())}]";
            Console.WriteLine($"tree.Add(newValue: 30, parentValue: 15) : {bftString}");

            Console.WriteLine();
            Console.WriteLine("Please press any key to exit this program...");
            Console.ReadKey();
        }
    }
}
