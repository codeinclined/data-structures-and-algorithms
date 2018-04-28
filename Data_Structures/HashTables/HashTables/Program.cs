using System;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<int, int> table1 = new HashTable<int, int>();

            table1.Add(47, 69);

            Console.WriteLine(table1.Contains(47).value);
        }
    }
}
