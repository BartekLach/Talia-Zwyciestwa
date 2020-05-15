using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talia_Zwyciestwa.Classes
{
    class GameHandler
    {
        public static void Load()
        {
            if (File.Exists("save.txt"))
            {
                //TODO
            }
            else
                MessageBox.Show("Brak zapisu gry");
        }
        public static void Play()
        {
            //TODO
        }
    }
}
