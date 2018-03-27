# Linked List Insertions

This project will demonstrate how nodes can be appended to the back
of a singly linked list, inserted before an existing node given a search
value, and inserted after an existing node given a search value. Running
the program will write before and after snapshots of linked lists when
performing these operations.

## Challenge
Write the following methods for the Linked List class:

- *.append(value)* which adds a new node with the given value to the end of the list
- *.insertBefore(value, newVal)* which add a new node with the given newValue immediately before the first value node
- *.insertAfter(value, newVal)* which add a new node with the given newValue immediately after the first value node

You have access to the Node class and all the properties on the Linked List class.

### Examples
#### .append(value) ####
    Input:      head -> [1] -> [3] -> [2] -> X
    Argument:   5
    Result:     head -> [1] -> [3] -> [2] -> [5] -> X

    Input:      head -> X
    Argument:   1
    Result:     head -> [1] -> X

#### .insertBefore(value, newVal) ####
    Input:      head -> [1] -> [3] -> [2] -> X
    Arguments:  3, 5
    Result:     head -> [1] -> [5] -> [3] -> [2] -> X

    Input:      head -> [1] -> [3] -> [2] -> X
    Arguments:  1, 5
    Result:     head -> [5] -> [1] -> [3] -> [2] -> X

    Input:      head -> [1] -> [2] -> [2] -> X
    Arguments:  2, 5
    Result:     head -> [1] -> [5] -> [2] -> [2] -> X

    Input:      head -> [1] -> [3] -> [2] -> X
    Arguments:  4, 5
    Result:     Exception
#### .insertAfter(value, newVal) ####
    Input:      head -> [1] -> [3] -> [2] -> X
    Arguments:  3, 5
    Result:     head -> [1] -> [3] -> [5] -> [2] -> X

    Input:      head -> [1] -> [3] -> [2] -> X
    Arguments:  2, 5
    Result:     head -> [1] -> [3] -> [2] -> [5] -> X

    Input:      head -> [1] -> [2] -> [2] -> X
    Arguments:  2, 5
    Result:     head -> [1] -> [2] -> [5] -> [2] -> X

    Input:      head -> [1] -> [3] -> [2] -> X
    Arguments:  4, 5
    Result:     Exception

## Solution
![LL_Insertions Solution Photo](/assets/LL_Insertions.jpg)