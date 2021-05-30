using System;
using System.Collections.Generic;
using static Blackjack.Deck;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck dk = new Deck();
            Player p = new Player("Blake");
            p.hand.Deal(dk);
            foreach (Card card in p.hand.cardsInHand)
            {
                Console.WriteLine(p.hand.CardValue(card));
                p.hand.IncrementValue(p.hand.CardValue(card));
            }
            
            Console.WriteLine($"Hand value: {p.hand.value}");
            p.hand.PrintHand();
        }
    }
}