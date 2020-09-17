using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public enum Suit
    {
        Clubs,
        Spades,
        Hearts,
        Diamonds
    }

    public enum Colour
    {
        Black,
        Red
    }

    /// <summary>
    /// Card model
    /// </summary>
    public class Card
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public Suit Suit { get; set; }
        public Colour Colour { get; set; }
        public string Image { get; set; }

        public Card()
        {
            Index = -1;
            Name = string.Empty;
            Value = -1;
            Image = string.Empty;
        }

        public Card(int index, int value, Suit suit, Colour colour, string image, string name = "")
        {
            Index = index;
            Name = !string.IsNullOrEmpty(name) ? name : value.ToString();
            Value = value;
            Suit = suit;
            Colour = colour;
            Image = image;
        }
    }
}
