﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Card_Types
{
    class UpgradedParryCard : Card
    {
            private int defValue = 4;
            private int dmgValue = 4;
            public UpgradedParryCard()
            {
                Value = 1;
                Name = "Riposta";
                Describtion = "Zadaj ( " + dmgValue.ToString() + " + siła) obrażeń i zyskaj" + dmgValue.ToString() + " + zręczność) punktów obrony";
                Id = 7;
            }

            override public void Effect(Player player, Enemy enemy)
            {
                enemy.GetDMG(dmgValue + player.CurrentStr);
                player.CurrentPO += defValue + player.CurrentDex;
            }
    }
}
