using System;
using SinglyLinkedList;
using static LL_Insertions.Program;

namespace LL_Merge
{
    public class Program
    {
        static void Main(string[] args)
        {
            // First merging demo
            Console.WriteLine("First Merge Demo:\n");
            DisplayLinkedListDemo(new int[] { 1, 3, 2 }, new int[] { 5, 9, 4 });
            Console.WriteLine("\nPlease press any key to continue to next demo...");
            Console.ReadKey();

            // Second merging demo
            Console.WriteLine("\nSecond Merge Demo:\n");
            DisplayLinkedListDemo(new int[] { 1, 3 }, new int[] { 5, 9, 4 });
            Console.WriteLine("\nPlease press any key to continue to next demo...");
            Console.ReadKey();

            // Third merging demo
            Console.WriteLine("\nThird Merge Demo:\n");
            DisplayLinkedListDemo(new int[] { 1, 3, 2 }, new int[] { 5, 9 });
            Console.WriteLine("\nPlease press any key to continue to next demo...");
            Console.ReadKey();
        }

        static void DisplayLinkedListDemo(int[] itemsA, int[] itemsB)
        {
            SinglyLinkedList.SinglyLinkedList listA = new SinglyLinkedList.SinglyLinkedList();
            foreach (int item in itemsA)
            {
                Append(listA, item);
            }

            Console.WriteLine("Linked List A:");
            PrintLinkedList(listA);

            SinglyLinkedList.SinglyLinkedList listB = new SinglyLinkedList.SinglyLinkedList();
            foreach (int item in itemsB)
            {
                Append(listB, item);
            }

            Console.WriteLine("Linked List B:");
            PrintLinkedList(listB);

            SinglyLinkedList.SinglyLinkedList mergedList = new SinglyLinkedList.SinglyLinkedList();
            mergedList.Head = MergeLists(listA, listB);

            Console.WriteLine("Merged (alternating) Linked List:");
            PrintLinkedList(mergedList);
        }

        public static Node MergeLists(SinglyLinkedList.SinglyLinkedList listA,
            SinglyLinkedList.SinglyLinkedList listB)
        {
            Node curNodeA = listA.Head;
            Node curNodeB = listB.Head;
            Node tempNode;

            while (curNodeA != null && curNodeB != null)
            {
                tempNode = curNodeB.Next;

                if (curNodeA.Next == null)
                {
                    curNodeA.Next = curNodeB;
                    break;
                }

                curNodeB.Next = curNodeA.Next;
                curNodeA.Next = curNodeB;

                curNodeA = curNodeB.Next;
                curNodeB = tempNode;
            }

            return listA.Head;// == null ? listA.Head;
        }
    }
}
