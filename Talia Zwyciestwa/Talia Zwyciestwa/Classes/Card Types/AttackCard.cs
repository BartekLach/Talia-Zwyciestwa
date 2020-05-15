using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Card_Types
{
    class AttackCard : Card
    {
        private int value;

        public int Value { get => value; set => this.value = value; }

        override public void Efect()
        {
            //TODO:
        }
    }
}
