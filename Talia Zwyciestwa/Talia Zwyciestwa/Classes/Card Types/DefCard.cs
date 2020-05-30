using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talia_Zwyciestwa.Classes.Card_Types
{
    public class DefCard : Card
    {
        private int defValue = 4;
        public DefCard()
        {
            Value = 1;
            Name = "Broń się";
            Describtion = "Zyskaj ( " + defValue.ToString() + " + zręczność) punktów obrony";
            Id = 1;
        }

        override public void Effect(Player player,Enemy enemy)
        {
            player.CurrentPO += defValue + player.CurrentDex;
        }
    }
}
