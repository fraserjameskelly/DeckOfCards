using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DeckOfCards
{
    public partial class Form1 : Form
    {
        Dealer Dealer = new Dealer();
        List<Card> Deck = new List<Card>(52);

        //Drawn is the card that's currently on the table
        Card Drawn = null;
        //Discard pile
        List<Card> Discards = new List<Card>();
        public Form1()
        {
            //init form
            InitializeComponent();
            //init a new deck of cards
            Deck = Dealer.Init();
        }

        /// <summary>
        /// Shuffle the current Deck
        /// </summary>
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            ResetIfEmpty();

            int deckCount = Deck.Count;
            Random rand = new Random();
            List<Card> sorted = new List<Card>(deckCount);

            //loop random index between 0 and 52 (the deck count)
            foreach (int rNum in Enumerable.Range(0, deckCount).OrderBy(x => rand.Next()))
            {
                var rCard = Deck[rNum];

                //add card from the random index into a new, sorted list
                sorted.Add(rCard);
            }

            //assign the 'sorted' (shuffled) list to the main deck
            Deck = sorted;
        }

        /// <summary>
        /// Sort the current Deck by Suit
        /// </summary>
        private void btnSortBySuit_Click(object sender, EventArgs e)
        {
            ResetIfEmpty();

            Deck = Deck.OrderBy(o => o.Suit).ThenBy(o => o.Index).ToList();
        }

        /// <summary>
        /// Sort the current Deck by Value (Asc)
        /// </summary>
        private void btnSortByValue_Click(object sender, EventArgs e)
        {
            ResetIfEmpty();

            Deck = Deck.OrderBy(o => o.Index).ThenBy(o => o.Suit).ToList();
        }

        /// <summary>
        /// Deal the top card onto the table
        /// </summary>
        private void btnDraw_Click(object sender, EventArgs e)
        {
            //if there is a card on the table, and still remaining cards in the Deck
            if (Drawn != null && Deck.Count > 0)
            {
                //add current card to the discard pile
                Discards.Add(Drawn);
                lblDiscards.Text = Discards.Count + " cards in discard pile";
            }

            //if there are still cards in the Deck
            if (Deck.Count > 0)
            {
                //grab the first one, and remove from the Deck
                Drawn = Deck.First();
                Deck.RemoveAt(0);

                //render image of the drawn card
                picDrawn.Image = Image.FromFile(
                  Path.Combine(
                     Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                     "Images/" + Drawn.Image + ".png"));
                picDrawn.SizeMode = PictureBoxSizeMode.Zoom;

                //if there are no cards left in the Deck
                if (Deck.Count == 0)
                {
                    //hide draw button and notify the user
                    btnDraw.Visible = false;
                    lblMessage.Text = "End of deck. Please re-shuffle.";
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTable();
        }

        /// <summary>
        /// Reloads and repopulates the 52-card deck, and resets all notifications
        /// </summary>
        private void ClearTable()
        {
            Deck = Dealer.Init();
            Discards.Clear();
            Drawn = null;

            btnDraw.Visible = true;
            picDrawn.Image = null;
            lblDiscards.Text = "0 cards in discard pile";
            lblMessage.Text = string.Empty;
        }

        private void ResetIfEmpty()
        {
            if (Deck.Count == 0)
            {
                ClearTable();
            }
        }
    }
}
