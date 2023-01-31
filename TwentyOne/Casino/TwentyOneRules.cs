using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneRules
    {
        //private to TwentyOneRules
        //static so we don't have to create a TwentyOneRule object to access this method
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 2,
            [Face.Four] = 2,
            [Face.Five] = 2,
            [Face.Six] = 2,
            [Face.Seven] = 2,
            [Face.Eight] = 2,
            [Face.Nine] = 2,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1,
        };

        //passes in a Hand (list of cards) returns an integer array of all possible values
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            //gets how many aces are in hand because that determines how man possible values there are,
            //Aces are worth either 1 or 11
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            int[] result = new int[aceCount + 1];
            //Takes each item and looks it up in the _cardValues dictionary table and sum it
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1)
            {
                return result;
            }
            //if the if statement is missed this statement is hit (we know result > 1)
            for (int i = 1; i < result.Length; i++)
            {
                //value is the lowest possible value,
                value += + (i * 10);
                result[i] = value;
            }
            //end return all results
            return result;
        }   

        //Checks if theres a Ace paired with a face card with the value of Ten (Ten, Jack, Queen, King)
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            //getting maximum possible value
            int value = possibleValues.Max();
            //21 being the maximum allowed value
            if (value == 21) return true;
            else return false;
        }

        //checks if the hand is busted (over 21); passes in the Hand (List<Card>)
        public static bool IsBusted(List<Card> Hand)
        {
            //if min value busts all values busted
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                //if meet criteria dealer stays
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }
        
        //this method returns a nullable boolean
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            //gives list of result where playerResults is less than 22 and the largest value it has
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            //player beats dealer
            if (playerScore > dealerScore) return true;
            //player loses to dealer (dealer beats player)
            else if (playerScore < dealerScore) return false;
            //if they have equal values
            else return null;
        }
    }
}
