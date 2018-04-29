using System;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating new hash table with the following key/pairs:");

            HashTable<string, int> table = new HashTable<string, int>();

            #region Adding values to the hash table
            Console.WriteLine(@"table[""cat""] = 10");
            table.Add("cat", 10);

            Console.WriteLine(@"table[""bat""] = 15");
            table.Add("bat", 15);
            
            Console.WriteLine(@"table[""hat""] = 20");
            table.Add("hat", 20);

            Console.WriteLine(@"table[""apple""] = 30");
            table.Add("apple", 30);

            Console.WriteLine(@"table[""sauce""] = 40");
            table.Add("sauce", 40);

            Console.WriteLine(@"table[""pan""] = 50");
            table.Add("pan", 50);

            Console.WriteLine(@"table[""nap""] = 60");
            table.Add("nap", 60);

            Console.WriteLine(@"table[""supercalifragilisticexpialidocious""] = 5");
            table.Add("supercalifragilisticexpialidocious", 5);

            Console.WriteLine(@"table[""Tom""] = 200");
            table.Add("Tom", 200);
            #endregion

            Console.WriteLine();

            #region Checking if key / value pairs exist in the hash table
            bool found;
            int value;

            (found, value) = table.Contains("cat");
            Console.WriteLine($"Does table have a key called \"cat\"? {(found ? $"Yes, it is {value}" : "No")}");

            (found, value) = table.Contains("bat");
            Console.WriteLine($"Does table have a key called \"bat\"? {(found ? $"Yes, it is {value}" : "No")}");

            (found, value) = table.Contains("tab");
            Console.WriteLine($"Does table have a key called \"tab\"? {(found ? $"Yes, it is {value}" : "No")}");

            (found, value) = table.Contains("hat");
            Console.WriteLine($"Does table have a key called \"hat\"? {(found ? $"Yes, it is {value}" : "No")}");

            (found, value) = table.Contains("pan");
            Console.WriteLine($"Does table have a key called \"pan\"? {(found ? $"Yes, it is {value}" : "No")}");

            (found, value) = table.Contains("nap");
            Console.WriteLine($"Does table have a key called \"nap\"? {(found ? $"Yes, it is {value}" : "No")}");

            (found, value) = table.Contains("apple sauce");
            Console.WriteLine($"Does table have a key called \"applesauce\"? {(found ? $"Yes, it is {value}" : "No")}");

            (found, value) = table.Contains("supercalifragilisticexpialidocious");
            Console.WriteLine($"Does table have a key called \"supercalifragilisticexpialidocious\"? {(found ? $"Yes, it is {value}" : "No")}");

            (found, value) = table.Contains("Tom");
            Console.WriteLine($"Does table have a key called \"Tom\"? {(found ? $"Yes, it is {value}" : "No")}");

            (found, value) = table.Contains("tom");
            Console.WriteLine($"Does table have a key called \"tom\"? {(found ? $"Yes, it is {value}" : "No")}");
            #endregion

            Console.WriteLine();

            #region Making sure buckets are working
            // The below code only works here because the hash table allows for internal access
            // of its underlying Buckets array and GetHash method
            int bucketCount = 0;
            BucketNode<string, int> bucketNode = table.Buckets[table.GetHash("pan")];

            while (bucketNode != null)
            {
                bucketCount++;
                bucketNode = bucketNode.Next;
            }

            Console.WriteLine($"How many items are in the bucket with the keys \"pan\" and \"nap\"? {bucketCount}");
            #endregion

            Console.WriteLine();
            Console.Write("Please press any key to exit this demo...");
            Console.ReadKey(true);
        }
    }
}
