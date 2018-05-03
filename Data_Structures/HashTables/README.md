# Hash Table

**Author:** Joshua Taylor <taylor.joshua.w@gmail.com>

**Version:** 1.1.0

## Description

This solution demonstrates an example of a simple hash table using an
embedded hashing algorithm based on coverting key values into unicode
via the key type's ToString() method, adding all code points together,
multiplying by a prime factor, and then bringing that value into the
range of bucket indexes within the hash table. Collisions are handled
by making each bucket a singly-linked list with nodes containing each
entry's key and value. Any .NET type can be used for keys and values
through HashTable's generic implementation.

## Getting Started

Hash Table targets the .NET Core 2.0 platform. The .NET Core 2.0 SDK can be
downloaded from the following URL for Windows, Linux, and macOS:

https://www.microsoft.com/net/download/

The dotnet CLI utility would then be used to build and run the application:

    cd Data_Structures/HashTables/HashTables
    dotnet build
    dotnet run

Additionally, users can build and run HashTables using Visual Studio 2017 or
greater by opening the solution file located
[in this directory](/Data_Structures/HashTables). Unit tests have been
provided in the
[HashTablesTesting project](/Data_Structures/KAryTree/HashTablesTesting) using xUnit
(provided via a NuGet dependency).


## Demonstration

![Hash Table Demo](/Data_Structures/HashTables/assets/demo.JPG)

## Test Coverage

Unit testing is available in the
[HashTablesTesting project](/Data_Structures/KAryTree/HashTablesTesting)
using xUnit (provided via a NuGet dependency). All tests were run using
JetBrains' dotCover tool with 100% code coverage on the HashTable and
BucketNode classes.

![dotCover Screenshot](/Data_Structures/HashTables/assets/coverage.JPG)

## Complexity and Hash Collisions

Worst-case time and space complexity for this implementation is O(n)
due to the buckets' usage of linked lists to handle collisions; however,
the average time complexity approaches the best case, O(1), when collisions
do not frequently occur. Due to the hashing algorithm's simple
accumulation-based implementation, collisions most frequently occur when
keys are anagrams strings of equal length, such as "pan" and "nap" or 1024 and 4021.

## Demonstration Application

Running the command line interface (CLI) application included in the Program
class of the HashTables project will provide a simple demonstration of
adding key/value pairs to the hash table, looking up values by keys, and
chaining of duplicate hashed indexes via linked lists.

## Change Log
- 5.2.2018 [Joshua Taylor](mailto:taylor.joshua.w@gmail.com) - Added indexer to
HashTable class with a setter and getter in support of the TreeIntersection
whiteboard challenge. Refactored the Contains method. Wrote unit tests for new
methods. All tests passing. 100% code coverage of HashTable and BucketNode classes.
- 4.28.2018 [Joshua Taylor](mailto:taylor.joshua.w@gmail.com) - Initial release.
All tests passing. 100% code coverage.