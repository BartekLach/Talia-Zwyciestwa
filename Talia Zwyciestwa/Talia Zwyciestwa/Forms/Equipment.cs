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
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            switch(v)
            {
                case 1:
                    map.Player.ChangeHelmet(new LightHelmet());
                    button1.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    map.Player.ChangeHelmet(new HeavyHelmet());
                    button2.BackColor = Color.DarkGreen;
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
            button4.BackColor = Color.White;
            button3.BackColor = Color.White;
            button6.BackColor = Color.White;

            switch (v)
            {
                case 1:
                    map.Player.ChangeArmor(new LightArmor());
                    button4.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    map.Player.ChangeArmor(new MediumArmor());
                    button3.BackColor = Color.DarkGreen;
                    break;
                case 3:
                    map.Player.ChangeArmor(new HeavyArmor());
                    button6.BackColor = Color.DarkGreen;
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
            button7.BackColor = Color.White;
            button5.BackColor = Color.White;
            switch (v)
            {
                case 1:
                    map.Player.ChangeShield(new LightShield());
                    button7.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    map.Player.ChangeShield(new HeavyShield());
                    button5.BackColor = Color.DarkGreen;
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
            button10.BackColor = Color.White;
            button9.BackColor = Color.White;
            button8.BackColor = Color.White;
            switch (v)
            {
                case 1:
                    map.Player.ChangeWeapon(new LightWeapon());
                    button10.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    map.Player.ChangeWeapon(new MediumWeapon());
                    button9.BackColor = Color.DarkGreen;
                    break;
                case 3:
                    map.Player.ChangeWeapon(new HeavyWeapon());
                    button8.BackColor = Color.DarkGreen;
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
    }
}
