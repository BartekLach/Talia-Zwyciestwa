using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Talia_Zwyciestwa.Classes;
using Talia_Zwyciestwa.Classes.Items.Armors;
using Talia_Zwyciestwa.Classes.Items.Helmets;
using Talia_Zwyciestwa.Classes.Items.Shields;
using Talia_Zwyciestwa.Classes.Items.Weapons;
using Talia_Zwyciestwa.Classes.Card_Types;


namespace Talia_Zwyciestwa.Forms
{
    public partial class Merchant : Form
    {
        private Random random = new Random();
        private Map map;
        private List<int> indexes = new List<int>();
        public Merchant(Map m)
        {
            map = m;
            InitializeComponent();

            if (!map.Player.UnlockedArmors[0] || map.Player.UnlockedArmors[2])
                UpgradeArmorButton.Hide();

            if (map.Player.UnlockedArmors[1])
            {
                UpgradeArmorButton.Text = "Ulepsz zbroję (250)";
                ArmorUpgradeToolTip.SetToolTip(UpgradeArmorButton, HeavyArmor.Def.ToString() + " zręczności, " + HeavyArmor.Str.ToString() + " siły");

            }
            else
            {
                UpgradeArmorButton.Text = "Ulepsz zbroję (150)";
                ArmorUpgradeToolTip.SetToolTip(UpgradeArmorButton, MediumArmor.Def.ToString() + " zręczności, " + MediumArmor.Str.ToString() + " siły");
            }


            if (!map.Player.UnlockedWeapons[0] || map.Player.UnlockedWeapons[2])
                UpgradeWeaponButton.Hide();

            if (map.Player.UnlockedWeapons[1])
            {

                WeaponUpgradeToolTip.SetToolTip(UpgradeWeaponButton, HeavyWeapon.Def.ToString() + " zręczności, " + HeavyWeapon.Str.ToString() + " siły");
                UpgradeWeaponButton.Text = "Ulepsz broń (250)";

            }
            else
            {
                UpgradeWeaponButton.Text = "Ulepsz broń (150)";
                WeaponUpgradeToolTip.SetToolTip(UpgradeWeaponButton, MediumWeapon.Def.ToString() + " zręczności, " + MediumWeapon.Str.ToString() + " siły");
            }


            if (!map.Player.UnlockedShields[0] || map.Player.UnlockedShields[1])
                UpgradeShieldButton.Hide();
            else
            {
                ShieldUpgradeToolTip.SetToolTip(UpgradeShieldButton, HeavyShield.Def.ToString() + " zręczności, " + HeavyShield.Str.ToString() + " siły");
                UpgradeShieldButton.Text = "Ulepsz tarczę (150)";
            }

            if (!map.Player.UnlockedHelmets[0] || map.Player.UnlockedHelmets[1])
                UpgradeHelmetButton.Hide();
            else
            {
                HelmetUpgradeToolTip.SetToolTip(UpgradeHelmetButton, HeavyHelmet.Def.ToString() + " zręczności, " + HeavyHelmet.Str.ToString() + " siły");
                UpgradeHelmetButton.Text = "Ulepsz hełm (180)";
            }



            RefreshGold();
        }
        private void UpgradeHelmetButton_Click(object sender, EventArgs e)
        {
            if (map.Player.Gold >= 180)
            {
                map.Player.Gold -= 180;
                map.Player.UnlockedHelmets[1] = true;
                map.Player.ChangeHelmet(new HeavyHelmet());
                map.Player.WornHelmet = 2;
                UpgradeHelmetButton.Hide();
                RefreshGold();
            }
            else
                MessageBox.Show("Nie stać Cię");
        }

        private void UpgradeArmorButton_Click(object sender, EventArgs e)
        {
            if (map.Player.UnlockedArmors[1])
            {
                if (map.Player.Gold >= 250)
                {
                    map.Player.UnlockedArmors[2] = true;
                    map.Player.Gold -= 250;
                    map.Player.WornArmor = 3;
                    map.Player.ChangeArmor(new HeavyArmor());
                    UpgradeArmorButton.Hide();
                    RefreshGold();
                }
                else
                    MessageBox.Show("Nie stać Cię");
            }
            else if (map.Player.Gold >= 150)
            {
                map.Player.UnlockedArmors[1] = true;
                map.Player.Gold -= 150;
                map.Player.WornArmor = 2;
                map.Player.ChangeArmor(new MediumArmor());
                UpgradeArmorButton.Text = "Ulepsz Zbroję (250)";
                ArmorUpgradeToolTip.SetToolTip(UpgradeArmorButton, HeavyArmor.Def.ToString() + " zręczności, " + HeavyArmor.Str.ToString() + " siły");
                RefreshGold();
            }
            else
                MessageBox.Show("Nie stać Cię");

        }

        private void UpgradeShieldButton_Click(object sender, EventArgs e)
        {
            if (map.Player.Gold >= 150)
            {
                map.Player.Gold -= 150;
                map.Player.UnlockedShields[1] = true;
                map.Player.WornShield = 2;
                map.Player.ChangeShield(new HeavyShield());
                RefreshGold();
                UpgradeShieldButton.Hide();
            }
            else
                MessageBox.Show("Nie stać Cię");
        }

        private void UpgradeWeaponButton_Click(object sender, EventArgs e)
        {
            if (map.Player.UnlockedWeapons[1])
            {
                if (map.Player.Gold >= 250)
                {
                    map.Player.UnlockedWeapons[2] = true;
                    map.Player.Gold -= 250;
                    map.Player.WornWeapon = 3;
                    map.Player.ChangeWeapon(new HeavyWeapon());
                    UpgradeWeaponButton.Hide();
                    RefreshGold();
                }
                else
                    MessageBox.Show("Nie stać Cię");
            }
            else if (map.Player.Gold >= 150)
            {
                map.Player.UnlockedWeapons[1] = true;
                map.Player.Gold -= 150;
                map.Player.WornWeapon = 2;
                map.Player.ChangeWeapon(new MediumWeapon());
                UpgradeWeaponButton.Text = "Ulepsz Broń (250)";
                WeaponUpgradeToolTip.SetToolTip(UpgradeWeaponButton, HeavyWeapon.Def.ToString() + " zręczności, " + HeavyWeapon.Str.ToString() + " siły");
                RefreshGold();
            }
            else
                MessageBox.Show("Nie stać Cię");
        }
        private void Heal(object sender, EventArgs e)
        {
            if (map.Player.MaxHP == map.Player.CurrentHP)
            {
                MessageBox.Show("Jesteś w pełni zdrowy!");
            }
            else if (map.Player.Gold < 100)
            {
                MessageBox.Show("Nie stać cię!");
            }
            else
            {
                map.Player.Gold -= 100;
                map.Player.CurrentHP = map.Player.MaxHP;
                RefreshGold();
            }
        }


        private void RefreshGold()
        {
            GoldLabel.Text = map.Player.Gold.ToString();
        }

        private void UpgradeCard(object sender, EventArgs e)
        {
            if (map.Player.Gold < 150)
            {
                MessageBox.Show("Nie stać cię!");
            }
            else
            {
                for (int i = 0; i < map.Deck.Cards.Count; i++)
                {
                    if (map.Deck.Cards[i].Id <= 4)
                        indexes.Add(i);
                }
                if (indexes.Count != 0)
                {
                    int index = random.Next(0, indexes.Count - 1);
                    int id = map.Deck.Cards[indexes[index]].Id;
                    map.Deck.Cards.RemoveAt(indexes[index]);
                    switch (id)
                    {
                        case 0:
                            map.Deck.Cards.Add(new UpgradedAttackCard());
                            break;
                        case 1:
                            map.Deck.Cards.Add(new UpgradedDefCard());
                            break;
                        case 2:
                            map.Deck.Cards.Add(new UpgradedParryCard());
                            break;
                        case 3:
                            map.Deck.Cards.Add(new UpgradedSteroidsCard());
                            break;
                        case 4:
                            map.Deck.Cards.Add(new UpgradeDexElixirCard());
                            break;
                    }
                    map.Player.Gold -= 150;
                    MessageBox.Show("Twoja nowa karta: " + map.Deck.Cards[map.Deck.Cards.Count - 1].Name.ToString() + " Opis: " + map.Deck.Cards[map.Deck.Cards.Count - 1].Describtion.ToString() + " Wartość: " + map.Deck.Cards[map.Deck.Cards.Count - 1].Value.ToString());
                    RefreshGold();
                    map.Deck.Write();
                    indexes.Clear();
                }
                else
                    MessageBox.Show("Nie masz kart do ulepszenia");
            }
        }
    }
}
