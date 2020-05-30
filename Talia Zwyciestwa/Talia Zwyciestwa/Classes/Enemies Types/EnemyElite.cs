using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Enemies_Types
{
    class EnemyElite : Enemy
    {
        public EnemyElite()
        {
            MaxHP = CurrentHP = 110;
            Str = CurrentStr = 6;
            Dex = CurrentDex = 5;
            CurrentPO = 10;
        }



        override public void MakeTurn(Player player)
        {
            Random random = new Random();
            player.GetDMG(random.Next(4, 6) + CurrentStr);
            CurrentStr += random.Next(3);
            CurrentPO = random.Next(4, 6) + CurrentDex;
            CurrentDex += random.Next(3);

            if (random.Next(101) < 20 && CurrentHP < MaxHP/10)//20%
                CurrentHP += MaxHP/10;

        }
    }
}
