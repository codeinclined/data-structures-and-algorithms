# Merge Two Linked Lists

This challenge involves merging two linked lists into a new linked list which
has nodes alternating from the two source lists. This is simliar to zipping
two arrays in concept, but this algorithm involves linked lists and does
not create tuples. The defined algorithm operates in O(n) time and requires
O(1) for space.

## Challenge

- Write a function called mergeLists which takes two linked lists as arguments.
Zip the two linked lists together into one so that the nodes alternate between
the two lists and return a reference to the head of the single list.
- Try and keep additional space down to O(1).
- You have access to the Node class and all the properties on the Linked List
class as well as the methods created in previous challenges.

### Examples

    Inputs: head -> [1]-> [3]-> [2]-> X,     head -> [5]-> [9]-> [4]-> X 
    Output: head -> [1]-> [5]-> [3]-> [9]-> [2]-> [4]-> X

    Inputs: head -> [1]-> [3]-> X,     head -> [5]-> [9]-> [4]-> X 
    Output: head -> [1]-> [5]-> [3]-> [9]-> [4]-> X

    Inputs: head -> [1]-> [3]-> [2]-> X,     head -> [5]-> [9]-> X 
    Output: head -> [1]-> [5]-> [3]-> [9]-> [2]-> X

## Solution

![Whiteboard Solution Photo](/assets/LL_Merge.jpg)
