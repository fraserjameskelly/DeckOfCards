using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    /// <summary>
    /// Helper class to setup the initial 52-card Deck
    /// </summary>
    public class Dealer
    {
        public List<Card> Init()
        {
            var deck = new List<Card>();

            //enumerate each suit and add each value to the Deck
            foreach (Suit suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                deck.AddRange(AddSuit(suit));
            }

            return deck;
        }

        /// <summary>
        /// Create a list of 13 cards for each value in a suit of standard cards
        /// </summary>
        /// <param name="suit">The suit of this set of Cards</param>
        /// <returns>List of 13 Cards. Values Ace, 2 - 10, and Face Cards</returns>
        private List<Card> AddSuit(Suit suit)
        {
            var suitCards = new List<Card>();

            var suitCode = suit.ToString().Substring(0, 1);

            suitCards.Add(new Card(1, 1, suit, CardHelper.GetColour(suit), "A" + suitCode, "Ace"));

            for (int i = 2; i <= 10; i++)
            {
                var image = i.ToString() + suitCode;
                suitCards.Add(new Card(i, i, suit, CardHelper.GetColour(suit), image));
            }

            suitCards.Add(new Card(11, 10, suit, CardHelper.GetColour(suit), "J" + suitCode, "Jack"));
            suitCards.Add(new Card(12, 10, suit, CardHelper.GetColour(suit), "Q" + suitCode, "Queen"));
            suitCards.Add(new Card(13, 10, suit, CardHelper.GetColour(suit), "K" + suitCode, "King"));

            return suitCards;
        }
    }
}
