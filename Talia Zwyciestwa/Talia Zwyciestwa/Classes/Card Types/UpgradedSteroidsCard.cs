using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Card_Types
{
    public class UpgradedSteroidsCard : Card
    {
        private int strValue = 3;
        public UpgradedSteroidsCard()
        {
            Value = 1;
            Name = "Sterydy +";
            Describtion = " Zyskaj " + strValue.ToString() + " punktów siły do końca walki";
            Id = 8;
        }
        override public void Effect(Player player, Enemy enemy)
        {
            player.CurrentStr += strValue;
        }
    }
}
