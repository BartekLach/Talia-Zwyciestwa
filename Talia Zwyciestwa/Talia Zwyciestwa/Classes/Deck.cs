using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Talia_Zwyciestwa.Classes.Card_Types;

namespace Talia_Zwyciestwa.Classes
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck()
        {
            for (int i = 0; i < 8; i++)
            {
                Cards.Add(new AttackCard());
                Cards.Add(new DefCard());
            }
            for (int i = 0; i < 2; i++)
            {
                Cards.Add(new DexElixirCard());
                Cards.Add(new SteroidsCard());
                Cards.Add(new Parry());
            }
        }
        public void Write()
        {
            int[] cardTypes = new int[10];
            for (int i = 0; i < 10; i++)
                cardTypes[i] = 0;
            foreach (Card card in cards)
                cardTypes[card.Id]++;
            MessageBox.Show("Karty ataku: " + cardTypes[0].ToString() + " Karty obrony: " + cardTypes[1].ToString() + " Karty riposty: " + cardTypes[2].ToString() + " Karty sterydów: " + cardTypes[3].ToString() + " Karty eliksiru zręczności: " + cardTypes[4].ToString() + " Karty ataku+: " + cardTypes[5].ToString() + " Karty obrony+: " + cardTypes[6].ToString() + " Karty riposty+: " + cardTypes[7].ToString() + " Karty sterydów+: " + cardTypes[8].ToString() + " Karty eliksiru zręczności+: " + cardTypes[9].ToString() + " Łącznie " + cards.Count.ToString());
        }

        public List<Card> Cards { get => cards; set => cards = value; }
    }
}
