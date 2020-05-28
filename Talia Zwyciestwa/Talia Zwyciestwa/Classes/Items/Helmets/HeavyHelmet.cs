using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Items.Helmets
{
    public class HeavyHelmet : Helmet
    {
        public static int Def = 4;
        public static int Str = 3;
        public HeavyHelmet()
        {
            DefValue = Def;
            StrValue = Str;
        }
    }
}
