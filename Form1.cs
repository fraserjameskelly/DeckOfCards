using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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

        private void btnSortBySuit_Click(object sender, EventArgs e)
        {
            ResetIfEmpty();

            Deck = Deck.OrderBy(o => o.Suit).ThenBy(o => o.Index).ToList();
        }

        private void btnSortByValue_Click(object sender, EventArgs e)
        {
            ResetIfEmpty();

            Deck = Deck.OrderBy(o => o.Index).ThenBy(o => o.Suit).ToList();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (Drawn != null)
            {
                Discards.Add(Drawn);
            }

            if (Deck.Count > 0)
            {
                Drawn = Deck.First();
                Deck.RemoveAt(0);

                picDrawn.Image = Image.FromFile(
                  Path.Combine(
                     Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                     "Images/" + Drawn.Image + ".png"));
                picDrawn.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                lblMessage.Text = "End of deck. Please re-shuffle.";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTable();
        }

        private void ClearTable()
        {
            Deck = Dealer.Init();
            Discards.Clear();
            Drawn = null;

            picDrawn.Image = null;
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
