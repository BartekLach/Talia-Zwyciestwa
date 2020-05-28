using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Talia_Zwyciestwa.Classes;
using Talia_Zwyciestwa.Classes.Enemies_Types;
using Talia_Zwyciestwa.Classes.Items.Armors;
using Talia_Zwyciestwa.Classes.Items.Helmets;
using Talia_Zwyciestwa.Classes.Items.Shields;
using Talia_Zwyciestwa.Classes.Items.Weapons;

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
            this.Card1.Location = new System.Drawing.Point(170, 240);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(112, 229);
            this.Card1.TabIndex = 0;
            this.Card1.Text = "button1";
            this.Card1.UseVisualStyleBackColor = true;
            this.Card1.Click += new System.EventHandler(this.Card1Picked);
            // 
            // Card2
            // 
            this.Card2.Location = new System.Drawing.Point(288, 240);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(112, 229);
            this.Card2.TabIndex = 0;
            this.Card2.Text = "button1";
            this.Card2.UseVisualStyleBackColor = true;
            this.Card2.Click += new System.EventHandler(this.Card2Picked);
            // 
            // Card3
            // 
            this.Card3.Location = new System.Drawing.Point(406, 240);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(112, 229);
            this.Card3.TabIndex = 0;
            this.Card3.Text = "button1";
            this.Card3.UseVisualStyleBackColor = true;
            this.Card3.Click += new System.EventHandler(this.Card3Picked);
            // 
            // Card4
            // 
            this.Card4.Location = new System.Drawing.Point(524, 240);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(112, 229);
            this.Card4.TabIndex = 0;
            this.Card4.Text = "button1";
            this.Card4.UseVisualStyleBackColor = true;
            this.Card4.Click += new System.EventHandler(this.Card4Picked);
            // 
            // Card5
            // 
            this.Card5.Location = new System.Drawing.Point(642, 240);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(112, 229);
            this.Card5.TabIndex = 0;
            this.Card5.Text = "button1";
            this.Card5.UseVisualStyleBackColor = true;
            this.Card5.Click += new System.EventHandler(this.Card5Picked);
            // 
            // EndTurnButton
            // 
            this.EndTurnButton.Location = new System.Drawing.Point(425, 475);
            this.EndTurnButton.Name = "EndTurnButton";
            this.EndTurnButton.Size = new System.Drawing.Size(75, 23);
            this.EndTurnButton.TabIndex = 1;
            this.EndTurnButton.Text = "EndTurnButton";
            this.EndTurnButton.UseVisualStyleBackColor = true;
            this.EndTurnButton.Click += new System.EventHandler(this.EndTurnClicked);
            // 
            // Fight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
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
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Button Card1;
        private System.Windows.Forms.Button Card2;
        private System.Windows.Forms.Button Card3;
        private System.Windows.Forms.Button Card4;
        private System.Windows.Forms.Button Card5;
        private System.Windows.Forms.Button EndTurnButton;
    }
}