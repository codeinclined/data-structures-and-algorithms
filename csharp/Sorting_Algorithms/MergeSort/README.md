# Merge Sort

**Author:** Joshua Taylor <taylor.joshua.w@gmail.com>

**Version:** 1.0.0

## Description

This solution contains a recursive implementation of the merge sort algorithm.
Merge sort involves breaking apart the source array into smaller arrays until
each array contains only one element. These sub-arrays are then merged back
together by comparing individual elements in the sub-arrays. This allows for
much better time complexity than the insertion sort: O(n log n), with space
complexity of O(n) in the worst case.

For more information on insertion sorts and to view a visualization of the
algorithm, please visit [this link.](https://visualgo.net/en/sorting?slide=10)

## Getting Started

Merge Sort targets the .NET Core 2.0 platform. The .NET Core 2.0 SDK can be
downloaded from the following URL for Windows, Linux, and macOS:

https://www.microsoft.com/net/download/

The dotnet CLI utility would then be used to build and run the application:

    cd Sorting_Algorithms/MergeSort/MergeSort
    dotnet build
    dotnet run

Additionally, users can build and run Merge Sort using Visual Studio 2017 or
greater by opening the solution file located
[in this directory](/Sorting_Algorithms/MergeSort). Unit tests have been
provided in the
[MergeSortTesting project](/Sorting_Algorithms/MergeSort/MergeSortTesting) using xUnit
(provided via a NuGet dependency).

## Test Coverage

Unit testing is available in the
[MergeSortTesting project](/Sorting_Algorithms/MergeSort/MergeSortTesting)
using xUnit (provided via a NuGet dependency). All tests were run using
JetBrains' dotCover tool with 100% code coverage for the MergeSort and
Merge methods.

## Demonstration Application

Running the command line interface (CLI) application included in the Program
class of the MergeSort project will provide a simple demonstration of
merge sorts on arrays of integers.

## Whiteboard Implementation

![Whiteboard Photo](/assets/MergeSort.jpg)

## Change Log
- 5.7.2018 [Joshua Taylor](mailto:taylor.joshua.w@gmail.com) - Initial release.
All tests passing. 100% code coverage.