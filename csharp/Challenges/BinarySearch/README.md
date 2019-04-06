# Binary Search

Binary search can be used to find a value within a one-dimensional array with 
O(log n) time complexity and O(1) for space. This can result in a much faster
search than simply iterating over every value in the array, which would
incur an O(n) time complexity.

## Challenge

* Write a function called BinarySearch which takes in two parmeters: a sorted
array and the search key. Without utilizing any of the built-in methods
available to your language, return the index of the array's element that is
equal to the search key, or -1 if the elment does not exist.

### Example
    [4, 8, 15, 16, 23, 42], 15       -> 2
    [11, 22, 33, 44, 55, 66, 77], 90 -> -1

* Write at least three test assertions for each method
* Ensure that all tests are passing

## Solution

### Note

The original solution for this problem was determined to be ineffective
due to its exceeding of array indexes. The included C# code makes uses of
an alternative algorithm based on dividing the array using left, right, and
midpoint bounds. The original algorithm has been included below:

![Solution Whiteboard Photo](/assets/BinarySearch.jpg)
