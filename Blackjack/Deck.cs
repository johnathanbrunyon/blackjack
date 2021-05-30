using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using static Blackjack.Suit;    
using static Blackjack.Rank;    

namespace Blackjack
{
    public class Deck
    {
        
        private List<Card> cards
        {
            get;
            set;
        }


        public Deck()
        {
            cards = new List<Card>();
            PopulateDeck();
            ShuffleDeck();
        }

        public void PopulateDeck()
        {
            foreach (Suit suit in (Suit[]) Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in (Rank[]) Enum.GetValues(typeof(Rank)))
                {
                    Card card = new Card(suit, rank);
                    cards.Add(card);
                }
            }
        }
        
        public void PrintDeck()
        {
            foreach (Card card in cards)
            {
                Console.Write($"{card.rank} {card.suit}\n");
            }
        }
        
        static Random _random = new Random();

        public void ShuffleDeck()
        {
            int n = cards.Count;
            
            for (int i = 0; i < (n - 1); i++)
            {
                int r = i + _random.Next(n - i);
                Card t = cards[r];
                cards[r] = cards[i];
                cards[i] = t;
            }
        }

        public Card DealCard()
        {
            Card topCard = cards[0];
            cards.RemoveAt(0);
            cards.TrimExcess();
            return topCard;
        }

        // public int CardValues(List<Card> cardsInHand)
        // {
        //     foreach (Card card in cardsInHand)
        //     {
        //         
        //     }
        //     Card cards = DealCard();
        //     
        //
        //     return 0;
        // }
    }
}