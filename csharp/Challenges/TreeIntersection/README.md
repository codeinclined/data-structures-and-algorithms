# Tree Intersection

This challenge involves finding the set of values which appear in two different
binary trees. The algorithm takes in two binary trees and then returns a list
of the set intersection of values between the two input trees (values will
only appear once per the definition of sets). A hash table is used to check
for values that appear in both trees in order to bring the time complexity
down to O(n) versus the O(n^2) that would result from having to do nested
comparisons on another data structure (such as the source trees or a linked
list)

## Challenge

- [X] Write a function called tree_intersection that takes two binary tree parameters.
- [X] Without utilizing any of the built-in library methods available to your language, return a set of values found in both trees.

## Solution

O(n) for space and time complexity.

![Whiteboard Solution Photo](/assets/TreeIntersection.jpg)
