using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Items.Weapons
{
    public class MediumWeapon : Weapon
    {
        public static int Def = -3;
        public static int Str = 7;
        public MediumWeapon()
        {
            DefValue = Def;
            StrValue = Str;
        }
    }
}
