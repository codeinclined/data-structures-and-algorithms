using HashTables;
using LeftJoin;
using System;
using Xunit;

namespace LeftJoinTesting
{
    public class LeftJoinTesting
    {
        /// <summary>
        /// Test that the LeftJoin method correctly performs the LEFT JOIN
        /// operation on the given tables based on a provided expected 2D array.
        /// Changes output data structure into a 2D array representation to ease
        /// the Assert.Equal() check. Performs 3 test cases from the class data.
        /// </summary>
        /// <param name="leftTable">The left table to join (from LeftJoinTestData)</param>
        /// <param name="rightTable">The right table to join (from LeftJoinTestData)</param>
        /// <param name="expectedJoin">The expected 2D array representation of the
        /// result of LeftJoin()</param>
        [Theory]
        [ClassData(typeof(LeftJoinTestData))]
        public void LeftJoinTest(HashTable<string, string> leftTable, 
            HashTable<string, string> rightTable, string[,] expectedJoin)
        {
            // Act
            HashTable<string, string[]> joinedTable = Program.LeftJoin(leftTable, rightTable);

            // Assert
            // Turn the joinedTable into a representation that we can more easily test
            string[,] arrayJoinRepresentation = new string[joinedTable.Keys.Count, 3];

            for (int i = 0; i < joinedTable.Keys.Count; i++)
            {
                arrayJoinRepresentation[i, 0] = joinedTable.Keys[i];
                arrayJoinRepresentation[i, 1] = joinedTable[joinedTable.Keys[i]][0];
                arrayJoinRepresentation[i, 2] = joinedTable[joinedTable.Keys[i]][1];
            }

            Assert.Equal(expectedJoin, arrayJoinRepresentation);
        }
    }
}
