using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Card_Types
{
    public class AttackCard : Card
    {
        public AttackCard()
        {
            Value = 1;
            Name = "Uderzenie";
        }
        override public void Efect(Player player)
        {
            //TODO
        }
    }
}
