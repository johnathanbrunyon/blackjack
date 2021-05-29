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

        public Player(double _bankroll, string _name)
        {
            bankroll = _bankroll;
            name = _name;
        }

        public double IncrementBankroll(double amt)
        {
            return bankroll + amt;
        }

        public double DecrementBankroll(double amt)
        {
            if (bankroll - amt < 0)
            {
                Console.WriteLine("You can't go into a negative balance!");
            }
            
            return bankroll - amt;
        }
    }
}