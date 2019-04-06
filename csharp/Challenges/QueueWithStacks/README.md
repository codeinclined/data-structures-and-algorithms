# Implement a Queue With Two Stacks

This solution contains an implementation of a queue using two stacks. One stack
is used for incoming nodes through the Enqueue\<T\> method, the other is
used for outgoing nodes from the Dequeue\<T\> method. Consecutive calls to
one method will result in a simple pop or push from the outgoing or incoming
stacks. Calling Enqueue\<T\> after Dequeue\<T\> or the other way around will
result in an O(n) shifting from one stack to the other via pushes and pops.
This equates to an overall worst-case complexity of O(1) for space and O(n) for
time on both methods.

## Challenge

Implement the following methods for the Queue class:
- enqueue(value) which inserts value into the Queue using a first-in, first-out 
approach.
- dequeue() which extracts a value from the Queue using a first-in, first-out
approach.

You have access to 2 Stack instances with push and pop methods.

### Examples

#### enqueue(value) #####
    Input               Args    Output
    [10]->[15]->[20]    5       [5]->[10]->[15]->[20]
                        5       [5]

#### dequeue() ####
    Input                    Output    Internal State
    [5]->[10]->[15]->[20]    20        [5]->[10]->[15]->[20]
    [5]->[10]->[15]          15        [5]->[10]


## Solution

![Whiteboard Solution Photo](/assets/QueueWithStacks.jpg)
