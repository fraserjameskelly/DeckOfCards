using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    /// <summary>
    /// Helper class for any additional functions
    /// </summary>
    public class CardHelper
    {
        /// <summary>
        /// Find the colour of a suit
        /// </summary>
        /// <param name="suit">The suit that you want to find the colour of</param>
        /// <returns>The colour of the given suit</returns>
        public static Colour GetColour(Suit suit)
        {
            switch(suit)
            {
                case Suit.Clubs:
                case Suit.Spades:
                default:
                    return Colour.Black;
                case Suit.Hearts:
                case Suit.Diamonds:
                    return Colour.Red;
            }
        }
    }
}
