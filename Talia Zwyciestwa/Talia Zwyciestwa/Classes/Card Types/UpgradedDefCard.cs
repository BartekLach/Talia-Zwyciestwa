using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Card_Types
{
    class UpgradedDefCard : Card
    {
        private int defValue = 7;
        public UpgradedDefCard()
        {
            Value = 1;
            Name = "Uderzenie +";
            Describtion = " Zadaj (" + defValue.ToString() + " + siła) obrażeń";
            Id = 6;
        }
        override public void Effect(Player player, Enemy enemy)
        {
            player.CurrentPO += defValue;
        }
    }
}
