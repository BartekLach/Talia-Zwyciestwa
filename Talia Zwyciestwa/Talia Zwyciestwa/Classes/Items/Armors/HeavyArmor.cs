using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Items.Armors
{
    public class HeavyArmor :Armor
    {
        public static int Def = 9;
        public static int Str = -3;
        public HeavyArmor()
        {
            DefValue = Def;
            StrValue = Str;
        }
    }
}
