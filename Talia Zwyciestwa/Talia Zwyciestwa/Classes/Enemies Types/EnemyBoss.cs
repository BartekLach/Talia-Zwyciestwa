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
            MaxHP = CurrentHP = 1; //TODO: CHANGE THAT! DEBUG ONLY
            Str = CurrentStr = 9;
            Dex = CurrentDex = 9;
            CurrentPO = 0;
        }



        override public void MakeTurn(Player player)
        {
            Random random = new Random();
            player.GetDMG(random.Next(6, 9) + CurrentStr);
            CurrentStr += random.Next(3);
            CurrentPO = random.Next(6, 9) + CurrentDex;
            CurrentDex += random.Next(3);
        }
    }
}
