﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Talia_Zwyciestwa.Classes.Items.Armors;
using Talia_Zwyciestwa.Classes.Items.Helmets;
using Talia_Zwyciestwa.Classes.Items.Shields;
using Talia_Zwyciestwa.Classes.Items.Weapons;

namespace Talia_Zwyciestwa.Classes
{
    public class Player : Fighter
    {
        private int power;
        private int gold;

        // Eq:

        private int wornWeapon = 0;
        private int wornShield = 0;
        private int wornHelmet = 0;
        private int wornArmor = 0;

        private bool[] unlockedShields = new bool [2];
        private bool[] unlockedArmors = new bool [3];
        private bool[] unlockedHelmets = new bool [2];
        private bool[] unlockedWeapons = new bool [3];

        private Helmet helmetSlot;
        private Weapon weaponSlot;
        private Shield shieldSlot;
        private Armor armorSlot;
        public Player()
        {
            MaxHP = CurrentHP = 100;
            Str = CurrentStr = 0;
            Dex = CurrentDex = 0;
            power = 3;
            CurrentPO = 0;
            gold =  99999;
            for(int i=0;i<2; i++)
            {
                unlockedShields[i] = false;
                unlockedArmors[i] = false;
                unlockedHelmets[i] = false;
                unlockedWeapons[i] = false;
            }
            unlockedArmors[2] = false;
            unlockedWeapons[2] = false;
        }
        public void ChangeWeapon(Weapon weapon)
        {
            if (weaponSlot != null)
            {
                Dex -= weaponSlot.Def;
                Str -= weaponSlot.Str;
            }
            weaponSlot = weapon;
            Dex += weapon.Def;
            Str += weapon.Str;
        }
        public void ChangeHelmet(Helmet helmet)
        {
            if (helmetSlot != null)
            {
                Dex -= helmetSlot.Def;
                Str -= helmetSlot.Str;
            }
            helmetSlot = helmet;
            Dex += helmet.Def;
            Str += helmet.Str;

        }
        public void ChangeShield(Shield shield)
        {
            if (shieldSlot != null)
            {
                Dex -= shieldSlot.Def;
                Str -= shieldSlot.Str;
            }

            shieldSlot = shield;
            Dex += shield.Def;
            Str += shield.Str;
        }
        public void ChangeArmor(Armor armor)
        {
            if (armorSlot != null)
            {
                Dex -= armorSlot.Def;
                Str -= armorSlot.Str;
            }
            armorSlot = armor;
            Dex += armor.Def;
            Str += armor.Str;

        }
        public int Power { get => power; set => power = value; }
        public int Gold { get => gold; set => gold = value; }
        public int WornWeapon { get => wornWeapon; set => wornWeapon = value; }
        public int WornShield { get => wornShield; set => wornShield = value; }
        public int WornHelmet { get => wornHelmet; set => wornHelmet = value; }
        public int WornArmor { get => wornArmor; set => wornArmor = value; }
        public bool[] UnlockedShields { get => unlockedShields; set => unlockedShields = value; }
        public bool[] UnlockedArmors { get => unlockedArmors; set => unlockedArmors = value; }
        public bool[] UnlockedHelmets { get => unlockedHelmets; set => unlockedHelmets = value; }
        public bool[] UnlockedWeapons { get => unlockedWeapons; set => unlockedWeapons = value; }
        internal Helmet HelmetSlot { get => helmetSlot; set => helmetSlot = value; }
        internal Shield ShieldSlot { get => shieldSlot; set => shieldSlot = value; }
        internal Weapon WeaponSlot { get => weaponSlot; set => weaponSlot = value; }
        internal Armor ArmorSlot { get => armorSlot; set => armorSlot = value; }
    }
}
