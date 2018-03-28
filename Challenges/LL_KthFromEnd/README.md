# Kth From The End of a Linked List

This challenge involves the case in which the user would like to find the value
that is some distance (k) away from the end of a linked list. With linked lists,
we do not have random access capability to our nodes, nor do we know the length 
of the data structure unless we iterate through each of the nodes. As such,
the algorithm chosen to complete this challenge is broken into two primary
steps. First, we iterate through the entire linked list, incrementing a counter
variable to keep track of how many nodes our linked list contains. Next, we
traverse the linked list again, stopping k many nodes before reaching the end
of the linked list that we found in the first step.

## Challenge

Write a method for the Linked List class called kthFromEnd which takes a number,
k, as an argument. Return the node that is k from the end of the linked list.
You have access to the Node class and all the properties on the Linked List
class as well as the methods created in previous challenges. ​

### Examples

    Input                                Args   Output
    head -> [1]-> [3]-> [8]-> [2]-> X    0      [2]->
    head -> [1]-> [3]-> [8]-> [2]-> X    2      [3]->
    head -> [1]-> [3]-> [8]-> [2]-> X    6      Exception

## Solution

![Whiteboard Solution Photo](/assets/LL_KthFromEnd.jpg)
