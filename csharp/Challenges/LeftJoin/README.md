# Hashmap LEFT JOIN

This challenge involves implementing the LEFT JOIN operation on two
hash tables in a similar fashion to the LEFT JOIN operation in SQL.
All key / value pairs from the left table are added to the returned table
which has keys matching the key type from the provided tables and values
of 1D arrays with two elements (the values from the left table are placed
in the first element of the array). Any values in the right table with
keys corresponding to keys in the left table will be added to the second
element of the returned table's value arrays. The complexity of this
algorithm in time and space are O(n) in the worst case.

## Challenge

- [X] Write a function that LEFT JOINs two hashmaps into a single data structure.
- [X] The first parameter is a hashmap that has word strings as keys, and a synonym of the key as values.
- [X] The second parameter is a hashmap that has word strings as keys, and antonyms of the key as values.
- [X] Combine the key and corresponding values (if they exist) into a new data structure according to LEFT JOIN logic.
- [X] LEFT JOIN means all the values in the first hashmap are returned, and if values exist in the “right” hashmap, they are appended to the result row. If no values exist in the right hashmap, then some flavor of NULL should be appended to the result row.
- [X] The returned data structure that holds the results is up to you. It doesn’t need to exactly match the output below, so long as it achieves the LEFT JOIN logic.
- [X] Avoid utilizing any of the library methods available to your language.

## Solution

O(n) for space and time complexity.

![Whiteboard Solution Photo](/assets/LeftJoin.jpg)
