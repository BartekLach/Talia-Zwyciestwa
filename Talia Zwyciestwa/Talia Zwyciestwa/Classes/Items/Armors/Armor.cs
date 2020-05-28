using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes.Items.Armors
{
    abstract public class Armor
    {
        private int defValue;
        private int strValue;

        public int DefValue { get => defValue; set => defValue = value; }
        public int StrValue { get => strValue; set => strValue = value; }
    }
}
