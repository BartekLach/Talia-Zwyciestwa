using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Talia_Zwyciestwa.Forms;

namespace Talia_Zwyciestwa.Classes
{
    public static class GameHandler
    {
        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        public static void Load(Menu menu)
        {
            if (menu is null)
            {
                throw new ArgumentNullException(nameof(menu));
            }

            if (File.Exists("save.txt"))
            {
                //TODO
            }
            else
                MessageBox.Show("Brak zapisu gry");
        }
        public static void Play(Menu menu)
        {
            Map map = new Map(menu);
            menu.Hide();
            map.Show();
        }
        public static void ShowEQ(Map map)
        {
            Equipment equipment = new Equipment();
            map.Hide();
            equipment.Show();
        }
        public static void FightEngager(Map map, Enemy enemy)
        {
            Fight fight = new Fight(map,enemy);
            map.Hide();
            fight.Show();
        }
        public static void Toggler()
        {
        }
    }
}
