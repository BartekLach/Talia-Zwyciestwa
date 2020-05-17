using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes
{
    abstract public class Fighter
    {
        private int currentHP;
        private int maxHP;
        private int dex;
        private int str;

        public int CurrentHP { get => currentHP; set => currentHP = value; }
        public int MaxHP { get => maxHP; set => maxHP = value; }
        public int Dex { get => dex; set => dex = value; }
        public int Str { get => str; set => str = value; }

        public void ChangeHP(int HP)
        {
            CurrentHP += HP;
        }
    }
}
