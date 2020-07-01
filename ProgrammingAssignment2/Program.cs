using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome to the game!");

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card firstOne = deck.TakeTopCard();
            Card firstTwo = deck.TakeTopCard();
            Card secondOne = deck.TakeTopCard();
            Card secondTwo = deck.TakeTopCard();
            Card thirdOne = deck.TakeTopCard();
            Card thirdTwo = deck.TakeTopCard();




            // flip all the cards over
            firstOne.FlipOver();
            firstTwo.FlipOver();
            secondOne.FlipOver();
            secondTwo.FlipOver();
            thirdOne.FlipOver();
            thirdTwo.FlipOver();

            Console.WriteLine("Player One:");
            // print the cards for player 1
            Console.WriteLine(firstOne.Rank + " for " + firstOne.Suit);
            Console.WriteLine(firstTwo.Rank + " for " + firstTwo.Suit);
            Console.WriteLine("Player Two:");
            // print the cards for player 2
            Console.WriteLine(secondOne.Rank + " for " + secondOne.Suit);
            Console.WriteLine(secondTwo.Rank + " for " + secondTwo.Suit);
            Console.WriteLine("Player Three:");
            // print the cards for player 3
            Console.WriteLine(thirdOne.Rank + " for " + thirdOne.Suit);
            Console.WriteLine(thirdTwo.Rank + " for " + thirdTwo.Suit);

            Console.WriteLine();
        }
    }
}
