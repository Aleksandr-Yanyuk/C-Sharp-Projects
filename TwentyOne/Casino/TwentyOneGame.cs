using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        //override allows us to implement the inherited abstract method from the Game class
        public override void Play()
        {
            //instantiates new dealer object
            Dealer = new TwentyOneDealer();
            //Reset the players who are at this game.
            //"Players" is a property of the game class (list of players)
            foreach (Player player in Players)
            {
                //hand resets to new list, old hand wont carry over
                player.Hand = new List<Card>();
                //if stay was false, then would carry over and effect things
                player.Stay = false;
            }
            //resets dealers hand
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            //new deck created each time, if we didnt do this,
            //each deck would become a partial deck and,
            //have influence on the next deck.
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();

            //Loops through each player to place their bets
            foreach(Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
                }
                if (bet < 0)
                {
                    throw new FraudException("Security! Kick this person out.");
                }
                //create succesfullyBet, calling Bet method on player, passing in bet (players bet)
                bool successfullyBet = player.Bet(bet);
                //!successfullyBet means succesfullyBet == false;
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            //loops through twice for two cards
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                //dealing cards to the players
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    //if 2nd card (2nd turn) 1 being second number or index
                    if (i == 1)
                    {
                        //passes players hand to check for blackjack
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if(blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            //wins their bet * 1.5
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            //ends round here, for simplicity
                            return;
                        }
                    }
                }
                //Deals dealers hand
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        //iterates through the dictionary
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            //assigns all values from players to the dealer
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                //while player is not staying
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    //iterates through player hand showing what their cards are
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        //stops loop if player says stays
                        break;
                    }
                    else if (answer == "hit")
                    {
                        //if player hits, player hand is passed in and they're given a card
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            //Checks if dealer is busted
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                //check for busted, if busted while becomes true and breaks
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                //check for stay, if stay while becomes true and breaks
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            //after while loop breaks perform one of two if statements below based on stay or bust
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            //if busted, dealer loses, gives players winnings
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer is Busted!");
                //for everyone of theses key value pairs (Player, int),
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    //write to console who won (entry.Key.Name) and how much (entry.Value).
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    //gives money to players balance,
                    //Where their name = the name in the dictionary,
                    //gives money back and their winnings
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    //removes money from dealer balance
                    Dealer.Balance -= entry.Value;
                }
                //ends round here
                return;
            }
            foreach (Player player in Players)
            {
                //'?' turns the bool data type playerWon allowing it to have a null value
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                //if player and dealer tie null is true and if statement commits
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    //returns players bet
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
