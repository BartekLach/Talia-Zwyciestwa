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
    class GameHandler
    {
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
            if (menu is null)
            {
                throw new ArgumentNullException(nameof(menu));
            }
            Map map = new Map();
            menu.Hide();
            map.Show();
        }
    }
}
