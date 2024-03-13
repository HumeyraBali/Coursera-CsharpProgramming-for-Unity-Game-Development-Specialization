﻿using System;

namespace UsingDeckClass
{
    /// <summary>
    /// Classes and Objects lecture code
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates using a Deck class
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // declare and print a deck of cards
            Deck deck = new Deck();
            deck.Print();
        }
    }
}
