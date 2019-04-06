using System;
using System.Text.RegularExpressions;
using HashTables;

namespace RepeatedWord
{
    public class Program
    {
        static string[] DemoStrings => new string[]
        {
            "Once upon a time, there was a brave princess who...",
            "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...",
            "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York..."
        };

        static void Main(string[] args)
        {
            Console.WriteLine("This is an example of using hash tables to identify the first repeated word in three potentially lengthy strings of text.");
            Console.WriteLine();

            foreach (string demoString in DemoStrings)
            {
                Console.WriteLine("Input string:");
                Console.WriteLine(demoString);

                Console.WriteLine();
                Console.WriteLine($"First repeated word: {RepeatedWord(demoString)}");

                Console.WriteLine();
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static string RepeatedWord(string inputString)
        {
            HashTable<string, int> hashTable = new HashTable<string, int>();

            // Split the input string into words using RegEx, separated by one
            // or more consecutive non-word characters. ToLowerInvariant() makes sure
            // capitalization doesn't affect matching
            foreach (string word in Regex.Split(inputString.ToLowerInvariant(), @"\W+"))
            {
                if (hashTable.Contains(word).found)
                {
                    return word;
                }

                hashTable.Add(word, 1);
            }

            return null;
        }
    }
}
