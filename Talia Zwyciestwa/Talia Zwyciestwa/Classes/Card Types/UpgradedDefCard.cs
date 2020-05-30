using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Card_Types
{
    class UpgradedDefCard : Card
    {
        private int defValue = 9;
        public UpgradedDefCard()
        {
            Value = 1;
            Name = "Broń się +";
            Describtion = "Zyskaj (" + defValue.ToString() + " + zręczność) punktów obrony";
            Id = 6;
        }
        override public void Effect(Player player, Enemy enemy)
        {
            player.CurrentPO += defValue + player.CurrentDex;
        }
    }
}
