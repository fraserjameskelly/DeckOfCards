using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class CardHelper
    {
        public static Colour GetColour(Suit suit)
        {
            switch(suit)
            {
                case Suit.Clubs:
                case Suit.Spades:
                    return Colour.Black;
                case Suit.Hearts:
                case Suit.Diamonds:
                    return Colour.Red;
                default:
                    return Colour.Unset;
            }
        }
    }
}
