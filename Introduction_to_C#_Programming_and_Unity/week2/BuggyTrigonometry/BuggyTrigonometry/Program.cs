using System;

namespace BuggyTrigonometry
{
    /// <summary>
    /// Debugging a Console App lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Debugging a Console App lecture code
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            float angle;

            // prompt for and get angle
            Console.Write("Enter angle in degrees: ");
            angle = float.Parse(Console.ReadLine());

            // convert angle to radians
            angle *= MathF.PI / 180;

            // calculate and print cos and sin
            Console.WriteLine(MathF.Cos(angle));
            Console.WriteLine(MathF.Sin(angle));
        }
    }
}
