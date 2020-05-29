using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Talia_Zwyciestwa.Classes;
using Talia_Zwyciestwa.Classes.Items.Armors;
using Talia_Zwyciestwa.Classes.Items.Helmets;
using Talia_Zwyciestwa.Classes.Items.Shields;
using Talia_Zwyciestwa.Classes.Items.Weapons;

namespace Talia_Zwyciestwa.Forms
{
    public partial class Fight : Form
    {
        public Fight(Map m, Enemy e)
        {
            enemy = e;
            map = m;
            InitializeComponent();
            player = map.Player;
            deck = map.Deck.Cards;
            deck.Shuffle();

            for (int i = 0; i < 5; i++)
                hand[i] = null;

            CardButtons = new Button[5];
            CardButtons[0] = Card1;
            CardButtons[1] = Card2;
            CardButtons[2] = Card3;
            CardButtons[3] = Card4;
            CardButtons[4] = Card5;

            currentPower = player.Power;
            player.CurrentStr = player.Str;
            player.CurrentDex = player.Dex;
            player.CurrentPO = 0;

            for (int i = 0; i < 5; i++)
            {
                toolTips[i] = new ToolTip();
                toolTips[i].AutoPopDelay = 3000;
                toolTips[i].InitialDelay = 500;
                toolTips[i].ReshowDelay = 500;
            }
            FillHand();
            RefreshLabels();
        }


        private void Card5Picked(object sender, EventArgs e)
        {
            CardPicker(4);
        }

        private void Card4Picked(object sender, EventArgs e)
        {
            CardPicker(3);
        }

        private void Card3Picked(object sender, EventArgs e)
        {

            CardPicker(2);
        }

        private void Card2Picked(object sender, EventArgs e)
        {
            CardPicker(1);
        }

        private void Card1Picked(object sender, EventArgs e)
        {
            CardPicker(0);
        }

        private void CardPicker(int v)
        {
            if (currentPower >= hand[v].Value)
            {
                currentPower -= hand[v].Value;
                hand[v].Effect(player, enemy);
                RefreshLabels();
                if (enemy.CurrentHP <= 0)
                {
                    ClearHand();
                    TrashToDeck();
                    if (map.BossFight)
                    {
                        MessageBox.Show("Uratowałeś świat! Twój zapis zostaje usunięty");
                        File.Delete("save.txt");
                        map.menu.HideContinueButton(map);
                        map.menu.Show();
                        map.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wygrałeś walkę!!!");

                        map.Show();
                        this.Close();
                    }
                    int reward;
                    if (enemy.GetType().Name.ToString() == "EnemyCommon")
                    {
                        reward = Rewards.SmallReward();
                        MessageBox.Show("Gratulację. Znalazłeś " + reward.ToString() + " sztuk złota");
                        player.Gold += reward;
                    }

                    else if ((enemy.GetType().Name.ToString() == "EnemyElite"))
                    {
                        reward = Rewards.BigReward();
                        MessageBox.Show("Gratulację. Znalazłeś " + reward.ToString() + " sztuk złota");
                        player.Gold += reward;
                    }


                    switch (map.GetEQ)
                    {
                        case 0:
                            if (!map.IsEQGained[map.GetEQ])
                            {
                                MessageBox.Show("Ponnadto znalazłeś lekki pancerz i zakładasz go na siebie");
                                map.Player.WornArmor = 1;
                                map.Player.UnlockedArmors[0] = true;
                                map.Player.ChangeArmor(new LightArmor());
                                map.IsEQGained[map.GetEQ] = true;
                            }
                            break;
                        case 1:
                            if (!map.IsEQGained[map.GetEQ])
                            {
                                MessageBox.Show("Ponnadto znalazłeś lekką broń i zaczynasz jej używać");
                                map.Player.WornWeapon = 1;
                                map.Player.UnlockedWeapons[0] = true;
                                map.Player.ChangeWeapon(new LightWeapon());
                                map.IsEQGained[map.GetEQ] = true;
                            }
                            break;
                        case 2:
                            if (!map.IsEQGained[map.GetEQ])
                            {
                                MessageBox.Show("Ponnadto znalazłeś tarczę zakładasz ją");
                                map.Player.WornShield = 1;
                                map.Player.UnlockedShields[0] = true;
                                map.Player.ChangeShield(new LightShield());
                                map.IsEQGained[map.GetEQ] = true;
                            }

                            break;
                        case 3:
                            if (!map.IsEQGained[map.GetEQ])
                            {
                                MessageBox.Show("Ponnadto znalazłeś hełm i zakładasz go na siebie");
                                map.Player.UnlockedHelmets[0] = true;
                                map.Player.WornHelmet = 1;
                                map.Player.ChangeHelmet(new LightHelmet());
                                map.IsEQGained[map.GetEQ] = true;
                            }

                            break;
                    }


                }
                trash.Add(hand[v]);
                hand[v] = null;
                CardButtons[v].Hide();
            }
            else
                MessageBox.Show("Nie możesz zagrać tej karty");

        }

        private void RefreshLabels()
        {
            //Player:
            PlayerDexValue.Text = player.CurrentDex.ToString();
            PlayerStrValue.Text = player.CurrentStr.ToString();
            PlayerPowerValue.Text = currentPower.ToString();
            PlayerHPValue.Text = player.CurrentHP.ToString();
            PlayerPOValue.Text = player.CurrentPO.ToString();
            //enemy:
            EnemyPOValue.Text = enemy.CurrentPO.ToString();
            EnemyDexValue.Text = enemy.CurrentDex.ToString();
            EnemyStrValue.Text = enemy.CurrentStr.ToString();
            EnemyHPValue.Text = enemy.CurrentHP.ToString();
        }

        private void EndTurnClicked(object sender, EventArgs e)
        {
            enemy.MakeTurn(player);
            RefreshLabels();
            if (player.CurrentHP <= 0)
            {
                MessageBox.Show("Przegałeś!!! Twój zapis gry zostaje usunięty");
                File.Delete("save.txt");
                map.menu.HideContinueButton(map);
                map.menu.Show();
                map.Close();
                this.Close();
            }
            else
            {
                currentPower = player.Power;
                ClearHand();
                FillHand();
            }
        }

        private void FillHand()
        {
            for (int i = 0; i < 5; i++)
            {
                if (deck.Count == 0)
                {
                    TrashToDeck();
                }
                hand[i] = deck[0];
                deck.RemoveAt(0);
                CardButtons[i].BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(hand[i].Name);
                CardButtons[i].Show();
                toolTips[i].SetToolTip(CardButtons[i], hand[i].Describtion);
            }
        }
        private void TrashToDeck()
        {
            foreach (Card card in trash)
            {
                deck.Add(card);
            }
            deck.Shuffle();
            trash.Clear();
        }
        private void ClearHand()
        {
            for (int i = 0; i < 5; i++)
            {
                if (hand[i] != null)
                {
                    trash.Add(hand[i]);
                    hand[i] = null;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
