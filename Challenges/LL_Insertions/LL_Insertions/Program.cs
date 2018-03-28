using System;
using SinglyLinkedList;

namespace LL_Insertions
{
    public class Program
    {
        /// <summary>
        /// Runs through each example in this challenge's instructions and prints before
        /// and after views to the console
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            SinglyLinkedList.SinglyLinkedList sll = new SinglyLinkedList.SinglyLinkedList();

            // Populate the linked list with the Add method that we already know works
            sll.Add(2);
            sll.Add(3);
            sll.Add(1);

            // Append demos
            Console.WriteLine("First singly linked list before appending:");
            PrintLinkedList(sll);

            Append(sll, 5);

            Console.WriteLine("\nFirst singly linked list after appending 5:");
            PrintLinkedList(sll);

            Console.WriteLine("\nSecond linked list before appending:");
            sll = new SinglyLinkedList.SinglyLinkedList();
            PrintLinkedList(sll);

            Console.WriteLine("\nSecond linked list after appending 1:");
            Append(sll, 1);
            PrintLinkedList(sll);

            Console.WriteLine("\nPlease press any key to demo InsertBefore method...");
            Console.ReadKey();
            Console.Clear();

            // InsertBefore demo
            Console.WriteLine("First singly linked list before inserting:");
            sll = new SinglyLinkedList.SinglyLinkedList();
            sll.Add(2);
            sll.Add(3);
            sll.Add(1);
            PrintLinkedList(sll);

            Console.WriteLine("\nFirst singly linked list after inserting 5 before 3:");
            InsertBefore(sll, 3, 5);
            PrintLinkedList(sll);

            Console.WriteLine("\nSecond singly linked list before inserting:");
            sll = new SinglyLinkedList.SinglyLinkedList();
            sll.Add(2);
            sll.Add(3);
            sll.Add(1);
            PrintLinkedList(sll);

            Console.WriteLine("\nSecond singly linked list after inserting 5 before 1:");
            InsertBefore(sll, 1, 5);
            PrintLinkedList(sll);

            Console.WriteLine("\nPlease press any key continue demo...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Third singly linked list before inserting:");
            sll = new SinglyLinkedList.SinglyLinkedList();
            sll.Add(2);
            sll.Add(2);
            sll.Add(1);
            PrintLinkedList(sll);

            Console.WriteLine("\nThird singly linked list after inserting 5 before 2:");
            InsertBefore(sll, 2, 5);
            PrintLinkedList(sll);

            Console.WriteLine("\nFourth singly linked list before inserting:");
            sll = new SinglyLinkedList.SinglyLinkedList();
            sll.Add(2);
            sll.Add(3);
            sll.Add(1);
            PrintLinkedList(sll);

            Console.WriteLine("\nFourth singly linked list after inserting 5 before 4:");
            try
            {
                InsertBefore(sll, 4, 5);
                PrintLinkedList(sll);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(
                    "...actually, we could not find 4 in the linked list so an exception was thrown");
            }

            Console.WriteLine("\nPlease press any key to continue to the insert after demo...");
            Console.ReadKey();
            Console.Clear();

            // InsertAfter demo
            Console.WriteLine("First singly linked list before inserting:");
            sll = new SinglyLinkedList.SinglyLinkedList();
            sll.Add(2);
            sll.Add(3);
            sll.Add(1);
            PrintLinkedList(sll);

            Console.WriteLine("\nFirst singly linked list after inserting 5 after 3:");
            InsertAfter(sll, 3, 5);
            PrintLinkedList(sll);

            Console.WriteLine("\nSecond singly linked list before inserting:");
            sll = new SinglyLinkedList.SinglyLinkedList();
            sll.Add(2);
            sll.Add(3);
            sll.Add(1);
            PrintLinkedList(sll);

            Console.WriteLine("\nSecond singly linked list after inserting 5 after 2:");
            InsertAfter(sll, 2, 5);
            PrintLinkedList(sll);

            Console.WriteLine("\nPlease press any key continue demo...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Third singly linked list before inserting:");
            sll = new SinglyLinkedList.SinglyLinkedList();
            sll.Add(2);
            sll.Add(2);
            sll.Add(1);
            PrintLinkedList(sll);

            Console.WriteLine("\nThird singly linked list after inserting 5 after 2:");
            InsertAfter(sll, 2, 5);
            PrintLinkedList(sll);

            Console.WriteLine("\nFourth singly linked list before inserting:");
            sll = new SinglyLinkedList.SinglyLinkedList();
            sll.Add(2);
            sll.Add(3);
            sll.Add(1);
            PrintLinkedList(sll);

            Console.WriteLine("\nFourth singly linked list after inserting 5 after 4:");
            try
            {
                InsertAfter(sll, 4, 5);
                PrintLinkedList(sll);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(
                    "...actually, we could not find 4 in the linked list so an exception was thrown");
            }

            Console.WriteLine("\nPlease press any key to exit this program...");
            Console.ReadKey();
        }

        /// <summary>
        /// Utility method to pretty print all of a linked list's contents to the console
        /// </summary>
        /// <param name="sll">The linked list to print to console</param>
        public static void PrintLinkedList(SinglyLinkedList.SinglyLinkedList sll)
        {
            Console.Write("head -> ");

            Node currentNode = sll.Head;

            while (currentNode != null)
            {
                Console.Write($"[{currentNode.Value}] -> ");
                currentNode = currentNode.Next;
            }

            Console.WriteLine("X");
        }

        /// <summary>
        /// Appends value to the end of this linked list
        /// </summary>
        /// <param name="singlyLinkedList">The singly linked list to modify</param>
        /// <param name="value">The value to append as a node to the linked list</param>
        /// <returns>The new node</returns>
        public static Node Append(SinglyLinkedList.SinglyLinkedList sll, int value)
        {
            // If the linked list is empty than just set head to a new Node object containing value
            if (sll.Head == null)
            {
                return sll.Head = new Node(value);
            }

            Node currentNode = sll.Head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            return currentNode.Next = new Node(value);
        }

        /// <summary>
        /// Insert a new node containing newValue before the node containing value already within the linked list
        /// </summary>
        /// <param name="singlyLinkedList">The singly linked list to modify</param>
        /// <param name="value">The value of the node that the new node will be inserted before</param>
        /// <param name="newValue">The value that the new node will contain</param>
        /// <returns>A reference to the newly inserted node</returns>
        /// <exception cref="ArgumentException">value could not be found within the linked list</exception>
        public static Node InsertBefore(SinglyLinkedList.SinglyLinkedList sll, int value, int newValue)
        {
            if (sll.Head == null)
            {
                throw new ArgumentException("Could not find value within linked list", nameof(value));
            }
            // If the head is value, then the Add method will do the same thing as this method would
            if (sll.Head.Value == value)
            {
                return sll.Add(newValue);
            }

            Node currentNode = sll.Head;

            while (currentNode.Next != null)
            {
                if (currentNode.Next.Value == value)
                {
                    Node newNode = new Node(newValue, currentNode.Next);
                    currentNode.Next = newNode;
                    return newNode;
                }

                currentNode = currentNode.Next;
            }

            throw new ArgumentException("Could not find value within linked list", nameof(value));
        }

        /// <summary>
        /// Insert a new node containing newValue after the node containing value already within the linked list.
        /// </summary>
        /// <param name="singlyLinkedList">The singly linked list to modify</param>
        /// <param name="value">The value of the node that the new node will be inserted before</param>
        /// <param name="newValue">The value that the new node will contain</param>
        /// <returns>A reference to the newly inserted node</returns>
        /// <exception cref="ArgumentException">value could not be found within the linked list</exception>
        public static Node InsertAfter(SinglyLinkedList.SinglyLinkedList sll, int value, int newValue)
        {
            if (sll.Head == null)
            {
                throw new ArgumentException("Could not find value within linked list", nameof(value));
            }

            Node currentNode = sll.Head;

            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    Node newNode = new Node(newValue, currentNode.Next);
                    currentNode.Next = newNode;
                    return newNode;
                }

                currentNode = currentNode.Next;
            }

            throw new ArgumentException("Could not find value within linked list", nameof(value));
        }
    }
}
