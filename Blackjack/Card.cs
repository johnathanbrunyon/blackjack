

namespace Blackjack
{
    public class Card
    {
        public Suit suit
        {
            get;
            private set;
        }

        public Rank rank
        {
            get;
            private set;
        }

        public Card(Suit _suit, Rank _rank)
        {
            suit = _suit;
            rank = _rank;
        }
    }
}