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
        private int currentDex;
        private int currentStr;
        private int currentPO;
        public int CurrentHP { get => currentHP; set => currentHP = value; }
        public int MaxHP { get => maxHP; set => maxHP = value; }
        public int Dex { get => dex; set => dex = value; }
        public int Str { get => str; set => str = value; }
        public int CurrentDex { get => currentDex; set => currentDex = value; }
        public int CurrentStr { get => currentStr; set => currentStr = value; }
        public int CurrentPO { get => currentPO; set => currentPO = value; }
        public void GetDMG(int dmg)
        {
            currentPO -= dmg;
            if(currentPO<0)
            {
                currentHP += currentPO;
                currentPO = 0;
            }
        }
    }
}
