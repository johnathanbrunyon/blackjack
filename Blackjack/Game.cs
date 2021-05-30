namespace Blackjack
{
    public class Game
    {
        public int pScore
        {
            get;
            internal set;
        }
        
        public int dScore
        {
            get;
            private set;
        }

        public Deck dk
        {
            get;
            private set;
        }

        public Game()
        {
            pScore = 0;
            dScore = 0;
            dk = new Deck();
            dk.PopulateDeck();
            dk.ShuffleDeck();
        }

        public int IncrementScore(int amt, bool isDealer = false)
        {
            if (isDealer)
            {
                return dScore += amt;
            }

            return pScore += amt;
        }
        
        
    }
}