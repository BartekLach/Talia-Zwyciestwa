using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Talia_Zwyciestwa.Classes.Enemies_Types;
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

        internal static void SaveToFile(Map map)
        {

            StreamWriter sw = new StreamWriter("save.txt");

            sw.WriteLine(map.Player.Gold.ToString() + ';' + map.Player.CurrentHP.ToString());
            
            for(int i = 0; i < 2;i++)
            {
                sw.Write(map.Player.UnlockedHelmets[i].ToString() + ';');
                sw.Write(map.Player.UnlockedArmors[i].ToString() + ';');
                sw.Write(map.Player.UnlockedShields[i].ToString() + ';');
                sw.Write(map.Player.UnlockedWeapons[i].ToString() + ';');
            }
            sw.Write(map.Player.UnlockedArmors[2].ToString()+';');
            sw.Write(map.Player.UnlockedWeapons[2].ToString() + '\n');

            sw.Write(map.Player.WornHelmet.ToString() + ';' + map.Player.WornArmor.ToString() + ';' + map.Player.WornShield.ToString() + ';' + map.Player.WornWeapon.ToString() + '\n');


            foreach (Card card in map.Deck.Cards)
            {
                sw.Write(card.Id.ToString() + ';');
            }
            sw.Write('\n');

            sw.WriteLine(map.BossFight.ToString() + ';' + map.GetEQ.ToString() +';'+ map.IsEQGained[0].ToString() + ';' + map.IsEQGained[1].ToString() + ';' + map.IsEQGained[2].ToString() + ';' + map.IsEQGained[3].ToString() + '\n');

            sw.Close();
        }

        public static void Load(Menu menu)
        {
            if (File.Exists("save.txt"))
            {
                string[] lines = File.ReadAllLines("save.txt");
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
            Equipment equipment = new Equipment(map);
            map.Hide();
            equipment.Show();
        }
        public static void FightEngager(Map map, Enemy enemy)
        {
            Fight fight = new Fight(map,enemy);
            map.Hide();
            fight.Show();
        }
        public static void Rest(Map map)
        {
            map.Player.CurrentHP = map.Player.MaxHP;
            MessageBox.Show("Znalazłeś miejsce na bezpieczny odpoczynek!");
        }

        public static void RandomEvent(Map map)
        {
            if(map.Player.CurrentHP<map.Player.MaxHP / 2) //Jeśli życie gracza jest poniżej 50% zwiększamy szansę na odpoczynek
            {
                int randomNumber = rng.Next(0, 100);
                if (randomNumber > 50) // (50-100]
                {
                    Rest(map);
                }
                else if (randomNumber <= 50 && randomNumber > 30) // (30 - 50]
                {
                    MerchantLauncher(map);
                }
                else if (randomNumber <= 30 && randomNumber > 15) // (15-30]
                {
                    FightEngager(map, new EnemyCommon()); ;
                }else // [0-15)
                {
                    MessageBox.Show("Znalazłeś przy drodze skarb!");
                    int reward = Rewards.SmallReward();
                    MessageBox.Show("Zawierał on " + reward + " sztuk złota");
                    map.Player.Gold += reward;
                }

            }
            else
            {
                int randomNumber = rng.Next(0,100);
                if(randomNumber == 100)
                {
                    FightEngager(map, new EnemyElite()); // Peszek!
                }else if(randomNumber>=70 && randomNumber <100) // (70-100)
                {
                    FightEngager(map, new EnemyCommon());
                }
                else if(randomNumber <70 && randomNumber >= 40) // [40-70)
                {
                    Rest(map);
                }
                else if(randomNumber < 40 && randomNumber >=10) // [10-40)
                {
                    MerchantLauncher(map);
                }
                else // [0-10)
                {
                    MessageBox.Show("Znalazłeś przy drodze skarb!");
                    int reward = Rewards.SmallReward();
                    MessageBox.Show("Zawierał on " + reward + " sztuk złota");
                    map.Player.Gold += reward;
                }
            }
        }

        public static void MerchantLauncher(Map map)
        {
            Merchant merchant = new Merchant(map);
            map.Hide();
            merchant.Show();
        }
    }
}
