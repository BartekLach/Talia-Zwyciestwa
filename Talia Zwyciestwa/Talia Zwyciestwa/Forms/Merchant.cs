﻿using System;
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

namespace Talia_Zwyciestwa.Forms
{
    public partial class Merchant : Form
    {
        public Merchant()
        {
            InitializeComponent();
        }

        private void UpgradeHelmetButton_Click(object sender, EventArgs e)
        {
            if(map.Player.Gold >= 180)
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

            }
            else
                MessageBox.Show("Nie stać Cię");
        }

        private void UpgradeWeaponButton_Click(object sender, EventArgs e)
        {
            if(map.Player.UnlockedWeapons[1])
            {
                if(map.Player.Gold>= 250)
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
            else if(map.Player.Gold >= 150)
            {
                map.Player.UnlockedWeapons[1] = true;
                map.Player.Gold -= 150;
                map.Player.WornWeapon = 2;
                map.Player.ChangeWeapon(new MediumWeapon());
                UpgradeWeaponButton.Text = "Ulepsz Broń (250)";
                RefreshGold();
            }
            else
                MessageBox.Show("Nie stać Cię");
        }
    }
}
