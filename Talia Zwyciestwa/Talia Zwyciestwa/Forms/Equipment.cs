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
        public Equipment()
        {
            InitializeComponent();
        }

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
    }
}
