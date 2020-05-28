using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Items.Helmets
{
    public class LightHelmet : Helmet
    {
        public static int Def = 2;
        public static int Str = 2;
        public LightHelmet()
        {
            DefValue = Def;
            StrValue = Str;
        }
    }
}
