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
            for (int i = 0; i<8;i++)
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

        public List<Card> Cards { get => cards; set => cards = value; }
    }
}
