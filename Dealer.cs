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

            deck.AddRange(AddSuit(Suit.Clubs));
            deck.AddRange(AddSuit(Suit.Spades));
            deck.AddRange(AddSuit(Suit.Hearts));
            deck.AddRange(AddSuit(Suit.Diamonds));

            return deck;
        }

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
