# Level-Order Printout of a K-ary Tree

This challenge involves producing a string representation of the node values
contained within a K-ary tree (also known as an n-tree) delimited by newlines
at the end of each row of values.

This was accomplished iteratively in the included C# solution using a
breadth-first traversal. Instead of using a single queue of nodes to
traverse as is typical for breadth-first traversal, two queues are used
to hold both the next row of nodes as well as the current row's node values.
The end of a row is signified by the value queue's length surpassing a
variable which holds the length of that row.

The first row starts with a width of one node (the root of the tree). All
of the root node's children should have been enqueued to the node queue,
meaning that the length of the node queue is equal to the width of the
next row. This process is repeated for each row of the tree.

## Challenge

- [X] Write a function which takes in a k-ary tree.
- [X] Without utilizing any of the built-in methods available to your language, return a string that contains a listing of all values in the tree, with new lines in-between each level of the tree.

## Solution

_Note: The below example uses a recursive approach to the problem and should
be reported as O(n^2) for space. The algorithm implemented in the C# solution
was done iteratively and achieves O(n) for time and space complexity._

![Whiteboard Solution Photo](/assets/PrintLevelOrder.jpg)
