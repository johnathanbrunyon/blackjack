using System;

namespace Blackjack
{
    public class Player
    {
        public double bankroll
        {
            get;
            private set;
        }

        public string name
        {
            get;
            private set;
        }

        public int wins
        {
            get;
            private set;
        }

        public Player(string _name)
        {
            bankroll = 100;
            name = _name;
            wins = 0;
        }

        public double IncrementBankroll(double amt)
        {
            return bankroll += amt;
        }

        public double DecrementBankroll(double amt)
        {
            if (bankroll - amt < 0)
            {
                Console.WriteLine("You can't go into a negative balance!");
                return bankroll;
            }
            
            return bankroll -= amt;
        }

        public int IncrementWins()
        {
            return wins++;
        }
    }
}