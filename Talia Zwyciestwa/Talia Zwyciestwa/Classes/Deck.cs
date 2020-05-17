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
        public List<Card> deck = new List<Card>();
        public Deck()
        {
            for (int i = 0; i<10;i++)
            {
                deck.Add(new AttackCard());
                deck.Add(new DefCard());
            }
            //MessageBox.Show("Utworzono deck");
            //for(int i =0; i<deck.Count();i++)
            //{
            //    MessageBox.Show(deck[i].Name + deck[i].Value);
            //}
        }
    }
}
