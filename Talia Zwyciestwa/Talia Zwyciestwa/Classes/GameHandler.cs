using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Talia_Zwyciestwa.Classes.Enemies_Types;
using Talia_Zwyciestwa.Classes.Items.Helmets;
using Talia_Zwyciestwa.Classes.Items.Armors;
using Talia_Zwyciestwa.Classes.Items.Shields;
using Talia_Zwyciestwa.Classes.Items.Weapons;
using Talia_Zwyciestwa.Forms;
using Talia_Zwyciestwa.Classes.Card_Types;

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

            //Hero Stats

            sw.WriteLine(map.Player.Gold.ToString() + ';' + map.Player.CurrentHP.ToString());

            //HeroEQ Unlocked

            sw.WriteLine(map.Player.UnlockedHelmets[0].ToString() + ';' + map.Player.UnlockedHelmets[1].ToString()); //helmet

            sw.WriteLine(map.Player.UnlockedArmors[0].ToString() + ';' + map.Player.UnlockedArmors[1].ToString() + ';' + map.Player.UnlockedArmors[1].ToString()); //Armor

            sw.WriteLine(map.Player.UnlockedShields[0].ToString() + ';' + map.Player.UnlockedShields[1].ToString()); //Shields

            sw.WriteLine(map.Player.UnlockedWeapons[0].ToString() + ';' + map.Player.UnlockedWeapons[1].ToString() + ';' + map.Player.UnlockedWeapons[1].ToString()); //Weapons

            //HeroEQ worn

            sw.Write(map.Player.WornHelmet.ToString() + '\n' + map.Player.WornArmor.ToString() + '\n' + map.Player.WornShield.ToString() + '\n' + map.Player.WornWeapon.ToString() + '\n');

            //Deck

            foreach (Card card in map.Deck.Cards)
            {
                sw.Write(card.Id.ToString() + ';');
            }
            sw.WriteLine();

            //map vars

            sw.WriteLine(map.BossFight.ToString() + ';' + map.GetEQ.ToString() +';'+ map.IsEQGained[0].ToString() + ';' + map.IsEQGained[1].ToString() + ';' + map.IsEQGained[2].ToString() + ';' + map.IsEQGained[3].ToString());

            //map buttons

            foreach (Control control in map.Controls)
            {
                if(control.Tag != null && control.Tag.ToString() == "Location" && control.Enabled)
                {
                    sw.Write(control.TabIndex.ToString() + ';');
                }
            }

            sw.Close();
        }

        public static void Load(Menu menu)
        {
            if (File.Exists("save.txt"))
            { 
                string[] vars;
                Player player = new Player();
                Deck deck = new Deck();
                deck.Cards.Clear();

                string[] lines = File.ReadAllLines("save.txt");

                //Hero Stats

                vars = lines[0].Split(';');
                player.Gold = Int32.Parse(vars[0]);
                player.CurrentHP = Int32.Parse(vars[1]);

                //HeroEQ unlocked
                //helmet:
                vars = lines[1].Split(';');
                int i = 0;
                foreach(string var in vars)
                {
                    player.UnlockedHelmets[i] = Boolean.Parse(var);
                    i++;
                }
                //Armor:
                vars = lines[2].Split(';');
                i = 0;
                foreach (string var in vars)
                {
                    player.UnlockedArmors[i] = Boolean.Parse(var);
                    i++;
                }
                //Shields:
                vars = lines[3].Split(';');
                i = 0;
                foreach (string var in vars)
                {
                    player.UnlockedShields[i] = Boolean.Parse(var);
                    i++;
                }
                //Weapons:
                vars = lines[4].Split(';');
                i = 0;
                foreach (string var in vars)
                {
                    player.UnlockedWeapons[i] = Boolean.Parse(var);
                    i++;
                }

                //HeroEQ worn

                vars = lines[5].Split(';');
                foreach (string var in vars)//wornhelmet
                {
                    player.WornHelmet = Int16.Parse(var);

                    switch (player.WornHelmet)
                    {
                        case 1:
                            player.ChangeHelmet(new LightHelmet());
                            break;
                        case 2:
                            player.ChangeHelmet(new HeavyHelmet());
                            break;
                    }

                }
                vars = lines[6].Split(';');
                foreach (string var in vars)//wornArmor
                {
                    player.WornArmor = Int16.Parse(var);

                    switch (player.WornArmor)
                    {
                        case 1:
                            player.ChangeArmor(new LightArmor());
                            break;
                        case 2:
                            player.ChangeArmor(new MediumArmor());
                            break;
                        case 3:
                            player.ChangeArmor(new HeavyArmor());
                            break;
                    }

                }
                vars = lines[7].Split(';');
                foreach (string var in vars)//wornShield
                {
                    player.WornShield = Int16.Parse(var);

                    switch (player.WornShield)
                    {
                        case 1:
                            player.ChangeShield(new LightShield());
                            break;
                        case 2:
                            player.ChangeShield(new HeavyShield());
                            break;
                    }


                }

                vars = lines[8].Split(';');
                foreach (string var in vars)//wornWeapon
                {
                    player.WornWeapon = Int16.Parse(var);

                    switch (player.WornWeapon)
                    {
                        case 1:
                            player.ChangeWeapon(new LightWeapon());
                            break;
                        case 2:
                            player.ChangeWeapon(new MediumWeapon());
                            break;
                        case 3:
                            player.ChangeWeapon(new HeavyWeapon());
                            break;
                    }

                }
                //Deck:
                vars = lines[9].Split(';');
                foreach (string var in vars)
                {
                    if (var == "")
                        continue;
                    switch (Int16.Parse(var))
                    {
                        case 0:
                            deck.Cards.Add(new AttackCard());
                            break;
                        case 1:
                            deck.Cards.Add(new DefCard());
                            break;
                        case 2:
                            deck.Cards.Add(new ParryCard());
                            break;
                        case 3:
                            deck.Cards.Add(new SteroidsCard());
                            break;
                        case 4:
                            deck.Cards.Add(new DexElixirCard());
                            break;
                        case 5:
                            deck.Cards.Add(new UpgradedAttackCard());
                            break;
                        case 6:
                            deck.Cards.Add(new UpgradedDefCard());
                            break;
                        case 7:
                            deck.Cards.Add(new UpgradedParryCard());
                            break;
                        case 8:
                            deck.Cards.Add(new UpgradedSteroidsCard());
                            break;
                        case 9:
                            deck.Cards.Add(new UpgradeDexElixirCard());
                            break;
                    }
                }

                //map vars
                vars = lines[10].Split(';');
                Map map = new Map(player, deck, menu);

                map.BossFight = Boolean.Parse(vars[0]);
                map.GetEQ = Int16.Parse(vars[1]);
                map.IsEQGained[0] = Boolean.Parse(vars[2]);
                map.IsEQGained[1] = Boolean.Parse(vars[3]);
                map.IsEQGained[2] = Boolean.Parse(vars[4]);
                map.IsEQGained[3] = Boolean.Parse(vars[5]);

                //Map Buttons
                vars = lines[11].Split(';');
                map.HideStarterButtons();
                foreach (string var in vars)
                {
                    if (var == "")
                        continue;
                    foreach (Control control in map.Controls)
                    {
                        if (control.Tag != null && control.Tag.ToString() == "Location" && control.TabIndex==Int32.Parse(var))
                        {
                            control.Enabled = true;
                        }
                    }
                }
                menu.Hide();
                map.Show();
                
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
            //if(map.Player.CurrentHP<map.Player.MaxHP / 2) //Jeśli życie gracza jest poniżej 50% zwiększamy szansę na odpoczynek
            //{
            //    int randomNumber = rng.Next(0, 100);
            //    if (randomNumber > 50) // (50-100]
            //    {
            //        Rest(map);
            //    }
            //    else if (randomNumber <= 50 && randomNumber > 30) // (30 - 50]
            //    {
            //        MerchantLauncher(map);
            //    }
            //    else if (randomNumber <= 30 && randomNumber > 15) // (15-30]
            //    {
            //        FightEngager(map, new EnemyCommon()); ;
            //    }
            //    else // [0-15)
            //    {
            //        MessageBox.Show("Znalazłeś przy drodze skarb!");
            //        int reward = Rewards.SmallReward();
            //        MessageBox.Show("Zawierał on " + reward + " sztuk złota");
            //        map.Player.Gold += reward;
            //    }
            //}
            //else
            //{
                int randomNumber = rng.Next(0,100);
                if(randomNumber == 100)
                {
                    FightEngager(map, new EnemyElite()); // Peszek!
                }else if(randomNumber>=70 && randomNumber <100) // [70-100)
                {
                    FightEngager(map, new EnemyCommon());
                }
                else if(randomNumber >= 40 && randomNumber < 70) // [40-70)
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
            //}
        }
        public static void RandomHardEvent(Map map)
        {
            int randomNumber = rng.Next(0, 100);
            if (randomNumber >= 60 && randomNumber <= 100) // [60-100] - 40%
            {
                FightEngager(map, new EnemyElite());
            }
            else if (randomNumber >= 40 && randomNumber < 60) // [40-60) - 20%
            {
                Rest(map);
            }
            else if (randomNumber < 40 && randomNumber >= 10) // [10-40) - 30%
            {
                MerchantLauncher(map);
            }
            else // [0-10) - 10%
            {
                MessageBox.Show("Znalazłeś przy drodze skarb!");
                int reward = Rewards.BigReward();
                MessageBox.Show("Zawierał on " + reward + " sztuk złota");
                map.Player.Gold += reward;
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
