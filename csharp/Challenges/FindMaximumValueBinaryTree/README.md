# Find the Maximum Value in a Binary Tree

This challenge involves finding the maximum node value within a provided binary
tree. The chosen implementation simply performs breadth-first traversal of all
nodes and compares each node's value to a running maximum. After traversing all
nodes, the running maximum is return to the caller.

__Note:__ This algorithm could be performed in O(log n) time if the input type
were specifically a binary _search_ tree; however, this algorithm was designed
to be usable for any binary tree. As such, time and space complexity are O(n)
due to the need to touch every node in the tree and to queue nodes for the
breadth-first traversal.

## Challenge

- Write a function called find-maximum-value which takes binary tree as its only
imput.
- Without utilizing any of the built-in methods available to your language,
return the maximum value stored in the tree.
- You can assume that the values stored in the Binary Tree will be numeric.

## Solution

![Whiteboard Solution Photo](/assets/FindMaximumValueBinaryTree.jpg)
