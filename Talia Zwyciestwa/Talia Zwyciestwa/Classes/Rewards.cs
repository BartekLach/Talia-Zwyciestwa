using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes
{
    static class Rewards
    {
        private static Random rng = new Random();
        public static int SmallReward()
        {
            int reward = rng.Next(71) + 60;
            return reward;
        }
        public static int BigReward()
        {
            int reward = rng.Next(201) + 140;
            return reward;
        }
    }
}
