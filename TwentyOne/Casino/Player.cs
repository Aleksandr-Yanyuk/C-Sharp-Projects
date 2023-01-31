using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        //assign name to name and defaults a value of 100 if no value is given
        public Player(string name) : this(name, 100)
        {

        }
        //Constructor with two parameters, 1 of data type string and other integer
        public Player(string name, int beginningBalance)
        {
            //assign some values
            //initialized this property
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }

        public bool Bet(int amount)
        {
            //if difference is less than 0, player cannot play
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have neough to place a bet that size.");
                return false;
            }
            //if difference greater than 0, player can still play
            else
            {
                Balance -= amount;
                return true;
            }
        }
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
