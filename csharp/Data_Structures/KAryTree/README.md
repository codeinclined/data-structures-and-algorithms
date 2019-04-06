# K-ary Tree

**Author:** Joshua Taylor <taylor.joshua.w@gmail.com>

**Version:** 1.0.0

## Description

This solution demonstrates an implementation of a k-ary tree (also known as an
n-tree). Methods have been provided for adding new nodes to the tree as children
of existing nodes, breadth first traversal of all nodes in the tree, and O(n)
searching on the tree for nodes containing a specified value via breadth-first
traversal.

## Getting Started

K-ary Tree targets the .NET Core 2.0 platform. The .NET Core 2.0 SDK can be
downloaded from the following URL for Windows, Linux, and macOS:

https://www.microsoft.com/net/download/

The dotnet CLI utility would then be used to build and run the application:

    cd Data_Structures/KAryTree/KAryTree
    dotnet build
    dotnet run

Additionally, users can build and run KAryTree using Visual Studio 2017 or
greater by opening the solution file located
[in this directory](/Data_Structures/KAryTree). Unit tests have been
provided in the
[KAryTreeTest project](/Data_Structures/KAryTree/KAryTreeTest) using xUnit
(provided via a NuGet dependency).

## Demonstration

![Pushing Screenshot](/Data_Structures/KAryTree/assets/demo.JPG)

## Test Coverage

![Test Coverage](/Data_Structures/KAryTree/assets/coverage.JPG)

## Architecture

KAryTree consists of two primary classes: KAryNode\<T\> and KAryTree\<T\>.
KAryNode\<T\> consists of a single value of type T as well as a .NET generic
list of KAryNode\<T\> children. KAryTree\<T\> consists of a reference to its
root KAryNode\<T\> object as well as the Add, Search, and BreadthFirstTraversal
methods.

### KAryNode\<T\> KAryTree\<T\>.Search(T searchValue)

Searches for the first node within the tree with a Value property matching the
provided value and returns it to the caller. If no nodes were found containing
the provided value, then the method returns null.

### bool KAryTree\<T\>.Add(T newValue, T parentValue)

Attempts to add a new node containing newValue to the children of the first node
containing parentValue found via KAryTree\<T\>.Search(parentValue). Returns true
upon success. Returns false if KAryTree\<T\>.Search(parentValue) returns null
(i.e. no nodes containing parentValue can be found in the tree).

## Demonstration Application

Running the command line interface (CLI) application included in the Program
class of the KAryTree project will provide a simple demonstration of the
breadth-first representation of values within a tree after performing various
operations on that tree.

## Change Log
- 4.24.2018 [Joshua Taylor](mailto:taylor.joshua88@gmail.com) - Initial release.
All tests passing. 100% code coverage.