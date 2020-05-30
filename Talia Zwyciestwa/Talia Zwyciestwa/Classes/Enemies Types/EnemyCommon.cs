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
            MaxHP = CurrentHP = 70;
            Str = CurrentStr = 5;
            Dex = CurrentDex = 5;
            CurrentPO = 7;
        }



        override public void MakeTurn(Player player)
        {
            Random random = new Random();
            player.GetDMG(random.Next(2, 5) + CurrentStr);
            CurrentStr += random.Next(2);
            CurrentPO = random.Next(2, 5) + CurrentDex;
            CurrentDex += random.Next(2);

            if (random.Next(101) < 20)//20%
                CurrentHP += MaxHP / 10;

        } 
    }
}
