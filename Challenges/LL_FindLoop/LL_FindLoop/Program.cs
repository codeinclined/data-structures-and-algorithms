using System;
using SinglyLinkedList;
using static LL_Insertions.Program;

namespace LL_FindLoop
{
    public class Program
    {
        /// <summary>
        /// Entry point for the linked list loop testing demo
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            // Set up first linked list demo
            SinglyLinkedList.SinglyLinkedList sll = new SinglyLinkedList.SinglyLinkedList();
            Append(sll, 1);
            Append(sll, 3);
            Append(sll, 2);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("First Input Linked List");
            Console.ForegroundColor = ConsoleColor.White;
            PrintLinkedList(sll);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"HasLoop() result: {HasLoop(sll)}");

            // Set up second linked list demo
            sll = new SinglyLinkedList.SinglyLinkedList();
            Append(sll, 1);
            Node loopee = Append(sll, 7);
            Append(sll, 2);
            Append(sll, 3);
            Node looper = Append(sll, 5);
            looper.Next = loopee;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nSecond Input Linked List");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("head -> [1]-> [7]-> [2]");
            Console.WriteLine("               ^     v");
            Console.WriteLine("              [5] <-[3]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"HasLoop() result: {HasLoop(sll)}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPlease press any key to exit this program...");
            Console.ReadKey();
        }

        /// <summary>
        /// Discovers loops within a linked list
        /// </summary>
        /// <param name="sll">A singly linked list to test for loops within</param>
        /// <returns>True when a loop exists; false otherwise</returns>
        static public bool HasLoop(SinglyLinkedList.SinglyLinkedList sll)
        {
            int counter = 0;
            Node currentNode = sll.Head;

            while (currentNode != null)
            {
                if (counter++ > sll.Length)
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }
    }
}
