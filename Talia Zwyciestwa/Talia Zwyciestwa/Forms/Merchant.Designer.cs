using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Talia_Zwyciestwa.Classes;
using Talia_Zwyciestwa.Classes.Card_Types;

namespace Talia_Zwyciestwa.Forms
{
    partial class Merchant
    {
        private Random random = new Random();
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Map map;
        private System.ComponentModel.IContainer components = null;

        private List<int> indexes = new List<int>();

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public Merchant(Map m)
        {
            map = m;
            InitializeComponent();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HealButton = new System.Windows.Forms.Button();
            this.UpgradeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HealButton
            // 
            this.HealButton.Location = new System.Drawing.Point(141, 322);
            this.HealButton.Name = "HealButton";
            this.HealButton.Size = new System.Drawing.Size(75, 23);
            this.HealButton.TabIndex = 0;
            this.HealButton.Text = "Ulecz (100g)";
            this.HealButton.UseVisualStyleBackColor = true;
            this.HealButton.Click += new System.EventHandler(this.Heal);
            // 
            // UpgradeButton
            // 
            this.UpgradeButton.Location = new System.Drawing.Point(268, 317);
            this.UpgradeButton.Name = "UpgradeButton";
            this.UpgradeButton.Size = new System.Drawing.Size(152, 33);
            this.UpgradeButton.TabIndex = 1;
            this.UpgradeButton.Text = "Ulepsz losową kartę (150g)";
            this.UpgradeButton.UseVisualStyleBackColor = true;
            this.UpgradeButton.Click += new System.EventHandler(this.UpgradeCard);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(213, 400);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Wyjdź";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit);
            // 
            // Merchant
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UpgradeButton);
            this.Controls.Add(this.HealButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Merchant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handlarz";
            this.Load += new System.EventHandler(this.Begin);
            this.ResumeLayout(false);

        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
            map.Show();
        }
        #endregion/
        private void Heal(object sender, EventArgs e)
        {
            if(map.Player.Money < 100)
            {
                MessageBox.Show("Nie stać cię!");
            }else
            {
                map.Player.Money -= 100;
                map.Player.CurrentHP = map.Player.MaxHP;
            }
        }

        private void Begin(object sender, EventArgs e)
        {

        }

        private void UpgradeCard(object sender, EventArgs e) //TEST THAT
        {
            if (map.Player.Money < 150)
            {
                MessageBox.Show("Nie stać cię!");
            }
            else
            {
                for(int i = 0; i < map.Deck.Cards.Count; i++)
                {
                    if (map.Deck.Cards[i].Id <= 4 )
                        indexes.Add(i);
                }
                if (indexes.Count != 0)
                {
                    int index = random.Next(0, indexes.Count-1);
                    switch (map.Deck.Cards[indexes[index]].Value) //FIX THAT
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
                    map.Deck.Cards.RemoveAt(indexes[index]);
                    map.Player.Money -= 150;
                    MessageBox.Show("Twoja nowa karta: " + map.Deck.Cards[map.Deck.Cards.Count - 1].Name.ToString() + "/n Opis: " + map.Deck.Cards[map.Deck.Cards.Count - 1].Describtion.ToString() + "/n Wartość: " + map.Deck.Cards[map.Deck.Cards.Count - 1].Value.ToString());
                }
                else
                    MessageBox.Show("Nie masz kart do ulepszenia");
            }
        }
        private System.Windows.Forms.Button HealButton;
        private System.Windows.Forms.Button UpgradeButton;
        private Button ExitButton;
    }
}