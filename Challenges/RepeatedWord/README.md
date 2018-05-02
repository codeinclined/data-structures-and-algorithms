# First Repeated Word

This challenge involves finding the first repeated word contained within
a potentially lengthy input string. The chosen implementation for this
challenge was to use a hash table to contain previously found words.
While iterating through the words in the input string, these words are
checked against keys stored in the hash table. If found, the current
word is returned. If not, it is added to the hash table as a key. If no
repeating words are found, then the algorithm will simply return null.

## Challenge


- [X]  Write a function that accepts a lengthy string parameter.
- [X]  Without utilizing any of the built-in library methods available to your language, return the first word to occur more than once in that provided string.

## Solution

O(n) for space and time complexity.

![Whiteboard Solution Photo](/assets/RepeatedWord.jpg)
