using System;

namespace FloatingPointDataTypes
{
    /// <summary>
    /// Floating Point Data Types lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates floating point data types
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            int score = 1360;
            int totalSecondsPlayed = 10000;

            // calculate and print points per second
            float pointsPerSecond = (float)score / totalSecondsPlayed;
            Console.WriteLine("Points per Second: " + pointsPerSecond);
        }
    }
}
