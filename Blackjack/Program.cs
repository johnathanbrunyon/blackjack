using System;
using System.Collections.Generic;
using static Blackjack.Deck;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to blackjack!");
            Console.WriteLine("1. Play");
            Console.WriteLine("2. See Deck");
            Console.WriteLine("3. Exit");
            Deck dk = new Deck();
            dk.PopulateDeck();
            dk.ShuffleDeck();
            dk.PrintDeck();
        }
    }
}