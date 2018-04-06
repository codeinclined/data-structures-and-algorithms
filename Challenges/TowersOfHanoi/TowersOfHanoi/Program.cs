using System;
using StackAndQueue;

namespace TowersOfHanoi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide an integer greater than 0 of disks for the Tower of Hanoi:");

            int n = 0;

            // Make sure the user has provided a value of n > 0
            while (!Int32.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.WriteLine("\nPlease enter an integer greater than 0:");
            }

            MyQueue<string> moves = TowersOfHanoi(n);

            Console.WriteLine($"\nSolved the Tower of Hanoi in {moves.Length} moves:\n");

            while (moves.Length > 0)
            {
                Console.WriteLine(moves.Dequeue());
            }

            Console.WriteLine("\nPlease press any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Solves the Towers of Hanoi problem with n number of disks and returns
        /// a queue of strings containing descriptions of each move
        /// </summary>
        /// <param name="n">The number of disks in the Towers of Hanoi</param>
        /// <returns>A queue of strings describing each step taken to solve
        /// the Towers of Hanoi for n disks</returns>
        public static MyQueue<string> TowersOfHanoi(int n)
        {
            MyQueue<string> moves = new MyQueue<string>();
            MyStack<int>[] stacks = new MyStack<int>[3] { new MyStack<int>(), new MyStack<int>(), new MyStack<int>() };

            // Fill stack A (stacks[0]) with disks in the correct order
            for (int i = n; i > 0; i--)
            {
                stacks[0].Push(i);
            }

            // Starting move is based on the evenness of the number
            if (n % 2 != 0)
            {
                stacks[2].Push(stacks[0].Pop());
                moves.Enqueue("Disk 1 moved from A to C.");
            }
            else
            {
                stacks[1].Push(stacks[0].Pop());
                moves.Enqueue("Disk 1 moved from A to B.");
            }

            // Keeps disks from moving from even to even or odd to odd
            bool[] stacksEven = new bool[3];
            // Prevents the loop 
            int lastDisk = 1;

            int[] stackValues = new int[3];


            // Keep moving until stack C (index 2) gains all of stack A's disks
            while (stacks[2].Length < n)
            {
                int source = -1;
                int destination = -1;

                // Store the values and evenness of each stack's top disk
                stackValues[0] = stacks[0].Length > 0 ? stacks[0].Peek() : 0;
                stackValues[1] = stacks[1].Length > 0 ? stacks[1].Peek() : 0;
                stackValues[2] = stacks[2].Length > 0 ? stacks[2].Peek() : 0;
                stacksEven[0] = stackValues[0] % 2 == 0;
                stacksEven[1] = stackValues[1] % 2 == 0;
                stacksEven[2] = stackValues[2] % 2 == 0;

                for (int i = 0; i < 3; i++)
                {
                    // If this wasn't the last disk moved and the source stack isn't empty
                    if (stackValues[i] != lastDisk && stackValues[i] > 0)
                    {
                        // Check for destinations
                        for (int j = 0; j < 3; j++)
                        {
                            if (i != j && (stackValues[i] < stackValues[j] || stackValues[j] < 1))
                            {
                                // Prefer non-empty destination if two empty stacks are available
                                if (destination >= 0 && stackValues[j] < 1)
                                {
                                    break;
                                }

                                // If it's a legal move, then set source and destination
                                if (stacksEven[i] != stacksEven[j] || stackValues[j] < 1)
                                {
                                    source = i;
                                    destination = j;
                                }
                            }
                        }
                    }
                }

                // If a legal move has been made...
                if (source >= 0 && destination >= 0)
                {
                    // Adding 'A' (0x41) and the source / destination will
                    // map to 'A' (0x41), 'B' (0x42), or 'C' (0x43)
                    char startStack = Convert.ToChar('A' + source);
                    char endStack = Convert.ToChar('A' + destination);

                    // Commit the move and enqueue a description of that move
                    int movingDisk = stacks[source].Pop();
                    stacks[destination].Push(movingDisk);
                    lastDisk = movingDisk;
                    moves.Enqueue($"Disk {movingDisk} moved from {startStack} to {endStack}.");
                }
            }

            return moves;
        }
    }
}
