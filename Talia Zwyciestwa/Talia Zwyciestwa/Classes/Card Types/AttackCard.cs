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
        private int dmgOfCard = 5;
        public AttackCard()
        {
            Value = 1;
            Name = "Uderzenie";
        }
        override public void Effect(Player player, Enemy enemy)
        {
            enemy.GetDMG(player.CurrentStr + dmgOfCard);
            //MessageBox.Show("Enemy HP: " + enemy.CurrentHP.ToString());
            //TODO
        }
    }
}
