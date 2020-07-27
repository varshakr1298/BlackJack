using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// BlackJack Program
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
            Console.WriteLine("Welcome Users, To the play of a deck of cards!");
            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();
            //deck.Print();
            Console.WriteLine();
            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card card1ForPlayer1 = deck.TakeTopCard();
            Card card1ForPlayer2 = deck.TakeTopCard();
            Card card1ForPlayer3 = deck.TakeTopCard();
            Card card2ForPlayer1 = deck.TakeTopCard();
            Card card2ForPlayer2 = deck.TakeTopCard();
            Card card2ForPlayer3 = deck.TakeTopCard();
            // flip all the cards over
            card1ForPlayer1.FlipOver();
            card1ForPlayer2.FlipOver();
            card1ForPlayer3.FlipOver();
            card2ForPlayer1.FlipOver();
            card2ForPlayer2.FlipOver();
            card2ForPlayer3.FlipOver();
            // print the cards for player 1
            Console.WriteLine("Cards of Player 1:");
            Console.WriteLine("Rank " + card1ForPlayer1.Rank + " of Suit " + card1ForPlayer1.Suit);
            Console.WriteLine("Rank " + card2ForPlayer1.Rank + " of Suit " + card2ForPlayer1.Suit);
            Console.WriteLine();
            // print the cards for player 2
            Console.WriteLine("Cards of Player 2:");
            Console.WriteLine("Rank " + card1ForPlayer2.Rank + " of Suit " + card1ForPlayer2.Suit);
            Console.WriteLine("Rank " + card2ForPlayer2.Rank + " of Suit " + card2ForPlayer2.Suit);
            Console.WriteLine();
            // print the cards for player 3
            Console.WriteLine("Cards of Player 3:");
            Console.WriteLine("Rank " + card1ForPlayer3.Rank + " of Suit " + card1ForPlayer3.Suit);
            Console.WriteLine("Rank " + card2ForPlayer3.Rank + " of Suit " + card2ForPlayer3.Suit);
            Console.WriteLine();
        }
    }
}
