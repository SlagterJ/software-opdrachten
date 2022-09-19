using System;

namespace TrafficLight
{
    public static class LazyFunctions
    {
        /// <summary>
        /// Writes a line to the console.
        /// </summary>
        /// <param name="msg">Message to write.</param>
        public static void Wl(string msg)
        {
            Console.WriteLine(msg);
        }

        /// <summary>
        /// Reads a line from the console.
        /// </summary>
        /// <returns>User input string.</returns>
        public static string Rl()
        {
            string input = Console.ReadLine();
            return input;
        }

        /// <summary>
        /// Writes a line to the console, then reads a line from the console.
        /// </summary>
        /// <param name="msg">Message to write.</param>
        /// <returns>User input string.</returns>
        public static string Wr(string msg)
        {
            Wl(msg);
            string input = Rl();
            return input;
        }
    }
}
