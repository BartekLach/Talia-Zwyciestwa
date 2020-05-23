using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Talia_Zwyciestwa.Classes;
using Talia_Zwyciestwa.Classes.Enemies_Types;



namespace Talia_Zwyciestwa.Forms
{
    

    partial class Fight
    {

        private Map map;
        private Button[] CardButtons;
        private ToolTip[] toolTips = new ToolTip[5];
        private Player player;
        private Enemy enemy;
        private Card[] hand = new Card[5];
        private List<Card> trash = new List<Card>();
        private List<Card> deck;
        private int currentPower;


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        public Fight(Map m, Enemy e)
        {
            enemy = e;
            map = m;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            
            this.Card1 = new System.Windows.Forms.Button();
            this.Card2 = new System.Windows.Forms.Button();
            this.Card3 = new System.Windows.Forms.Button();
            this.Card4 = new System.Windows.Forms.Button();
            this.Card5 = new System.Windows.Forms.Button();
            this.EndTurnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Card1
            // 
            this.Card1.Location = new System.Drawing.Point(170, 325);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(112, 229);
            this.Card1.TabIndex = 0;
            this.Card1.Text = "button1";
            this.Card1.UseVisualStyleBackColor = true;
            this.Card1.Click += new System.EventHandler(Card1Picked);
            // 
            // Card2
            // 
            this.Card2.Location = new System.Drawing.Point(288, 325);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(112, 229);
            this.Card2.TabIndex = 0;
            this.Card2.Text = "button1";
            this.Card2.UseVisualStyleBackColor = true;
            this.Card2.Click += new System.EventHandler(Card2Picked);
            // 
            // Card3
            // 
            this.Card3.Location = new System.Drawing.Point(406, 325);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(112, 229);
            this.Card3.TabIndex = 0;
            this.Card3.Text = "button1";
            this.Card3.UseVisualStyleBackColor = true;
            this.Card3.Click += new System.EventHandler(Card3Picked);
            // 
            // Card4
            // 
            this.Card4.Location = new System.Drawing.Point(524, 325);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(112, 229);
            this.Card4.TabIndex = 0;
            this.Card4.Text = "button1";
            this.Card4.UseVisualStyleBackColor = true;
            this.Card4.Click += new System.EventHandler(Card4Picked);
            // 
            // Card5
            // 
            this.Card5.Location = new System.Drawing.Point(642, 325);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(112, 229);
            this.Card5.TabIndex = 0;
            this.Card5.Text = "button1";
            this.Card5.UseVisualStyleBackColor = true;
            this.Card5.Click += new System.EventHandler(Card5Picked);
            // 
            // EndTurnButton
            // 
            this.EndTurnButton.Location = new System.Drawing.Point(425, 560);
            this.EndTurnButton.Name = "EndTurnButton";
            this.EndTurnButton.Size = new System.Drawing.Size(75, 23);
            this.EndTurnButton.TabIndex = 1;
            this.EndTurnButton.Text = "EndTurnButton";
            this.EndTurnButton.UseVisualStyleBackColor = true;
            this.EndTurnButton.Click += new System.EventHandler(EndTurnClicked);
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 1005);
            this.Controls.Add(this.EndTurnButton);
            this.Controls.Add(this.Card5);
            this.Controls.Add(this.Card4);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Card1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

            this.Load += new EventHandler(Begin);

        }
        private void Begin(object sender, System.EventArgs e)
        {
            player = map.Player;
            deck = map.Deck.Cards;
            deck.Shuffle();

            for (int i = 0; i < 5; i++)
                hand[i] = null;

            CardButtons = new Button[5];
            CardButtons[0] = Card1;
            CardButtons[1] = Card2;
            CardButtons[2] = Card3;
            CardButtons[3] = Card4;
            CardButtons[4] = Card5;

            currentPower = player.Power;

            for (int i = 0; i < 5; i++)
            {
                toolTips[i] = new ToolTip();
                toolTips[i].AutoPopDelay = 3000;
                toolTips[i].InitialDelay = 500;
                toolTips[i].ReshowDelay = 500;
            }
            FillHand();
        }

        private void EndTurnClicked(object sender, EventArgs e)
        {
            enemy.MakeTurn(player);
            if(player.CurrentHP<=0)
            {
                MessageBox.Show("Przegałeś!!!");
                map.menu.Show();
                map.Close();
                this.Close();
            }
            else
            {
                //MessageBox.Show(player.CurrentHP.ToString());
                currentPower = player.Power;
                ClearHand();
                FillHand();
            }
        }

        private void Card5Picked(object sender, EventArgs e)
        {
            CardPicker(4);
        }

        private void Card4Picked(object sender, EventArgs e)
        {
            CardPicker(3);
        }

        private void Card3Picked(object sender, EventArgs e)
        {

            CardPicker(2);
        }

        private void Card2Picked(object sender, EventArgs e)
        {

            CardPicker(1);
        }

        private void Card1Picked(object sender, EventArgs e)
        {

            CardPicker(0);
        }

        private void CardPicker(int v)
        {
            if (currentPower >= hand[v].Value)
            {
                currentPower -= hand[v].Value;
                hand[v].Effect(player, enemy);
                if(enemy.CurrentHP<=0)
                {
                    ClearHand();
                    TrashToHand();
                    if (map.bossFight)
                    {
                        MessageBox.Show("Uratowałeś świat");
                        map.menu.Show();
                        map.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wygrałeś walkę!!!");
                        map.Show();
                        this.Close();
                    }
                    //TODO: reward
                    
                }
                trash.Add(hand[v]);
                hand[v] = null;
                CardButtons[v].Hide();
            }
            else
                MessageBox.Show("Nie możesz zagrać tej karty");
            
        }

        private void FillHand()
        {
            for (int i = 0; i < 5; i++)
            {
                if(deck.Count==0)
                {
                    TrashToHand(); 
                }
                hand[i] = deck[0];
                deck.RemoveAt(0);
                CardButtons[i].Text = hand[i].Name;
                CardButtons[i].Show();
                toolTips[i].SetToolTip(CardButtons[i], hand[i].Describtion);
            }
        }
        private void TrashToHand()
        {
            foreach (Card card in trash)
            {
                deck.Add(card);
            }
            deck.Shuffle();
            trash.Clear();
        }
        private void ClearHand()
        {
            for(int i = 0; i<5; i++)
            {
                if(hand[i]!=null)
                {
                    trash.Add(hand[i]);
                    hand[i] = null;
                }
            }
        }
  

        private System.Windows.Forms.Button Card1;
        private System.Windows.Forms.Button Card2;
        private System.Windows.Forms.Button Card3;
        private System.Windows.Forms.Button Card4;
        private System.Windows.Forms.Button Card5;
        private System.Windows.Forms.Button EndTurnButton;
    }
}