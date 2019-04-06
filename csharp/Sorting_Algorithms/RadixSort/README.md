# Radix Sort

**Author:** Joshua Taylor <taylor.joshua.w@gmail.com>

**Version:** 1.0.0

## Description

This solution contains an implementation of the radix sort algorithm for
positive integers with a counting sort used to sort by each digit. Radix sort
iterates over each digit of the values in the provided collection (in
this case, an array of integers) starting with the least significant digit
to the most significant digit of the largest number in the collection.

This results in the numbers being arranged in ascending order, disregarding the
sign of the numbers (in this implementation, -105 would come after 104).
Handling the signs of the numbers could be handled in a number of ways,
such as adding additional buckets for the specified radix to account for
negative values, adding a comparitive pass to the end of the sort (though this
would cause the algorithm to lose its non-comparative nature), or placing
values at different sides of the working array within the counting sort
algorithm based on the numbers' signs.

Radix sorts can be much faster than comparative sorts for integers. Since the
values are not being compare to one another, the time complexity is based
only on the product of the maximum number of digits within the collection and
the number of elements in the collection. This is often represented as O(kn).
Despite this, profiling on realistic data sets should be used when deciding
on a sorting algorithm since some of the other sorting algorithms which employ
divide-and-conquer techniques could potentially outperform radix sort when run
in parallel on systems which support hardware-based parallel processing.

For more information on radix sorts and to view a visualization of the
algorithm, please visit [this link.](https://visualgo.net/en/sorting?slide=15)

## Getting Started

Radix Sort targets the .NET Core 2.0 platform. The .NET Core 2.0 SDK can be
downloaded from the following URL for Windows, Linux, and macOS:

https://www.microsoft.com/net/download/

The dotnet CLI utility would then be used to build and run the application:

    cd Sorting_Algorithms/RadixSort/RadixSort
    dotnet build
    dotnet run

Additionally, users can build and run Radix Sort using Visual Studio 2017 or
greater by opening the solution file located
[in this directory](/Sorting_Algorithms/RadixSort). Unit tests have been
provided in the
[RadixSortTesting project](/Sorting_Algorithms/RadixSort/RadixSortTesting) using xUnit
(provided via a NuGet dependency).

## Test Coverage

Unit testing is available in the
[RadixSortTesting project](/Sorting_Algorithms/RadixSort/RadixSortTesting)
using xUnit (provided via a NuGet dependency). All tests were run using
JetBrains' dotCover tool with 100% code coverage for the RadixSort,
CountingSort, and MaxValueInArray methods.

## Demonstration Application

Running the command line interface (CLI) application included in the Program
class of the RadixSort project will provide a simple demonstration of
radix sorts on arrays of integers.

## Whiteboard Implementation

![Whiteboard Photo](/assets/RadixSort.jpg)

## Change Log
- 5.10.2018 [Joshua Taylor](mailto:taylor.joshua.w@gmail.com) - Initial release.
All tests passing. 100% code coverage.
