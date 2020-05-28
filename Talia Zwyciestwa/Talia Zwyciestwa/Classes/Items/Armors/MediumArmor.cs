using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Items.Armors
{
    public class MediumArmor : Armor
    {
        public static int Def = 6;
        public static int Str = -1;
        public MediumArmor()
        {
            DefValue = Def;
            StrValue = Str;
        }
    }
}
