using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Card_Types
{
    public class SteroidsCard : Card
    {
        private int strValue = 2;
        public SteroidsCard()
        {
            Value = 2;
            Name = "Sterydy";
            Describtion = " Zyskaj " + strValue.ToString() + " punktów siły do końca walki";
            Id = 3;
        }
        override public void Effect(Player player, Enemy enemy)
        {
            player.CurrentStr += strValue;
        }
    }
}
