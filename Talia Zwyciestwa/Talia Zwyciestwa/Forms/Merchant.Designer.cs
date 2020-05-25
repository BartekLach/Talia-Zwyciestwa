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
            this.UpgradeShieldButton = new System.Windows.Forms.Button();
            this.UpgradeWeaponButton = new System.Windows.Forms.Button();
            this.UpgradeArmorButton = new System.Windows.Forms.Button();
            this.UpgradeHelmetButton = new System.Windows.Forms.Button();
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
            // UpgradeShieldButton
            // 
            this.UpgradeShieldButton.Location = new System.Drawing.Point(453, 385);
            this.UpgradeShieldButton.Name = "UpgradeShieldButton";
            this.UpgradeShieldButton.Size = new System.Drawing.Size(191, 23);
            this.UpgradeShieldButton.TabIndex = 3;
            this.UpgradeShieldButton.UseVisualStyleBackColor = true;
            this.UpgradeShieldButton.Click += new System.EventHandler(this.UpgradeShieldButton_Click);
            // 
            // UpgradeWeaponButton
            // 
            this.UpgradeWeaponButton.Location = new System.Drawing.Point(453, 414);
            this.UpgradeWeaponButton.Name = "UpgradeWeaponButton";
            this.UpgradeWeaponButton.Size = new System.Drawing.Size(191, 23);
            this.UpgradeWeaponButton.TabIndex = 4;
            this.UpgradeWeaponButton.UseVisualStyleBackColor = true;
            this.UpgradeWeaponButton.Click += new System.EventHandler(this.UpgradeWeaponButton_Click);
            // 
            // UpgradeArmorButton
            // 
            this.UpgradeArmorButton.Location = new System.Drawing.Point(453, 356);
            this.UpgradeArmorButton.Name = "UpgradeArmorButton";
            this.UpgradeArmorButton.Size = new System.Drawing.Size(191, 23);
            this.UpgradeArmorButton.TabIndex = 5;
            this.UpgradeArmorButton.UseVisualStyleBackColor = true;
            this.UpgradeArmorButton.Click += new System.EventHandler(this.UpgradeArmorButton_Click);
            // 
            // UpgradeHelmetButton
            // 
            this.UpgradeHelmetButton.Location = new System.Drawing.Point(453, 327);
            this.UpgradeHelmetButton.Name = "UpgradeHelmetButton";
            this.UpgradeHelmetButton.Size = new System.Drawing.Size(191, 23);
            this.UpgradeHelmetButton.TabIndex = 6;
            this.UpgradeHelmetButton.UseVisualStyleBackColor = true;
            this.UpgradeHelmetButton.Click += new System.EventHandler(this.UpgradeHelmetButton_Click);
            // 
            // Merchant
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.UpgradeHelmetButton);
            this.Controls.Add(this.UpgradeArmorButton);
            this.Controls.Add(this.UpgradeWeaponButton);
            this.Controls.Add(this.UpgradeShieldButton);
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
            if(map.Player.Gold < 100)
            {
                MessageBox.Show("Nie stać cię!");
            }else
            {
                map.Player.Gold -= 100;
                map.Player.CurrentHP = map.Player.MaxHP;
            }
        }

        private void Begin(object sender, EventArgs e)
        {
            if (!map.Player.UnlockedArmors[0])
                UpgradeArmorButton.Hide();
            else
                UpgradeArmorButton.Text = "Ulepsz zbroję (150 sztuk złota)";

            if (!map.Player.UnlockedWeapons[0])
                UpgradeWeaponButton.Hide();
            else
                UpgradeWeaponButton.Text = "Ulepsz broń (150 sztuk złota)";

            if (!map.Player.UnlockedShields[0])
                UpgradeShieldButton.Hide();
            else
                UpgradeShieldButton.Text = "Ulepsz tarczę (150 sztuk złota)";
            if (!map.Player.UnlockedHelmets[0])
                UpgradeHelmetButton.Hide();
            else
                UpgradeHelmetButton.Text = "Ulepsz hełm (180 sztuk złota)";

            if (map.Player.UnlockedArmors[2])
                UpgradeArmorButton.Text = "Ulepsz zbroję (250 sztuk złota)";
            if (map.Player.UnlockedWeapons[2])
                UpgradeWeaponButton.Text = "Ulepsz broń (250 sztuk złota)";
        }

        private void UpgradeCard(object sender, EventArgs e) //TEST THAT
        {
            if (map.Player.Gold < 150)
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
                    map.Player.Gold -= 150;
                    MessageBox.Show("Twoja nowa karta: " + map.Deck.Cards[map.Deck.Cards.Count - 1].Name.ToString() + "/n Opis: " + map.Deck.Cards[map.Deck.Cards.Count - 1].Describtion.ToString() + "/n Wartość: " + map.Deck.Cards[map.Deck.Cards.Count - 1].Value.ToString());
                }
                else
                    MessageBox.Show("Nie masz kart do ulepszenia");
            }
        }
        private System.Windows.Forms.Button HealButton;
        private System.Windows.Forms.Button UpgradeButton;
        private Button ExitButton;
        private Button UpgradeShieldButton;
        private Button UpgradeWeaponButton;
        private Button UpgradeArmorButton;
        private Button UpgradeHelmetButton;
    }
}