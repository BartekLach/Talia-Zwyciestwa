using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Items.Armors
{
    abstract public class Armor
    {
        private int def;
        private int str;

        public int Def { get => def; set => def = value; }
        public int Str { get => str; set => str = value; }
    }
}
