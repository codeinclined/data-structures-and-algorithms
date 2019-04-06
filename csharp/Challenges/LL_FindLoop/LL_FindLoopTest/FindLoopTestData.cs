using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SinglyLinkedList;
using static LL_Insertions.Program;

namespace LL_FindLoopTest
{
    class FindLoopTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // No loop, simple linked list from challenge instructions' examples
            SinglyLinkedList.SinglyLinkedList sll = new SinglyLinkedList.SinglyLinkedList();
            Append(sll, 1);
            Append(sll, 3);
            Append(sll, 2);

            yield return new object[] { sll, false };

            // Looped linked list from challenge instructions' examples
            sll = new SinglyLinkedList.SinglyLinkedList();
            Append(sll, 1);
            Node loopee = Append(sll, 7);
            Append(sll, 2);
            Append(sll, 3);
            Node looper = Append(sll, 5);
            looper.Next = loopee;

            yield return new object[] { sll, true };

            // Looped linked list with the loop occurring between head
            // and the last added node
            sll = new SinglyLinkedList.SinglyLinkedList();
            loopee = Append(sll, 9);
            Append(sll, 3);
            Append(sll, 4);
            Append(sll, 8);
            looper = Append(sll, 14);
            looper.Next = loopee;

            yield return new object[] { sll, true };

            // Unlooped, simple, one-item linked list
            sll = new SinglyLinkedList.SinglyLinkedList();
            Append(sll, 19);

            yield return new object[] { sll, false };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
