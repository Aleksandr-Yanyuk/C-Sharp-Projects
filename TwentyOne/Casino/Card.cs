using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //public makes it accessible to other parts of the program class
    public struct Card
    {   
        //property of data type string called Suit, that you can get or set this property
        public Suit Suit{ get; set; }
        public Face Face { get; set; }

        //custom ToString(), prints to console the 'face of suit'
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
