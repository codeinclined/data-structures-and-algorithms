using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using HashTables;

namespace LeftJoinTesting
{
    /// <summary>
    /// Provides three test cases for LeftJoinTest
    /// </summary>
    class LeftJoinTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            #region First Test Case
            {
                HashTable<string, string> leftTable = new HashTable<string, string>();
                leftTable["fond"] = "enamored";
                leftTable["wrath"] = "anger";
                leftTable["diligent"] = "employed";
                leftTable["outfit"] = "garb";
                leftTable["guide"] = "usher";

                HashTable<string, string> rightTable = new HashTable<string, string>();
                rightTable["fond"] = "averse";
                rightTable["wrath"] = "delight";
                rightTable["diligent"] = "idle";
                rightTable["guide"] = "follow";
                rightTable["flow"] = "jam";

                string[,] expectedLeftJoin = new string[,]
                {
                    { "fond", "enamored", "averse" },
                    { "wrath", "anger", "delight" },
                    { "diligent", "employed", "idle" },
                    { "outfit", "garb", null },
                    { "guide", "usher", "follow" }
                };

                yield return new object[]
                {
                    leftTable,
                    rightTable,
                    expectedLeftJoin
                };
            }
            #endregion

            #region Second Test Case
            {
                HashTable<string, string> leftTable = new HashTable<string, string>();
                leftTable["good"] = "great";
                leftTable["sad"] = "depressed";
                leftTable["bright"] = "brilliant";

                HashTable<string, string> rightTable = new HashTable<string, string>();
                rightTable["good"] = "bad";
                rightTable["disgusting"] = "pleasant";
                rightTable["bright"] = "dim";

                string[,] expectedLeftJoin = new string[,]
                {
                    { "good", "great", "bad" },
                    { "sad", "depressed", null },
                    { "bright", "brilliant", "dim" },
                };

                yield return new object[]
                {
                    leftTable,
                    rightTable,
                    expectedLeftJoin
                };
            }
            #endregion

            #region Third Test Case
            {
                HashTable<string, string> leftTable = new HashTable<string, string>();
                // Intentionally Empty

                HashTable<string, string> rightTable = new HashTable<string, string>();
                rightTable["empty"] = "full";

                string[,] expectedLeftJoin = new string[0, 3];

                yield return new object[]
                {
                    leftTable,
                    rightTable,
                    expectedLeftJoin
                };
            }
            #endregion
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
