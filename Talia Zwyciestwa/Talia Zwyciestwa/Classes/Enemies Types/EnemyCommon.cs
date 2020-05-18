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
            MaxHP = CurrentHP = 30;
            Str = CurrentStr = 4;
            Dex = 3;
            CurrentPO = 0;
        }



        override public void MakeTurn(Player player)
        {
            Random random = new Random();
            player.GetDMG(random.Next(3, 6) + CurrentStr);
            CurrentStr += random.Next(2);
            CurrentPO = random.Next(3, 6) + CurrentDex;
            CurrentDex += random.Next(2);

        }
    }
}
