# First In, First Out Animal Shelter

This solution contains an implementation for a FIFO class representing
an animal shelter which accepts cats and dogs. Animals should be able to be
enqueued into this animal shelter and then dequeued. The _Dequeue_ method
additionally provides a preferred animal type string parameter that will
dequeue the _Cat_ or _Dog_ object that has waited longest based on this
string's value of "cat" or "dog" (respectively). Any other values will simply
dequeue the animal of either type which has waited the longest.

## Challenge

- Create a class called AnimalShelter which holds only dogs and cats. The 
shelter operates using a first-in, first-out approach.
- Implement the following methods: 
  - enqueue(animal): adds animal to the shelter. animal can be either a dog or 
a cat object.
  - dequeue(pref): returns either a dog or a cat. If pref, a string, is ‘cat’
return the longest-waiting cat. If pref is ‘dog’, return the longest-waiting
dog. For anything else, return either a cat or a dog.

## Solution

![Whiteboard Solution Photo](/assets/FifoAnimalShelter.jpg)
