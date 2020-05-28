using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Items.Weapons
{
    public class HeavyWeapon : Weapon
    {
        public static int Def = -7;
        public static int Str = 14;
        public HeavyWeapon()
        {
            DefValue = Def;
            StrValue = Str;
        }
    }
}
