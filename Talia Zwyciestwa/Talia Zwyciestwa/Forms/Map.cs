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
using Talia_Zwyciestwa.Classes.Enemies_Types;

namespace Talia_Zwyciestwa.Forms
{
    public partial class Map : Form
    {
        public Menu menu;
        private Player player;
        private Deck deck;
        private bool bossFight = false;
        private int getEQ = 1;
        private bool[] isEQGained = new bool[4];
        public Map(Menu m)
        {
            menu = m;
            deck = new Deck();
            player = new Player();
            for (int i = 0; i < 4; i++)
            {
                IsEQGained[i] = false;
            }
            InitializeComponent();
        }
        public Map(Player p, Deck d, Menu m)
        {
            menu = m;
            deck = d;
            player = p;
            InitializeComponent();
        }
        public void HideStarterButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            GameHandler.SaveToFile(this);
            MessageBox.Show("Twój postęp został zapisany.");
        }
        private void button25Clicked(object sender, EventArgs e)
        {
            button25.Enabled = false;
            button24.Enabled = true;

            GameHandler.MerchantLauncher(this);

        }

        private void button24Clicked(object sender, EventArgs e)
        {
            button24.Enabled = false;
            BossFight = true;
            GameHandler.FightEngager(this, new EnemyBoss());
        }

        private void button23Clicked(object sender, EventArgs e)
        {
            button23.Enabled = false;
            button25.Enabled = true;

            GameHandler.FightEngager(this, new EnemyElite());
        }

        private void button22Clicked(object sender, EventArgs e)
        {
            button22.Enabled = false;
            button25.Enabled = true;

            GameHandler.FightEngager(this, new EnemyElite());
        }

        private void button21Clicked(object sender, EventArgs e)
        {
            button20.Enabled = false;
            button21.Enabled = false;
            button23.Enabled = true;

            GameHandler.MerchantLauncher(this);
        }

        private void button20Clicked(object sender, EventArgs e)
        {
            button22.Enabled = true;
            button20.Enabled = false;
            button21.Enabled = false;
            GameHandler.RandomHardEvent(this);
        }

        private void button19Clicked(object sender, EventArgs e)
        {
            button19.Enabled = false;
            GameHandler.MerchantLauncher(this);
        }

        private void button18Clicked(object sender, EventArgs e)
        {
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = true;
            button21.Enabled = true;
            GameHandler.FightEngager(this, new EnemyElite());

        }

        private void button17Clicked(object sender, EventArgs e)
        {
            button19.Enabled = true;
            button18.Enabled = true;
            button17.Enabled = false;
            GameHandler.RandomHardEvent(this);
        }

        private void button16Clicked(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = true;
            GetEQ++;
            GameHandler.FightEngager(this, new EnemyElite());
        }

        private void button15Clicked(object sender, EventArgs e)
        {
            button15.Enabled = false;
            GameHandler.MerchantLauncher(this);
        }

        private void button14Clicked(object sender, EventArgs e)
        {
            button13.Enabled = true;
            button14.Enabled = false;
            GameHandler.FightEngager(this, new EnemyCommon());
        }

        private void button13Clicked(object sender, EventArgs e)
        {
            button13.Enabled = false;
            GameHandler.RandomHardEvent(this);
        }

        private void button12Clicked(object sender, EventArgs e)
        {
            button12.Enabled = false;
            button15.Enabled = true;
            button16.Enabled = true;
            button13.Enabled = false;
            button14.Enabled = false;
            GameHandler.RandomHardEvent(this);
        }

        private void button11Clicked(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button14.Enabled = true;
            button12.Enabled = true;
            GameHandler.RandomHardEvent(this);
        }

        private void button10Clicked(object sender, EventArgs e)
        {
            button10.Enabled = false;
            GameHandler.MerchantLauncher(this);
        }

        private void button9Clicked(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button10.Enabled = true;
            GameHandler.RandomEvent(this);
        }

        private void button8Clicked(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button9.Enabled = true;
            button11.Enabled = true;
            //GetEQ++;
            GameHandler.FightEngager(this, new EnemyElite());
        }

        private void button7Clicked(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = true;
            GetEQ++;
            GameHandler.FightEngager(this, new EnemyCommon());
        }

        private void button6Clicked(object sender, EventArgs e)
        {
            button6.Enabled = false;
            GameHandler.MerchantLauncher(this);
        }

        private void button5Clicked(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button6.Enabled = true;
            button7.Enabled = true;
            GameHandler.RandomEvent(this);
        }

        private void button4Clicked(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = true;
            GameHandler.FightEngager(this, new EnemyCommon());
        }

        private void button3Clicked(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            //GetEQ++;
            GameHandler.FightEngager(this, new EnemyCommon());

        }
        private void button2Clicked(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            GameHandler.FightEngager(this, new EnemyCommon());
        }

        private void button1Clicked(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = true;
            GameHandler.RandomEvent(this);
        }




        private void EQButtonClick(object sender, EventArgs e)
        {
            GameHandler.ShowEQ(this);
        }


        private void button26_Click(object sender, EventArgs e)
        {
            menu.ShowContinueButton(this);
            this.Hide();
            menu.Show();
        }

        internal Deck Deck { get => deck; set => deck = value; }
        internal Player Player { get => player; set => player = value; }
        public bool BossFight { get => bossFight; set => bossFight = value; }
        public int GetEQ { get => getEQ; set => getEQ = value; }
        public bool[] IsEQGained { get => isEQGained; set => isEQGained = value; }

    }
}