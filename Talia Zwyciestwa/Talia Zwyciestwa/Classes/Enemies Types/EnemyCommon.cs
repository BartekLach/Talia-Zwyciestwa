using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talia_Zwyciestwa.Classes.Enemies_Types
{
    class EnemyCommon : Enemy
    {
        public EnemyCommon()
        {
            MaxHP = CurrentHP = 40; //TODO: CHANGE THAT! DEBUG ONLY
            Str = CurrentStr = 1;
            Dex = 2;
            CurrentPO = 0;
        }



        override public void MakeTurn(Player player)
        {
            Random random = new Random();
            player.GetDMG(random.Next(1, 3) + CurrentStr);
            //int rng = random.Next(1, 100);
            CurrentStr += random.Next(2);
            CurrentStr = Math.Max(CurrentStr, 5);
            CurrentPO = random.Next(1, 3) + CurrentDex;
            CurrentDex += random.Next(2);
            CurrentDex = Math.Max(CurrentDex, 5);
        }
    }
}
