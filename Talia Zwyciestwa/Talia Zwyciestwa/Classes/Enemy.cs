using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes
{
    abstract public class Enemy : Fighter
    {
        abstract public void MakeTurn(Player player);
    }
}
