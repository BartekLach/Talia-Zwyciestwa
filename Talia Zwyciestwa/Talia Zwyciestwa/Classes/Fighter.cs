using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes
{
    abstract class Fighter
    {
        private int currentHP;
        private int maxHP;
        private int dex;
        private int str;

        public void ChangeHP(int HP)
        {
            currentHP += HP;
        }
    }
}
