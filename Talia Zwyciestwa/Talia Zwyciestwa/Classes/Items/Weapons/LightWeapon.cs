using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Items.Weapons
{
    public class LightWeapon : Weapon
    {
        public static int Def = -1;
        public static int Str = 4;
        public LightWeapon()
        {
            DefValue = Def;
            StrValue = Str;
        }
    }
}
