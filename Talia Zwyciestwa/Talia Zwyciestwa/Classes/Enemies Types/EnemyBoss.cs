using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Enemies_Types
{
    class EnemyBoss : Enemy
    {
        public EnemyBoss()
        {
            MaxHP = CurrentHP = 250;
            Str = CurrentStr = 9;
            Dex = CurrentDex = 9;
            CurrentPO = 15;
        }



        override public void MakeTurn(Player player)
        {
            Random random = new Random();
            player.GetDMG(random.Next(7, 10) + CurrentStr);
            CurrentStr += random.Next(4);
            CurrentPO = random.Next(7, 10) + CurrentDex;
            CurrentDex += random.Next(4);

            if (random.Next(101) < 20 && CurrentHP < MaxHP / 10)//20%
                CurrentHP += MaxHP / 10;

        }
    }
}
