using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes
{
    abstract class Card
    {
        private int value;
        public int Value { get => value; set => this.value = value; }

        abstract public void Efect();
    }

}
