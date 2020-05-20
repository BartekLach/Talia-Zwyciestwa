using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talia_Zwyciestwa.Classes.Card_Types
{
    public class AttackCard : Card
    {
        private int dmgValue = 5;
        public AttackCard()
        {
            Value = 1;
            Name = "Uderzenie";
            Describtion = " Zadaj (" + dmgValue.ToString() + " + siła) obrażeń";
            Id = 0;
        }
        override public void Effect(Player player, Enemy enemy)
        {
            enemy.GetDMG(player.CurrentStr + dmgValue);
        }
    }
}
