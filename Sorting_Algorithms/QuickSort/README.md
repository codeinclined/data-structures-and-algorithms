# Quick Sort

**Author:** Joshua Taylor <taylor.joshua.w@gmail.com>

**Version:** 1.0.0

## Description

This solution contains a recursive implementation of the quick sort algorithm.
Quick sort relies upon partitioning of the collection being sorted in order to
reduce the number of required comparisons. This implementation uses a pivot
point at the middle of the array and two counters starting at either side of
the array to be sorted. The first counter increments while it encounters
elements less than the value at the pivot point. The second counter decrements
while it finds values greater than the value at the pivot point. When values
are found which do not meet these criteria on both sides, a swap occurs to
correct these values ordering.

At this point, it can be assumed that all values left of the pivot point are
less than the pivot point's value and all values right of the pivot point are
greater than the pivot point's value. These two partitions are then sorted
using this same algorithm recursively until the array can no longer be
partitioned, which is the base case for this algorithm. At that point, the
array has been sorted.

One great advantage of the quick sort algorithm lies in its divide-and-conquer
approach to sorting. Not only does this bring the time complexity down to
O(n log n), but it also provides an opportunity to sort the provided collection
in parallel using multiple threads or processes.

For more information on quick sorts and to view a visualization of the
algorithm, please visit [this link.](https://visualgo.net/en/sorting?slide=11)

## Getting Started

Quick Sort targets the .NET Core 2.0 platform. The .NET Core 2.0 SDK can be
downloaded from the following URL for Windows, Linux, and macOS:

https://www.microsoft.com/net/download/

The dotnet CLI utility would then be used to build and run the application:

    cd Sorting_Algorithms/QuickSort/QuickSort
    dotnet build
    dotnet run

Additionally, users can build and run Quick Sort using Visual Studio 2017 or
greater by opening the solution file located
[in this directory](/Sorting_Algorithms/QuickSort). Unit tests have been
provided in the
[QuickSortTesting project](/Sorting_Algorithms/QuickSort/QuickSortTesting) using xUnit
(provided via a NuGet dependency).

## Test Coverage

Unit testing is available in the
[QuickSortTesting project](/Sorting_Algorithms/QuickSort/QuickSortTesting)
using xUnit (provided via a NuGet dependency). All tests were run using
JetBrains' dotCover tool with 100% code coverage for the QuickSort method.

## Demonstration Application

Running the command line interface (CLI) application included in the Program
class of the QuickSort project will provide a simple demonstration of
merge sorts on arrays of integers.

## Whiteboard Implementation

![Whiteboard Photo](/assets/QuickSort.jpg)

## Change Log
- 5.9.2018 [Joshua Taylor](mailto:taylor.joshua.w@gmail.com) - Initial release.
All tests passing. 100% code coverage.