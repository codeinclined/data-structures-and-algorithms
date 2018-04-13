# Breadth-First

This challenge involves a breadth-first traversal of a binary tree using an
algorithm which takes in a single binary tree as its only input. The value held
by each node is displayed to the console in the order that they are reached in
traversal. This algorithm utilizes an iterative approach by enqueueing the
left and right children of the node at the front of the queue (after
dequeueing that node). This only occurs if those left and right references
are not currently occupied. Once the queue is empty, the loop is broken and
the algorithm returns to the caller.

## Challenge

- Write a function called breadthFirstTraversal which takes a Binary Tree as its
unique input. Without utilizing any of the built-in methods available to your
language, traverse the input tree using a Breadth-first approach; print every
visited node’s value.

## Solution

![Whiteboard Solution Photo](/assets/BreadthFirstTraversal.jpg)
