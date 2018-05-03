using HashTables;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HashTablesTesting
{
    public class HashTablesTesting
    {
        [Fact]
        public void CanConstructWithSpecificBucketCount()
        {
            // Act
            HashTable<string, int> table = new HashTable<string, int>(2048);

            // Assert
            Assert.Equal(2048, table.BucketCount);
        }

        [Theory]
        [ClassData(typeof(GetHashTestData))]
        public void HashWithinRangeTest(double keyToHash)
        {
            // Arrange
            HashTable<double, char> table = new HashTable<double, char>();

            // Act
            int hashIndex = table.GetHash(keyToHash);

            // Assert
            Assert.InRange(hashIndex, 0, table.BucketCount);
        }

        [Theory]
        [ClassData(typeof(GetHashTestData))]
        public void AddKeyValuePairTest(double keyValue)
        {
            // Arrange
            HashTable<double, int> table = new HashTable<double, int>();

            // Act
            table.Add(keyValue, ~(int)keyValue);

            // Act
            Assert.Equal(~(int)keyValue, table.Buckets[table.GetHash(keyValue)].Value);
        }

        [Fact]
        public void CannotAddDuplicateKey()
        {
            // Arrange
            HashTable<string, int> table = new HashTable<string, int>();
            table.Add("pan", int.MaxValue);

            // Assert
            Assert.Throws<ArgumentException>(() => table.Add("pan", int.MinValue));
        }

        [Theory]
        [ClassData(typeof(GetHashTestData))]
        public void ContainsValuePairTruthTest(double keyValue)
        {
            // Arrange
            HashTable<double, int> table = new HashTable<double, int>();
            table.Add(keyValue, int.MaxValue);

            // Act
            (bool found, _) = table.Contains(keyValue);

            // Assert
            Assert.True(found);
        }

        [Fact]
        public void CanCheckContainsWithoutFalsePositive()
        {
            // Arrange
            HashTable<double, int> table = new HashTable<double, int>();
            table.Add(Math.PI, int.MaxValue);

            // Act
            (bool found, _) = table.Contains(Math.E);

            // Assert
            Assert.False(found);
        }

        [Fact]
        public void CanCheckContainsWithoutCollisionFalsePositive()
        {
            // Arrange
            HashTable<string, int> table = new HashTable<string, int>();
            table.Add("pan", int.MaxValue);

            // Act
            (bool found, _) = table.Contains("nap");

            // Assert
            Assert.False(found);
        }

        [Fact]
        public void CanCheckContainsWithoutCollisionFalseNegative()
        {
            // Arrange
            HashTable<string, int> table = new HashTable<string, int>();
            table.Add("pan", int.MaxValue);
            table.Add("nap", int.MinValue);

            // Act
            (bool found, _) = table.Contains("pan");

            // Assert
            Assert.True(found);
        }

        [Theory]
        [ClassData(typeof(GetHashTestData))]
        public void CanUseIndexerGetForExistingKey(double testKey)
        {
            // Arrange
            HashTable<double, int> table = new HashTable<double, int>();
            table.Add(testKey, int.MaxValue);

            // Act
            int actualValue = table[testKey];

            // Assert
            Assert.Equal(int.MaxValue, actualValue);
        }

        [Fact]
        public void CannotUseIndexerGetForNonexistantKeys()
        {
            // Arrange
            HashTable<double, int> table = new HashTable<double, int>();

            // Assert
            Assert.Throws<KeyNotFoundException>(() => table[Math.PI]);
        }

        [Theory]
        [ClassData(typeof(GetHashTestData))]
        public void CanUseIndexerSetToCreateKey(double testKey)
        {
            // Arrange
            HashTable<double, int> table = new HashTable<double, int>();

            // Act
            table[testKey] = int.MaxValue;

            // Assert
            Assert.True(table.Contains(testKey).found);
        }

        [Theory]
        [ClassData(typeof(GetHashTestData))]
        public void CanUseIndexerSetToUpdateExistingKeyValue(double testKey)
        {
            // Arrange
            HashTable<double, int> table = new HashTable<double, int>();
            table.Add(testKey, int.MaxValue);

            // Act
            table[testKey] = int.MinValue;

            // Assert
            Assert.Equal(int.MinValue, table.Contains(testKey).value);
        }
    }
}
