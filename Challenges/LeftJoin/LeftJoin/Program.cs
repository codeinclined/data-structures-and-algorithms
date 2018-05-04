using HashTables;
using System;

namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Left Table
            Console.WriteLine("Performing LEFT JOIN on the following hash tables:");
            HashTable<string, string> leftTable = new HashTable<string, string>();
            Console.WriteLine(@"leftTable[""fond""] = ""enamored""");
            leftTable["fond"] = "enamored";
            Console.WriteLine(@"leftTable[""wrath""] = ""anger""");
            leftTable["wrath"] = "anger";
            Console.WriteLine(@"leftTable[""diligent""] = ""employed""");
            leftTable["diligent"] = "employed";
            Console.WriteLine(@"leftTable[""outfit""] = ""garb""");
            leftTable["outfit"] = "garb";
            Console.WriteLine(@"leftTable[""guide""] = ""usher""");
            leftTable["guide"] = "usher";

            // Right Table
            Console.WriteLine();
            HashTable<string, string> rightTable = new HashTable<string, string>();
            Console.WriteLine(@"rightTable[""fond""] = ""averse""");
            rightTable["fond"] = "averse";
            Console.WriteLine(@"rightTable[""wrath""] = ""delight""");
            rightTable["wrath"] = "delight";
            Console.WriteLine(@"rightTable[""diligent""] = ""idle""");
            rightTable["diligent"] = "idle";
            Console.WriteLine(@"rightTable[""guide""] = ""follow""");
            rightTable["guide"] = "follow";
            Console.WriteLine(@"rightTable[""flow""] = ""jam""");
            rightTable["flow"] = "jam";

            // Joined Table
            Console.WriteLine();
            HashTable<string, string[]> joinedTable = LeftJoin(leftTable, rightTable);
            Console.WriteLine($"Keys found in LEFT JOIN'd table: [{string.Join(", ", joinedTable.Keys)}]");
            Console.WriteLine();
            Console.WriteLine("Key value pairs in the LEFT JOIN'd table:");

            // Display all key / value pairs in the joined result
            Console.WriteLine("[");
            foreach (string key in joinedTable.Keys)
            {
                Console.WriteLine($"    [{key}, {joinedTable[key][0]}, {joinedTable[key][1] ?? "NULL"}]");
            }
            Console.WriteLine("]");

            Console.WriteLine();
            Console.Write("Please press any key to exit this demonstration...");
            Console.ReadKey();
        }

        /// <summary>
        /// Performs a LEFT JOIN operation (similar to the SQL operation). All key / value
        /// pairs from the left table are added to the returned table, and all key / value
        /// pairs from the right table with keys matching keys from the left table are added.
        /// The returned, joined table consists of all joined keys with 2-element 1D arrays
        /// for the value (index 0 from the left table; index 1 from the right table).
        /// Keys that only appear in the left table will have the default value for ValueT
        /// in index 1 of the joined table's value array.
        /// </summary>
        /// <typeparam name="KeyT">The type of keys</typeparam>
        /// <typeparam name="ValueT">The type of values</typeparam>
        /// <param name="leftTable">The left table in the LEFT JOIN</param>
        /// <param name="rightTable">The right table is the LEFT JOIN</param>
        /// <returns>Left joined hash table with joined keys and a 2-element array containing
        /// the value from the left table and the right table (if a matching key exists)</returns>
        public static HashTable<KeyT, ValueT[]> LeftJoin<KeyT, ValueT>(
            HashTable<KeyT, ValueT> leftTable, HashTable<KeyT, ValueT> rightTable)
        {
            HashTable<KeyT, ValueT[]> joinedTable = new HashTable<KeyT, ValueT[]>();

            foreach (KeyT key in leftTable.Keys)
            {
                joinedTable.Add(key, new ValueT[2] { leftTable[key], default(ValueT) });
            }

            // If the right table contains matching keys to the left, add their values
            // to the second element of their respective key/value pairs of the joined result
            foreach (KeyT key in rightTable.Keys)
            {
                if (joinedTable.Contains(key).found)
                {
                    joinedTable[key][1] = rightTable[key];
                }
            }

            return joinedTable;
        }
    }
}
