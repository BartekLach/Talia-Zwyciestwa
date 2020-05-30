using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Card_Types
{
    public class UpgradedAttackCard : Card
    {
        private int dmgValue = 9;
        public UpgradedAttackCard()
        {
            Value = 1;
            Name = "Uderzenie +";
            Describtion = " Zadaj (" + dmgValue.ToString() + " + siła) obrażeń";
            Id = 5;
        }
        override public void Effect(Player player, Enemy enemy)
        {
            enemy.GetDMG(player.CurrentStr + dmgValue);
        }
    }
}
