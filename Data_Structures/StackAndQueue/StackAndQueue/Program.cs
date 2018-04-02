using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Show an animation of pushing values onto MyStack<T> stack...
            Console.WriteLine("Pushing values onto MyStack<T> stack...\n");
            (MyStack<int> stack, string stackString) =
                DemoPushingStack(new int[] { 2, 3, 5, 7, 11, 13, 17, 19 });

            // Demonstrate MyStack<T>.Peek()...
            Console.Write("\n\nPeeking from above stack: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(stack.Peek().ToString());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPlease press any key to see a demonstration of popping...");
            Console.ReadKey();

            // Show an animation of values being popped off of the stack...
            DemoPoppingStack(stack, stackString);
            Console.WriteLine("\nPlease press any key for demos of MyQueue<T>...");
            Console.ReadKey();

            // Show an animation of values being enqueued into a new MyQueue<T> object...
            (MyQueue<int> queue, string queueString) = 
                DemoEnqueue(new int[] { 2, 3, 5, 7, 11, 13, 17, 19 });
            Console.WriteLine("\nPlease press any key to dequeue all values from the above queue...");
            Console.ReadKey();

            // Show an animation of values being dequeued from the above queue...
            DemoDequeue(queue, queueString);
            Console.WriteLine("\nPlease press any key to quit this program...");
            Console.ReadKey();
        }

        /// <summary>
        /// Takes in an array of values and constructs a MyStack object
        /// while displaying an animation to the console
        /// </summary>
        /// <typeparam name="T">The type of values held in <paramref name="values"/></typeparam>
        /// <param name="values">An array of values to be held by the returned stack</param>
        /// <returns>A value tuple containing the new stack and a string representation
        /// of it</returns>
        static (MyStack<T>, string) DemoPushingStack<T>(T[] values)
        {
            MyStack<T> stack = new MyStack<T>();
            StringBuilder sb = new StringBuilder();

            foreach (T value in values)
            {
                // Write all the previous values
                Console.CursorLeft = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(sb.ToString());

                // Write the top of the stack and add to StringBuilder
                stack.Push(value);
                string curValueString = $" [{stack.Peek()}]";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(curValueString);
                sb.Append(curValueString);

                // Sleep for 715ms to animate pushing
                Thread.Sleep(715);
            }

            Console.ForegroundColor = ConsoleColor.White;
            return (stack, sb.ToString());
        }

        /// <summary>
        /// Demonstrates popping from a stack using an animation
        /// </summary>
        /// <typeparam name="T">The type of values in the stack</typeparam>
        /// <param name="stack">A MyStack object containing values which
        /// will be written to the console as an animation</param>
        /// <param name="stackString">A pre-made string representation of
        /// the stack</param>
        static void DemoPoppingStack<T>(MyStack<T> stack, string stackString)
        {
            while (stack.Length > 0)
            {
                // Clear the console and display a status message
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Popping values off of the stack...\n");

                // Display the entire stack string in green
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(stackString);

                // Pop from the stack and create a string representation of it
                T popped = stack.Pop();
                string poppedString = $"[{popped.ToString()}] ";

                // Update the stack string
                stackString = stackString.Remove(stackString.Length - poppedString.Length);

                // Overwrite the green text with red text up to the last popped item
                Console.CursorLeft = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(stackString);

                // Provide some stats on the stack
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nPopped:\t{poppedString}");
                Console.WriteLine($"Length:\t{stack.Length}");

                // Sleep to allow for animation
                Thread.Sleep(715);
            }

            // The stack is now empty
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Popping values off of the stack...\n");
            Console.WriteLine("\n\nStack empty!");
        }

        /// <summary>
        /// Takes in an array of values of type <typeparamref name="T"/>
        /// and constructs a MyQueue object from it while displaying
        /// an animation of the process to the console
        /// </summary>
        /// <typeparam name="T">The type of values within the queue</typeparam>
        /// <param name="values">The values to be held in the queue</param>
        /// <returns>A value tuple containing a MyQueue object with type
        /// <typeparamref name="T"/> values from <paramref name="values"/> and
        /// a string representation of that queue.</returns>
        static (MyQueue<T>, string) DemoEnqueue<T>(T[] values)
        {
            MyQueue<T> queue = new MyQueue<T>();
            StringBuilder sb = new StringBuilder();
            string firstValueString = $"[{values[0]}] ";

            // Tick through the animation one queued value at a time
            foreach (T value in values)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enqueueing MyQueue<T>...");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Front is green. ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Back is blue.\n");

                string curValueString = $"[{value}] ";

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(curValueString);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(sb.ToString());

                Console.CursorLeft -= firstValueString.Length;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(firstValueString);

                sb.Insert(0, curValueString);

                queue.Enqueue(value);

                // Sleep for 715ms for animation
                Thread.Sleep(715);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\nPeek front of queue: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{queue.Peek()}]");

            Console.ForegroundColor = ConsoleColor.White;
            return (queue, sb.ToString());
        }

        /// <summary>
        /// Demonstrates dequeueing a queue through console animation
        /// </summary>
        /// <typeparam name="T">The types of values in the queue</typeparam>
        /// <param name="queue">A queue of values to demonstrate dequeueing
        /// values from</param>
        /// <param name="queueString">A string representation of the queue</param>
        static void DemoDequeue<T>(MyQueue<T> queue, string queueString)
        {
            string[] queueStrings = queueString.Split(' ');

            while (queue.Length > 0)
            {
                // Display status message
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Dequeueing items from queue...");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Front is green. ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Back is blue.\n");

                // If there are more than 1 item, write the back in blue
                if (queue.Length > 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{queueStrings[0]} ");
                }

                // Write all non-front and non-back values in red
                Console.ForegroundColor = ConsoleColor.Red;

                for (int i = 1; i < queue.Length - 1; i++)
                {
                    Console.Write($"{queueStrings[i]} ");
                }

                // Display the front value in green
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(queueStrings[queue.Length - 1]);

                // Display stats about the queue
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\n  Length: {queue.Length}");
                Console.WriteLine($"Dequeued: {queue.Dequeue()}");

                // Sleep for 715ms for animation
                Thread.Sleep(715);
            }

            // The queue is now empty
            Console.Clear();
            Console.WriteLine("Dequeueing items from queue...");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Front is green. ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Back is blue.\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Queue is empty!");
        }
    }
}
