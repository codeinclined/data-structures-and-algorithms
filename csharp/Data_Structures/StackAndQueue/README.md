# Stack and Queue

**Author:** Joshua Taylor <taylor.joshua88@gmail.com>

**Version:** 1.0.0

## Description

This solution demonstrates a linked list implementation of a stack and a queue.
All manipulation methods on these classes have been kept to O(1) complexity for
both space and time.

## Getting Started

StackAndQueue targets the .NET Core 2.0 platform. The .NET Core 2.0 SDK can be
downloaded from the following URL for Windows, Linux, and macOS:

https://www.microsoft.com/net/download/

The dotnet CLI utility would then be used to build and run the application:

    cd Data_Structures/StackAndQueue/StackAndQueue
    dotnet build
    dotnet run

Additionally, users can build and run StackAndQueue using Visual Studio 2017 or
greater by opening the solution file located
[in this directory](/Data_Structures/StackAndQueue). Unit tests have been
provided in the
[StackAndQueueTest project](/Data_Structures/StackAndQueue/StackAndQueueTest)

## Examples

### Pushing on a Stack
![Pushing Screenshot](/Data_Structures/StackAndQueue/assets/stackPush.JPG)
### Popping from a Stack
![Popping Screenshot](/Data_Structures/StackAndQueue/assets/popping.JPG)
### Enqueueing to a Queue
![Enqueueing Screenshot](/Data_Structures/StackAndQueue/assets/enqueue.JPG)
### Dequeueing from a Queue
![Dequeueing Screenshot](/Data_Structures/StackAndQueue/assets/dequeue.JPG)

## Architecture

StackAndQueue consists of three primary classes along with demonstrations
of these classes in operation within the Program class.

### Node\<T\>

Represents a node within a stack or a queue. Simply contains a value of type
T and a reference to another Node\<T\> object of the same type. Value and
reference types are supported despite the naming of the Value property. The
constructor provides default values in case the caller wishes to create an Node
holding the default value of T for Value and a null reference for Next, or
these properties can be set by the caller.

### MyStack\<T\>

Represents a linked list implementation of a stack using Node\<T\> objects. The
class has been named MyStack\<T\> to prevent ambiguity when the
System.Collections.Generic namespace has been brought into scope via a using
statement. Nodes are accessed in first in, last out (FILO) ordering per the
classical definition of a stack.

#### _public void_ MyStack\<T\>.Push(T value) ####

Pushes a new Node\<T\> object to the top of the stack containing the value
of type T passed as an argument to this method.

Space and time complexity: O(1).

#### _public T_ MyStack\<T\>.Peek() ####

Returns the value of the top Node object contained within the stack to the
caller without removing it from the stack.

Space and time complexity: O(1).

#### _public T_ MyStack\<T\>.Pop() ####

Removes the top Node object contained within the stack and returns its value
to the caller.

Space and time complexity: O(1).

### MyQueue\<T\>

Represents a linked list implementation of a queue using Node\<T\> objects.
The class has been named MyQueue\<T\> to prevent ambiguity when the
System.Collections.Generic namespace has been brought into scope via a
using statement. Nodes are accessed in first in, first out (FIFO) ordering
per the classical definition of a queue.

#### _public void_ MyQueue\<T\>.Enqueue(T value) ####

Enqueues a new Node\<T\> object to the front of the queue containing the
value of type T passed as an argument to this method.

Space and time complexity: O(1).

#### _public T_ MyQueue\<T\>.Peek() ####

Returns the value of the front Node object contained within the queue to the
caller without removing it from the queue.

Space and time complexity: O(1).

#### _public T_ MyQueue\<T\>.Dequeue() ####

Removes the front Node objected contained within the queue and returns its
value to the caller.

Space and time complexity: O(1).

## Demonstration Application

Running the command line interface (CLI) application included in the Program
class of the StackAndQueue project will provide an animated console
demonstration of the above classes' and methods' operation. Pauses for
user keyboard input are provided after each demonstration. Screenshots have
been provided above under the _Examples_ heading.

## Change Log
- 4.1.2018 [Joshua Taylor](mailto:taylor.joshua88@gmail.com) - Initial release.
All tests passing.