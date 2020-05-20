using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Card_Types
{
    class UpgradeDexElixirCard : Card
    {
        private int dexValue = 2;
        public UpgradeDexElixirCard()
        {
            Value = 2;
            Name = "Eliksir zręczności";
            Describtion = " Zyskaj " + dexValue.ToString() + " punktów zręczności do końca walki";
            Id = 9;
        }
        override public void Effect(Player player, Enemy enemy)
        {
            player.CurrentDex += dexValue;
        }
    }
}
