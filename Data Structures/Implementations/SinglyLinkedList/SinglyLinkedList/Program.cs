using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();

            Console.WriteLine("Adding 5 node to singlyLinkedList");
            singlyLinkedList.Add(5);

            // Test whether we have added a new node and can find it
            if (singlyLinkedList.Find(5) is null)
            {
                Console.WriteLine("Could not find new 5 node in linked list!");
            }
            else
            {
                Console.WriteLine("Found new 5 node in linked list!");
            }

            Console.WriteLine("Adding 7 node to singlyLinkedList");
            singlyLinkedList.Add(7);

            // Make sure we can add yet another node and that Head now points to another node
            if (singlyLinkedList.Find(7) is null || singlyLinkedList.Head.Next is null)
            {
                Console.WriteLine("Was not able to add the 7 node to the linked list.");
            }
            else
            {
                Console.WriteLine("Successfully added the 7 node to the linked list and its next");
                Console.WriteLine("points to the previous Head.");
            }

            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
        }
    }
}
