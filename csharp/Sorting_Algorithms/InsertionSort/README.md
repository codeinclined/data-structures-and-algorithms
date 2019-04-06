# Insertion Sort

**Author:** Joshua Taylor <taylor.joshua.w@gmail.com>

**Version:** 1.0.0

## Description

This solution implements a generic insertion sort algorithm. Insertion sort
works by iterating through each element of an enumerable data structure, such
as an array in the case of this implementation. These values are known as the
key elements. For each key element, another nested loop takes place which
shifts the key element backwards until reaching either the beginning of the
data structure or an element that is less than the key element in value. Once
each key has been iterated over, the resultant array will be in order from
least to greatest.

This implementation works for any type that implements the IComparable\<T\>
interface. The worst case time complexity for this algorithm is O(n²) due to
its forwards and backwards iterations needed for each key element. Worst
case space complexity is O(1).

For more information on insertion sorts and to view a visualization of the
algorithm, please visit [this link.](https://visualgo.net/en/sorting?slide=8)

## Getting Started

Insertion Sort targets the .NET Core 2.0 platform. The .NET Core 2.0 SDK can be
downloaded from the following URL for Windows, Linux, and macOS:

https://www.microsoft.com/net/download/

The dotnet CLI utility would then be used to build and run the application:

    cd Sorting_Algorithms/InsertionSort/InsertionSort
    dotnet build
    dotnet run

Additionally, users can build and run Insertion Sort using Visual Studio 2017 or
greater by opening the solution file located
[in this directory](/Sorting_Algorithms/InsertionSort). Unit tests have been
provided in the
[InsertionSortTesting project](/Sorting_Algorithms/InsertionSort/InsertionSortTesting) using xUnit
(provided via a NuGet dependency).

## Test Coverage

Unit testing is available in the
[InsertionSortTesting project](/Sorting_Algorithms/InsertionSort/InsertionSortTesting)
using xUnit (provided via a NuGet dependency). All tests were run using
JetBrains' dotCover tool with 100% code coverage for the InsertionSort method.
The algorithm was tested for System.Int32, System.Double, and System.Char types.

## Demonstration Application

Running the command line interface (CLI) application included in the Program
class of the InsertionSort project will provide a simple demonstration of
insertion sorts on arrays of System.Int32, System.Double, and System.Char types.

## Change Log
- 5.6.2018 [Joshua Taylor](mailto:taylor.joshua.w@gmail.com) - Initial release.
All tests passing. 100% code coverage.