using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talia_Zwyciestwa.Classes
{
    public class Player : Fighter
    {
        private int power;
        public Player()
        {
            MaxHP = CurrentHP = 100;
            Str = 0;
            Dex = 0;
            power = 3;
        }

        public int Power { get => power; set => power = value; }
    }
}
