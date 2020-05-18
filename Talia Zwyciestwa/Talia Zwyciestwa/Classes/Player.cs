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
        private int money;
        public Player()
        {
            MaxHP = CurrentHP = 1;
            Str = 0;
            Dex = CurrentDex = 0;
            power = CurrentHP = 3;
            CurrentPO = 0;
        }

        public int Power { get => power; set => power = value; }
        public int Money { get => money; set => money = value; }
    }
}
