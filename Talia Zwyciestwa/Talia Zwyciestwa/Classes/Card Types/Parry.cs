using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Card_Types
{
    class Parry : Card
    {
        private int defValue = 4;
        private int dmgValue = 4;
        public Parry()
        {
            Value = 2;
            Name = "Paruj";
            Describtion = "Zadaj ( " + dmgValue.ToString() + " + siła) obrażeń i zyskaj" + dmgValue.ToString() + " + zręczność) punktów obrony";
        }

        override public void Effect(Player player, Enemy enemy)
        {
            enemy.GetDMG(dmgValue + player.CurrentStr);
            player.CurrentPO += defValue + player.CurrentDex;
        }
    }
}
