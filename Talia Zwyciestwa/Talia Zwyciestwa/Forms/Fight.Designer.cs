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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fight));
            this.Card1 = new System.Windows.Forms.Button();
            this.Card2 = new System.Windows.Forms.Button();
            this.Card3 = new System.Windows.Forms.Button();
            this.Card4 = new System.Windows.Forms.Button();
            this.Card5 = new System.Windows.Forms.Button();
            this.EndTurnButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PlayerDexValue = new System.Windows.Forms.Label();
            this.PlayerHPValue = new System.Windows.Forms.Label();
            this.PlayerPowerValue = new System.Windows.Forms.Label();
            this.PlayerStrValue = new System.Windows.Forms.Label();
            this.EnemyHPValue = new System.Windows.Forms.Label();
            this.EnemyStrValue = new System.Windows.Forms.Label();
            this.EnemyDexValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PlayerPOValue = new System.Windows.Forms.Label();
            this.EnemyPOValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Card1
            // 
            this.Card1.Location = new System.Drawing.Point(348, 415);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(112, 229);
            this.Card1.TabIndex = 0;
            this.Card1.UseVisualStyleBackColor = true;
            this.Card1.Click += new System.EventHandler(this.Card1Picked);
            // 
            // Card2
            // 
            this.Card2.Location = new System.Drawing.Point(466, 415);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(112, 229);
            this.Card2.TabIndex = 0;
            this.Card2.UseVisualStyleBackColor = true;
            this.Card2.Click += new System.EventHandler(this.Card2Picked);
            // 
            // Card3
            // 
            this.Card3.Location = new System.Drawing.Point(584, 415);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(112, 229);
            this.Card3.TabIndex = 0;
            this.Card3.UseVisualStyleBackColor = true;
            this.Card3.Click += new System.EventHandler(this.Card3Picked);
            // 
            // Card4
            // 
            this.Card4.Location = new System.Drawing.Point(702, 415);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(112, 229);
            this.Card4.TabIndex = 0;
            this.Card4.UseVisualStyleBackColor = true;
            this.Card4.Click += new System.EventHandler(this.Card4Picked);
            // 
            // Card5
            // 
            this.Card5.Location = new System.Drawing.Point(820, 415);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(112, 229);
            this.Card5.TabIndex = 0;
            this.Card5.UseVisualStyleBackColor = true;
            this.Card5.Click += new System.EventHandler(this.Card5Picked);
            // 
            // EndTurnButton
            // 
            this.EndTurnButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EndTurnButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.EndTurnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EndTurnButton.Location = new System.Drawing.Point(564, 657);
            this.EndTurnButton.Name = "EndTurnButton";
            this.EndTurnButton.Size = new System.Drawing.Size(150, 55);
            this.EndTurnButton.TabIndex = 1;
            this.EndTurnButton.Text = "Zakończ turę";
            this.EndTurnButton.UseVisualStyleBackColor = true;
            this.EndTurnButton.Click += new System.EventHandler(this.EndTurnClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label8.Location = new System.Drawing.Point(40, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 29);
            this.label8.TabIndex = 55;
            this.label8.Text = "Życie:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.Location = new System.Drawing.Point(40, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 29);
            this.label6.TabIndex = 53;
            this.label6.Text = "Siła:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(40, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 29);
            this.label5.TabIndex = 52;
            this.label5.Text = "Zręczność:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(40, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(913, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 59;
            this.label3.Text = "Życie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(913, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 31);
            this.label4.TabIndex = 58;
            this.label4.Text = "Siła:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(913, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 31);
            this.label7.TabIndex = 57;
            this.label7.Text = "Zręczność:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(397, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(486, 24);
            this.label9.TabIndex = 61;
            this.label9.Text = "Najeżdżając na kartę możesz zobaczyć jej dokładny opis";
            // 
            // PlayerDexValue
            // 
            this.PlayerDexValue.AutoSize = true;
            this.PlayerDexValue.BackColor = System.Drawing.Color.Transparent;
            this.PlayerDexValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerDexValue.Location = new System.Drawing.Point(235, 92);
            this.PlayerDexValue.Name = "PlayerDexValue";
            this.PlayerDexValue.Size = new System.Drawing.Size(129, 29);
            this.PlayerDexValue.TabIndex = 62;
            this.PlayerDexValue.Text = "Zręczność:";
            // 
            // PlayerHPValue
            // 
            this.PlayerHPValue.AutoSize = true;
            this.PlayerHPValue.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHPValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerHPValue.Location = new System.Drawing.Point(235, 232);
            this.PlayerHPValue.Name = "PlayerHPValue";
            this.PlayerHPValue.Size = new System.Drawing.Size(129, 29);
            this.PlayerHPValue.TabIndex = 63;
            this.PlayerHPValue.Text = "Zręczność:";
            // 
            // PlayerPowerValue
            // 
            this.PlayerPowerValue.AutoSize = true;
            this.PlayerPowerValue.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPowerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerPowerValue.Location = new System.Drawing.Point(235, 162);
            this.PlayerPowerValue.Name = "PlayerPowerValue";
            this.PlayerPowerValue.Size = new System.Drawing.Size(129, 29);
            this.PlayerPowerValue.TabIndex = 64;
            this.PlayerPowerValue.Text = "Zręczność:";
            // 
            // PlayerStrValue
            // 
            this.PlayerStrValue.AutoSize = true;
            this.PlayerStrValue.BackColor = System.Drawing.Color.Transparent;
            this.PlayerStrValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerStrValue.Location = new System.Drawing.Point(235, 127);
            this.PlayerStrValue.Name = "PlayerStrValue";
            this.PlayerStrValue.Size = new System.Drawing.Size(129, 29);
            this.PlayerStrValue.TabIndex = 65;
            this.PlayerStrValue.Text = "Zręczność:";
            // 
            // EnemyHPValue
            // 
            this.EnemyHPValue.AutoSize = true;
            this.EnemyHPValue.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHPValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EnemyHPValue.Location = new System.Drawing.Point(1119, 224);
            this.EnemyHPValue.Name = "EnemyHPValue";
            this.EnemyHPValue.Size = new System.Drawing.Size(149, 31);
            this.EnemyHPValue.TabIndex = 66;
            this.EnemyHPValue.Text = "Zręczność:";
            // 
            // EnemyStrValue
            // 
            this.EnemyStrValue.AutoSize = true;
            this.EnemyStrValue.BackColor = System.Drawing.Color.Transparent;
            this.EnemyStrValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EnemyStrValue.Location = new System.Drawing.Point(1119, 136);
            this.EnemyStrValue.Name = "EnemyStrValue";
            this.EnemyStrValue.Size = new System.Drawing.Size(149, 31);
            this.EnemyStrValue.TabIndex = 67;
            this.EnemyStrValue.Text = "Zręczność:";
            // 
            // EnemyDexValue
            // 
            this.EnemyDexValue.AutoSize = true;
            this.EnemyDexValue.BackColor = System.Drawing.Color.Transparent;
            this.EnemyDexValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EnemyDexValue.Location = new System.Drawing.Point(1119, 91);
            this.EnemyDexValue.Name = "EnemyDexValue";
            this.EnemyDexValue.Size = new System.Drawing.Size(149, 31);
            this.EnemyDexValue.TabIndex = 68;
            this.EnemyDexValue.Text = "Zręczność:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(40, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 69;
            this.label2.Text = "Punkty Obrony:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(913, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 31);
            this.label10.TabIndex = 70;
            this.label10.Text = "Punkty Obrony:";
            // 
            // PlayerPOValue
            // 
            this.PlayerPOValue.AutoSize = true;
            this.PlayerPOValue.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPOValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerPOValue.Location = new System.Drawing.Point(235, 197);
            this.PlayerPOValue.Name = "PlayerPOValue";
            this.PlayerPOValue.Size = new System.Drawing.Size(129, 29);
            this.PlayerPOValue.TabIndex = 71;
            this.PlayerPOValue.Text = "Zręczność:";
            // 
            // EnemyPOValue
            // 
            this.EnemyPOValue.AutoSize = true;
            this.EnemyPOValue.BackColor = System.Drawing.Color.Transparent;
            this.EnemyPOValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EnemyPOValue.Location = new System.Drawing.Point(1119, 180);
            this.EnemyPOValue.Name = "EnemyPOValue";
            this.EnemyPOValue.Size = new System.Drawing.Size(149, 31);
            this.EnemyPOValue.TabIndex = 72;
            this.EnemyPOValue.Text = "Zręczność:";
            // 
            // Fight
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.fight_01;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.EnemyPOValue);
            this.Controls.Add(this.PlayerPOValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnemyDexValue);
            this.Controls.Add(this.EnemyStrValue);
            this.Controls.Add(this.EnemyHPValue);
            this.Controls.Add(this.PlayerStrValue);
            this.Controls.Add(this.PlayerPowerValue);
            this.Controls.Add(this.PlayerHPValue);
            this.Controls.Add(this.PlayerDexValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EndTurnButton);
            this.Controls.Add(this.Card5);
            this.Controls.Add(this.Card4);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Card1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Button Card1;
        private System.Windows.Forms.Button Card2;
        private System.Windows.Forms.Button Card3;
        private System.Windows.Forms.Button Card4;
        private System.Windows.Forms.Button Card5;
        private System.Windows.Forms.Button EndTurnButton;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label9;
        private Label PlayerDexValue;
        private Label PlayerHPValue;
        private Label PlayerPowerValue;
        private Label PlayerStrValue;
        private Label EnemyHPValue;
        private Label EnemyStrValue;
        private Label EnemyDexValue;
        private Label label2;
        private Label label10;
        private Label PlayerPOValue;
        private Label EnemyPOValue;
    }
}