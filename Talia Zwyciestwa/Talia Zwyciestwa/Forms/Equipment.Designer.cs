using System;
using System.Drawing;

namespace Talia_Zwyciestwa.Forms
{
    partial class Equipment
    {
        private Map map;
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
                button1.Enabled = false;
            if (!map.Player.UnlockedHelmets[1])
                button2.Enabled = false;

            if (!map.Player.UnlockedArmors[0])
                button4.Enabled = false;
            if (!map.Player.UnlockedArmors[1])
                button3.Enabled = false;
            if (!map.Player.UnlockedArmors[2])
                button6.Enabled = false;

            if (!map.Player.UnlockedShields[0])
                button7.Enabled = false;
            if (!map.Player.UnlockedShields[1])
                button5.Enabled = false;

            if (!map.Player.UnlockedWeapons[0])
                button10.Enabled = false;
            if (!map.Player.UnlockedWeapons[1])
                button9.Enabled = false;
            if (!map.Player.UnlockedWeapons[2])
                button8.Enabled = false;

            switch (map.Player.WornHelmet)
            {
                case 1:
                    button1.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    button2.BackColor = Color.DarkGreen;
                    break;
            }

            switch (map.Player.WornArmor)
            {
                case 1:
                    button4.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    button3.BackColor = Color.DarkGreen;
                    break;
                case 3:
                    button6.BackColor = Color.DarkGreen;
                    break;
            }

            switch (map.Player.WornShield)
            {
                case 1:
                    button7.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    button5.BackColor = Color.DarkGreen;
                    break;
            }

            switch (map.Player.WornWeapon)
            {
                case 1:
                    button10.BackColor = Color.DarkGreen;
                    break;
                case 2:
                    button9.BackColor = Color.DarkGreen;
                    break;
                case 3:
                    button8.BackColor = Color.DarkGreen;
                    break;
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button26 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DexValue = new System.Windows.Forms.Label();
            this.StrValue = new System.Windows.Forms.Label();
            this.MaxHPValue = new System.Windows.Forms.Label();
            this.CurrentHPValue = new System.Windows.Forms.Label();
            this.GoldValue = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button26
            // 
            this.button26.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button26.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.button26.Location = new System.Drawing.Point(21, 645);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(199, 64);
            this.button26.TabIndex = 27;
            this.button26.Text = "Cofnij";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(198, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Hełmy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(179, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "Pancerze";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(193, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 31);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tarcze";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(206, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "Broń";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Image = global::Talia_Zwyciestwa.Properties.Resources.helmet_01;
            this.button1.Location = new System.Drawing.Point(175, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Image = global::Talia_Zwyciestwa.Properties.Resources.helmet_02;
            this.button2.Location = new System.Drawing.Point(245, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 64);
            this.button2.TabIndex = 39;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Image = global::Talia_Zwyciestwa.Properties.Resources.armor_02;
            this.button3.Location = new System.Drawing.Point(210, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 64);
            this.button3.TabIndex = 41;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Image = global::Talia_Zwyciestwa.Properties.Resources.armor_01;
            this.button4.Location = new System.Drawing.Point(140, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 64);
            this.button4.TabIndex = 40;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Image = global::Talia_Zwyciestwa.Properties.Resources.armor_03;
            this.button6.Location = new System.Drawing.Point(280, 315);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 64);
            this.button6.TabIndex = 42;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Image = global::Talia_Zwyciestwa.Properties.Resources.shield_02;
            this.button5.Location = new System.Drawing.Point(245, 432);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 64);
            this.button5.TabIndex = 44;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.Image = global::Talia_Zwyciestwa.Properties.Resources.shield_01;
            this.button7.Location = new System.Drawing.Point(175, 432);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 64);
            this.button7.TabIndex = 43;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.Image = global::Talia_Zwyciestwa.Properties.Resources.weapon_03;
            this.button8.Location = new System.Drawing.Point(280, 548);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 64);
            this.button8.TabIndex = 47;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button9.Image = global::Talia_Zwyciestwa.Properties.Resources.weapon_02;
            this.button9.Location = new System.Drawing.Point(210, 548);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 64);
            this.button9.TabIndex = 46;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.Image = global::Talia_Zwyciestwa.Properties.Resources.weapon_01;
            this.button10.Location = new System.Drawing.Point(140, 548);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(64, 64);
            this.button10.TabIndex = 45;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(873, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 31);
            this.label5.TabIndex = 48;
            this.label5.Text = "Zręczność:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(873, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 31);
            this.label6.TabIndex = 49;
            this.label6.Text = "Siła:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(873, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 31);
            this.label7.TabIndex = 50;
            this.label7.Text = "Maks. życie:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(873, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 31);
            this.label8.TabIndex = 51;
            this.label8.Text = "Aktualne życie:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(873, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 31);
            this.label9.TabIndex = 52;
            this.label9.Text = "Złoto:";
            // 
            // DexValue
            // 
            this.DexValue.AutoSize = true;
            this.DexValue.BackColor = System.Drawing.Color.Transparent;
            this.DexValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DexValue.Location = new System.Drawing.Point(1091, 170);
            this.DexValue.Name = "DexValue";
            this.DexValue.Size = new System.Drawing.Size(0, 31);
            this.DexValue.TabIndex = 58;
            this.DexValue.Click += new System.EventHandler(this.DexValue_Click);
            // 
            // StrValue
            // 
            this.StrValue.AutoSize = true;
            this.StrValue.BackColor = System.Drawing.Color.Transparent;
            this.StrValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StrValue.Location = new System.Drawing.Point(1091, 211);
            this.StrValue.Name = "StrValue";
            this.StrValue.Size = new System.Drawing.Size(0, 31);
            this.StrValue.TabIndex = 59;
            // 
            // MaxHPValue
            // 
            this.MaxHPValue.AutoSize = true;
            this.MaxHPValue.BackColor = System.Drawing.Color.Transparent;
            this.MaxHPValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaxHPValue.Location = new System.Drawing.Point(1091, 252);
            this.MaxHPValue.Name = "MaxHPValue";
            this.MaxHPValue.Size = new System.Drawing.Size(0, 31);
            this.MaxHPValue.TabIndex = 60;
            this.MaxHPValue.Click += new System.EventHandler(this.label11_Click);
            // 
            // CurrentHPValue
            // 
            this.CurrentHPValue.AutoSize = true;
            this.CurrentHPValue.BackColor = System.Drawing.Color.Transparent;
            this.CurrentHPValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentHPValue.Location = new System.Drawing.Point(1091, 295);
            this.CurrentHPValue.Name = "CurrentHPValue";
            this.CurrentHPValue.Size = new System.Drawing.Size(0, 31);
            this.CurrentHPValue.TabIndex = 61;
            // 
            // GoldValue
            // 
            this.GoldValue.AutoSize = true;
            this.GoldValue.BackColor = System.Drawing.Color.Transparent;
            this.GoldValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoldValue.Location = new System.Drawing.Point(1091, 368);
            this.GoldValue.Name = "GoldValue";
            this.GoldValue.Size = new System.Drawing.Size(0, 31);
            this.GoldValue.TabIndex = 62;
            // 
            // button11
            // 
            this.button11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button11.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.button11.Location = new System.Drawing.Point(854, 432);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(364, 64);
            this.button11.TabIndex = 63;
            this.button11.Text = "Pokaż talię";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Equipment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.equipment_01;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.GoldValue);
            this.Controls.Add(this.CurrentHPValue);
            this.Controls.Add(this.MaxHPValue);
            this.Controls.Add(this.StrValue);
            this.Controls.Add(this.DexValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button26);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Equipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion




        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label DexValue;
        private System.Windows.Forms.Label StrValue;
        private System.Windows.Forms.Label MaxHPValue;
        private System.Windows.Forms.Label CurrentHPValue;
        private System.Windows.Forms.Label GoldValue;
        private System.Windows.Forms.Button button11;
    }
}