using System;
using SinglyLinkedList;
using static LL_Insertions.Program;

namespace LL_KthFromEnd
{
    public class Program
    {
        /// <summary>
        /// Entry-point to our program. Displays the example linked list from this challenge's
        /// instructions as well as the results we are getting from our algorithm.
        /// </summary>
        /// <param name="args">Command line arguments to our program</param>
        static void Main(string[] args)
        {
            // Set up the linked list
            SinglyLinkedList.SinglyLinkedList sll = new SinglyLinkedList.SinglyLinkedList();

            Append(sll, 1);
            Append(sll, 3);
            Append(sll, 8);
            Append(sll, 2);

            Console.WriteLine("Singly Linked List Contents:");
            PrintLinkedList(sll);

            Console.WriteLine($"\nKthFromEnd with k=0 for linked list: [{KthFromEnd(sll, 0)}]->");
            Console.WriteLine($"\nKthFromEnd with k=2 for linked list: [{KthFromEnd(sll, 2)}]->");

            try
            {
                Console.WriteLine($"\nKthFromEnd with k=0 for linked list: [{KthFromEnd(sll, 6)}]->");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("\nCould not find KthFromEnd with k=6 (not enough nodes): Exception");
            }

            Console.WriteLine("Please press any key to exit this program...");
            Console.ReadKey();
        }

        /// <summary>
        /// Find the value of the node that is k positions away from the end of the
        /// linked list. Throws an exception if k exceeds the length of the linked list
        /// </summary>
        /// <param name="sll">The linked list we are operating on</param>
        /// <param name="k">The offset we are looking for from the end of the linked list</param>
        /// <returns>The value of the node k positions away from the end of the linked list</returns>
        /// <exception cref="ArgumentOutOfRangeException">k exceeded the length of the linked list</exception>
        public static int KthFromEnd(SinglyLinkedList.SinglyLinkedList sll, int k)
        {
            int counter = 0;
            Node currentNode = sll.Head;

            // Count the number of nodes currently in the linked list
            while (currentNode != null)
            {
                currentNode = currentNode.Next;
                counter++;
            }

            // Make sure we have a long enough linked list to iterate to n-k on
            if (k > counter)
            {
                throw new ArgumentOutOfRangeException(
                    "Provided k value exceeds bounds of the linked list", nameof(k));
            }

            // Iterate again through the linked list k fewer times, decrementing
            // the counter until it reaches 1 (to account for the last iteration above)
            counter -= k;
            currentNode = sll.Head;

            while (counter > 1)
            {
                currentNode = currentNode.Next;
                counter--;
            }

            return currentNode.Value;
        }
    }
}
