using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CasinoHell
{
    public struct Card
    {
        
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        public override string ToString()
        {
            string card = string.Format("{0} of ", Face);
            switch (Suit)
            {
                case Suit.Spades:
                    card += "♠";
                    break;
                case Suit.Clubs:
                    card += "♣";
                    break;
                case Suit.Hearts:
                    card += "♥";
                    break;
                case Suit.Diamonds:
                    card += "♦";
                    break;
            }
            return card;
        }

    }

    public enum Suit
    {
        Spades,
        Clubs,
        Hearts,
        Diamonds
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
