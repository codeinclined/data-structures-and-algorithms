# Identify a Circular Reference

Linked lists and data structures related to them in principal can end up with
circular references among nodes due to logic errors within the data structures'
code or misuse of node objects by consumers of the linked lists. This challenge
involves identifying these loops without resorting to O(n) space requirements.

## Challenge

- Write a method for the Linked List class called hasLoop which takes no
arguments.
- Return a boolean that indicates whether or not a circular reference or loop
is present in the linked list.
- Your implementation must not use any additional memory or modify the nodes of
the linked list.
- You have access to the Node class and all the standard properties on the
Linked List class as well as the methods created in previous challenges.

### Examples

     Input: head -> [1]-> [3]-> [2]-> X
    Output: false

     Input: head -> [1]-> [7]-> [2]
                           ^     v
                          [5] <-[3]
    Output: true

## Solution

![Whiteboard Solution Photo](/assets/LL_FindLoop.jpg)
