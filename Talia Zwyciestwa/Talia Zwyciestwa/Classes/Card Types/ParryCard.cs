using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Card_Types
{
    class ParryCard : Card
    {
        private int defValue = 5;
        private int dmgValue = 5;
        public ParryCard()
        {
            Value = 2;
            Name = "Riposta";
            Describtion = "Zadaj ( " + dmgValue.ToString() + " + siła) obrażeń i zyskaj " + dmgValue.ToString() + " + zręczność) punktów obrony";
            Id = 2;
        }

        override public void Effect(Player player, Enemy enemy)
        {
            enemy.GetDMG(dmgValue + player.CurrentStr);
            player.CurrentPO += defValue + player.CurrentDex;
        }
    }
}
