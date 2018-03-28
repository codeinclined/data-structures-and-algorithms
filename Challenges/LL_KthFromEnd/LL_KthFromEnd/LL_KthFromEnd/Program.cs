using System;
using SinglyLinkedList;
using static LL_Insertions.Program;

namespace LL_KthFromEnd
{
    public class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList.SinglyLinkedList sll = new SinglyLinkedList.SinglyLinkedList();

            Append(sll, 1);
            Append(sll, 3);
            Append(sll, 8);
            Append(sll, 2);

            PrintLinkedList(sll);

            Console.WriteLine();
            Console.WriteLine(KthFromEnd(sll, 0));

            Console.ReadKey();
        }

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
