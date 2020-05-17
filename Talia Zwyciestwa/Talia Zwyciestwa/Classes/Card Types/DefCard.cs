using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Card_Types
{
    public class DefCard : Card
    {
        public DefCard()
        {
            Value = 1;
            Name = "Broń się";
        }

        override public void Efect(Player player)
        {
            //TODO
        }
    }
}
