using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Items.Shields
{
    public class HeavyShield : Shield
    {
        public static int Def = 5;
        public static int Str = 2;
        public HeavyShield()
        {
            DefValue = Def;
            StrValue = Str;
        }
    }
}
