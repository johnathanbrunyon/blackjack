using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Hand
    {
        // TODO: Put a card in the players hand
        
        public int value
        {
            get;
            private set;
        }

        public bool Dealer
        {
            get;
            private set;
        }

        public List<Card> cardsInHand
        {
            get;
            private set;
        }

        public Hand(bool isDealer = false)
        {
            value = 0;
            Dealer = isDealer;
            cardsInHand = new List<Card>();
        }

        public int IncrementValue(int amt)
        {
            return value += amt;
        }

        public void PrintHand()
        {
            if (cardsInHand.Count == 0)
            {
                Console.WriteLine("No cards in hand.");
                return;
            }
                
            if (Dealer == false)
            {
                foreach (Card card in cardsInHand)
                {
                    Console.Write($"{card.rank} {card.suit}");
                }
            }
            else
            {
                Console.WriteLine($"{cardsInHand[0].rank} {cardsInHand[0].suit}");
            }
        }

        public void Deal(Deck dk)
        {
            Card card = dk.DealCard();
            cardsInHand.Add(card);
        }

        public int CardValue(Card card)
        {
            switch (card.rank)
            {
                case Rank.Ace:
                    return 1;
                case Rank.Two:
                    return 2;
                case Rank.Three:
                    return 3;
                case Rank.Four:
                    return 4;
                case Rank.Five:
                    return 5;
                case Rank.Six:
                    return 6;
                case Rank.Seven:
                    return 7;
                case Rank.Eight:
                    return 8;
                case Rank.Nine:
                    return 9;
                case Rank.Ten:
                    return 10;
                case Rank.Jack:
                    return 10;
                case Rank.Queen:
                    return 10;
                case Rank.King:
                    return 10;
            }

            return 0;
        }
    }
}