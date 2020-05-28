using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Items.Armors
{
    public class LightArmor : Armor
    {
        public static int Def = 4;
        public static int Str = 1;
        public LightArmor()
        {
            DefValue = Def;
            StrValue = Str;
        }
    }
}
