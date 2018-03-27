# Singly Linked List

A singly linked list provides a data structure which can grow
continuously by adding new Node objects containing values as well
as references to the next node in line.

## Operation

Create a new singly linked list by instantiating the SinglyLinkedList
class within the SinglyLinkedList namespace:

    SinglyLinkedList singlyLinkedList = new SinglyLinkedList();

This new singly linked list object represents an empty linked list
data structure. We can add nodes to the front of it by calling its
Add method with the value we would like the new node to contain:

    singlyLinkedList.Add(7)

Add will return a reference to the newly added Node object. We can
also find this new node along with any previously added nodes by
calling the Find method with the value we would like to search for.

    singlyLinkedList.Find(7)

Note that this method will either return the *first* node containing
that value or null if that value cannot be found among any of the
nodes in the linked list.

## Complexity

### Add
Add has a time and space complexity of O(1)

### Find
Find has a time complexity of O(n) and a space complexity of O(1)

## Changelog
- 3.26.2018 Joshua Taylor - Initial commit of data structure. All tests passing.