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
            MaxHP = CurrentHP = 90; //TODO: CHANGE THAT! DEBUG ONLY
            Str = CurrentStr = 6;
            Dex = CurrentDex = 5;
            CurrentPO = 0;
        }



        override public void MakeTurn(Player player)
        {
            Random random = new Random();
            player.GetDMG(random.Next(5, 7) + CurrentStr);
            CurrentStr += random.Next(3);
            CurrentPO = random.Next(5, 7) + CurrentDex;
            CurrentDex += random.Next(3);
        }
    }
}
