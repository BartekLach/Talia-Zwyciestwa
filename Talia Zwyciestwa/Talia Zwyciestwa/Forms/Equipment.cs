using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Talia_Zwyciestwa.Classes.Items.Armors;
using Talia_Zwyciestwa.Classes.Items.Helmets;
using Talia_Zwyciestwa.Classes.Items.Shields;
using Talia_Zwyciestwa.Classes.Items.Weapons;

namespace Talia_Zwyciestwa.Forms
{
    public partial class Equipment : Form
    {
        private Map map;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Close();
            map.Show();
        }

        private void DexValue_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AcquireHelmet(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AcquireHelmet(2);
        }

        private void AcquireHelmet(int v)
        {
            LightHelmetButton.BackColor = Color.White;
            HeavyHelmetButton.BackColor = Color.White;
            switch(v)
            {
                case 1:
                    map.Player.ChangeHelmet(new LightHelmet());
                    LightHelmetButton.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    map.Player.ChangeHelmet(new HeavyHelmet());
                    HeavyHelmetButton.BackColor = Color.DarkGreen;
                    break;
            }
            RefreshLabels();
            map.Player.WornHelmet = v;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AcquireArmor(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AcquireArmor(2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AcquireArmor(3);
        }

        private void AcquireArmor(int v)
        {
            LightArmorButton.BackColor = Color.White;
            MediumArmorButton.BackColor = Color.White;
            HeavyArmorButton.BackColor = Color.White;

            switch (v)
            {
                case 1:
                    map.Player.ChangeArmor(new LightArmor());
                    LightArmorButton.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    map.Player.ChangeArmor(new MediumArmor());
                    MediumArmorButton.BackColor = Color.DarkGreen;
                    break;
                case 3:
                    map.Player.ChangeArmor(new HeavyArmor());
                    HeavyArmorButton.BackColor = Color.DarkGreen;
                    break;
            }
            RefreshLabels();
            map.Player.WornArmor = v;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AcquireShield(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AcquireShield(2);
        }

        private void AcquireShield(int v)
        {
            LightShieldButton.BackColor = Color.White;
            HeavyShieldButton.BackColor = Color.White;
            switch (v)
            {
                case 1:
                    map.Player.ChangeShield(new LightShield());
                    LightShieldButton.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    map.Player.ChangeShield(new HeavyShield());
                    HeavyShieldButton.BackColor = Color.DarkGreen;
                    break;
            }
            RefreshLabels();
            map.Player.WornShield = v;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            AcquireWeapon(1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AcquireWeapon(2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AcquireWeapon(3);
        }

        private void AcquireWeapon(int v)
        {
            LightWeaponButton.BackColor = Color.White;
            MediumWeaponButton.BackColor = Color.White;
            HeavyWeaponButton.BackColor = Color.White;
            switch (v)
            {
                case 1:
                    map.Player.ChangeWeapon(new LightWeapon());
                    LightWeaponButton.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    map.Player.ChangeWeapon(new MediumWeapon());
                    MediumWeaponButton.BackColor = Color.DarkGreen;
                    break;
                case 3:
                    map.Player.ChangeWeapon(new HeavyWeapon());
                    HeavyWeaponButton.BackColor = Color.DarkGreen;
                    break;
            }
            RefreshLabels();
            map.Player.WornWeapon = v;
        }
        private void RefreshLabels()
        {
            DexValue.Text = map.Player.Dex.ToString();
            StrValue.Text = map.Player.Str.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            map.Deck.Write();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        public Equipment(Map m)
        {
            map = m;
            InitializeComponent();

            DexValue.Text = map.Player.Dex.ToString();
            StrValue.Text = map.Player.Str.ToString();
            MaxHPValue.Text = map.Player.MaxHP.ToString();
            CurrentHPValue.Text = map.Player.CurrentHP.ToString();
            GoldValue.Text = map.Player.Gold.ToString();

            if (!map.Player.UnlockedHelmets[0])
                LightHelmetButton.Enabled = false;
            if (!map.Player.UnlockedHelmets[1])
                HeavyHelmetButton.Enabled = false;

            if (!map.Player.UnlockedArmors[0])
                LightArmorButton.Enabled = false;
            if (!map.Player.UnlockedArmors[1])
                MediumArmorButton.Enabled = false;
            if (!map.Player.UnlockedArmors[2])
                HeavyArmorButton.Enabled = false;

            if (!map.Player.UnlockedShields[0])
                LightShieldButton.Enabled = false;
            if (!map.Player.UnlockedShields[1])
                HeavyShieldButton.Enabled = false;

            if (!map.Player.UnlockedWeapons[0])
                LightWeaponButton.Enabled = false;
            if (!map.Player.UnlockedWeapons[1])
                MediumWeaponButton.Enabled = false;
            if (!map.Player.UnlockedWeapons[2])
                HeavyWeaponButton.Enabled = false;

            switch (map.Player.WornHelmet)
            {
                case 1:
                    LightHelmetButton.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    HeavyHelmetButton.BackColor = Color.DarkGreen;
                    break;
            }

            switch (map.Player.WornArmor)
            {
                case 1:
                    LightArmorButton.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    MediumArmorButton.BackColor = Color.DarkGreen;
                    break;
                case 3:
                    HeavyArmorButton.BackColor = Color.DarkGreen;
                    break;
            }

            switch (map.Player.WornShield)
            {
                case 1:
                    LightShieldButton.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    HeavyShieldButton.BackColor = Color.DarkGreen;
                    break;
            }

            switch (map.Player.WornWeapon)
            {
                case 1:
                    LightWeaponButton.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    MediumWeaponButton.BackColor = Color.DarkGreen;
                    break;
                case 3:
                    HeavyWeaponButton.BackColor = Color.DarkGreen;
                    break;
            }

            LightHelmetToolTip.SetToolTip(LightHelmetButton, LightHelmet.Def.ToString() + " zręczności, " + LightHelmet.Str.ToString() + " siły");
            HeavyHelmetToolTip.SetToolTip(HeavyHelmetButton, HeavyHelmet.Def.ToString() + " zręczności, " + HeavyHelmet.Str.ToString() + " siły");
            LightArmorToolTip.SetToolTip(LightArmorButton, LightArmor.Def.ToString() + " zręczności, " + LightArmor.Str.ToString() + " siły");
            MediumArmorToolTip.SetToolTip(MediumArmorButton, MediumArmor.Def.ToString() + " zręczności, " + MediumArmor.Str.ToString() + " siły");
            HeavyArmorToolTip.SetToolTip(HeavyArmorButton, HeavyArmor.Def.ToString() + " zręczności, " + HeavyArmor.Str.ToString() + " siły");
            LightShieldToolTip.SetToolTip(LightShieldButton, LightShield.Def.ToString() + " zręczności, " + LightShield.Str.ToString() + " siły");
            HeavyShieldToolTip.SetToolTip(HeavyShieldButton, HeavyShield.Def.ToString() + " zręczności, " + HeavyShield.Str.ToString() + " siły");
            LightWeaponToolTip.SetToolTip(LightWeaponButton, LightWeapon.Def.ToString() + " zręczności, " + LightWeapon.Str.ToString() + " siły");
            MediumWeaponToolTip.SetToolTip(MediumWeaponButton, MediumWeapon.Def.ToString() + " zręczności, " + MediumWeapon.Str.ToString() + " siły");
            HeavyWeaponToolTip.SetToolTip(HeavyWeaponButton, HeavyWeapon.Def.ToString() + " zręczności, " + HeavyWeapon.Str.ToString() + " siły");
        }
    }
}
