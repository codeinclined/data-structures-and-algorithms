# Binary Trees

**Author:** Joshua Taylor <taylor.joshua88@gmail.com>

**Version:** 1.0.0

## Description

This solution contains a basic implementation of binary trees. Support
for pre-order, in-order, and post-order traversals is included. All
three methods, _PreOrderTraversal(Node<T> node, List<T> values)_,
 _PreOrderTraversal(Node<T> node, List<T> values)_, and 
 _PreOrderTraversal(Node<T> node, List<T> values)_ take in the
 Tree's root node along with a .NET generic List which holds the values
 found while traversing the tree.

## Getting Started

BinaryTree targets the .NET Core 2.0 platform. The .NET Core 2.0 SDK can be
downloaded from the following URL for Windows, Linux, and macOS:

https://www.microsoft.com/net/download/

The dotnet CLI utility would then be used to build and run the application:

    cd Data_Structures/BinaryTree/BinaryTree
    dotnet build
    dotnet run

Additionally, users can build and run StackAndQueue using Visual Studio 2017 or
greater by opening the solution file located
[in this directory](/Data_Structures/BinaryTree). Unit tests have been
provided in the
[BinaryTreeTest project](/Data_Structures/BinaryTree/BinaryTreeTest)

## Architecture

BinaryTree consists of two primary classes along with a demonstration
of binary tree traversal in the Program class.

### Node\<T\>

Represents a node within a binary tree. Simply contains a _Left_ and
_Right_ reference to children nodes of the same class in addition to
a _Value_ property of type T containing the actual data for that node.

### Tree\<T\>

Represents a binary tree. This is a simple binary tree and not a binary
search tree. As such, traversals of all three types take O(n) time to
complete.

The three included traversal types are very similar to each other in
implementation with the major difference being when the values of each
node are looked at. In pre-order, this is done before moving down the
left and right branches. In in-order, this is done after moving down the
left branch all the way and before moving down the right branch. In
post-order, this is done after traversing both the left and right branches.

## Demonstration Application

Running the command line interface (CLI) application included in the Program
class of the BinaryTree project will provide a brief example of the types
of traversals implemented within this binary tree.

## Change Log
- 4.9.2018 [Joshua Taylor](mailto:taylor.joshua88@gmail.com) - Initial release.
All tests passing.