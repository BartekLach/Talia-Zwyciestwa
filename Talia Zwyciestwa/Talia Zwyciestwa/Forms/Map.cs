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

namespace Talia_Zwyciestwa.Forms
{
    public partial class Map : Form
    {
        private bool isGameOn;
        public Map()
        {
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

        private void button26_Click(object sender, EventArgs e)
        {
            menu.ShowContinueButton(this);
            this.Hide();
            menu.Show();
        }
    }
}
