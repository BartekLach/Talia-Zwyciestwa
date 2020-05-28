using System;
using System.Drawing;
using Talia_Zwyciestwa.Classes.Items.Armors;
using Talia_Zwyciestwa.Classes.Items.Helmets;
using Talia_Zwyciestwa.Classes.Items.Shields;
using Talia_Zwyciestwa.Classes.Items.Weapons;

namespace Talia_Zwyciestwa.Forms
{
    partial class Equipment
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
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            this.button26 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LightHelmetButton = new System.Windows.Forms.Button();
            this.HeavyHelmetButton = new System.Windows.Forms.Button();
            this.MediumArmorButton = new System.Windows.Forms.Button();
            this.LightArmorButton = new System.Windows.Forms.Button();
            this.HeavyArmorButton = new System.Windows.Forms.Button();
            this.HeavyShieldButton = new System.Windows.Forms.Button();
            this.LightShieldButton = new System.Windows.Forms.Button();
            this.HeavyWeaponButton = new System.Windows.Forms.Button();
            this.MediumWeaponButton = new System.Windows.Forms.Button();
            this.LightWeaponButton = new System.Windows.Forms.Button();
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
            this.LightHelmetToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HeavyHelmetToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LightArmorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MediumArmorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HeavyArmorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LightShieldToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HeavyShieldToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MediumWeaponToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HeavyWeaponToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LightWeaponToolTip = new System.Windows.Forms.ToolTip(this.components);
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
            // LightHelmetButton
            // 
            this.LightHelmetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LightHelmetButton.Image = global::Talia_Zwyciestwa.Properties.Resources.helmet_01;
            this.LightHelmetButton.Location = new System.Drawing.Point(175, 206);
            this.LightHelmetButton.Name = "LightHelmetButton";
            this.LightHelmetButton.Size = new System.Drawing.Size(64, 64);
            this.LightHelmetButton.TabIndex = 38;
            this.LightHelmetButton.UseVisualStyleBackColor = true;
            this.LightHelmetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // HeavyHelmetButton
            // 
            this.HeavyHelmetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeavyHelmetButton.Image = global::Talia_Zwyciestwa.Properties.Resources.helmet_02;
            this.HeavyHelmetButton.Location = new System.Drawing.Point(245, 206);
            this.HeavyHelmetButton.Name = "HeavyHelmetButton";
            this.HeavyHelmetButton.Size = new System.Drawing.Size(64, 64);
            this.HeavyHelmetButton.TabIndex = 39;
            this.HeavyHelmetButton.UseVisualStyleBackColor = true;
            this.HeavyHelmetButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MediumArmorButton
            // 
            this.MediumArmorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MediumArmorButton.Image = global::Talia_Zwyciestwa.Properties.Resources.armor_02;
            this.MediumArmorButton.Location = new System.Drawing.Point(210, 315);
            this.MediumArmorButton.Name = "MediumArmorButton";
            this.MediumArmorButton.Size = new System.Drawing.Size(64, 64);
            this.MediumArmorButton.TabIndex = 41;
            this.MediumArmorButton.UseVisualStyleBackColor = true;
            this.MediumArmorButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // LightArmorButton
            // 
            this.LightArmorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LightArmorButton.Image = global::Talia_Zwyciestwa.Properties.Resources.armor_01;
            this.LightArmorButton.Location = new System.Drawing.Point(140, 315);
            this.LightArmorButton.Name = "LightArmorButton";
            this.LightArmorButton.Size = new System.Drawing.Size(64, 64);
            this.LightArmorButton.TabIndex = 40;
            this.LightArmorButton.UseVisualStyleBackColor = true;
            this.LightArmorButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // HeavyArmorButton
            // 
            this.HeavyArmorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeavyArmorButton.Image = global::Talia_Zwyciestwa.Properties.Resources.armor_03;
            this.HeavyArmorButton.Location = new System.Drawing.Point(280, 315);
            this.HeavyArmorButton.Name = "HeavyArmorButton";
            this.HeavyArmorButton.Size = new System.Drawing.Size(64, 64);
            this.HeavyArmorButton.TabIndex = 42;
            this.HeavyArmorButton.UseVisualStyleBackColor = true;
            this.HeavyArmorButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // HeavyShieldButton
            // 
            this.HeavyShieldButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeavyShieldButton.Image = global::Talia_Zwyciestwa.Properties.Resources.shield_02;
            this.HeavyShieldButton.Location = new System.Drawing.Point(245, 432);
            this.HeavyShieldButton.Name = "HeavyShieldButton";
            this.HeavyShieldButton.Size = new System.Drawing.Size(64, 64);
            this.HeavyShieldButton.TabIndex = 44;
            this.HeavyShieldButton.UseVisualStyleBackColor = true;
            this.HeavyShieldButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // LightShieldButton
            // 
            this.LightShieldButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LightShieldButton.Image = global::Talia_Zwyciestwa.Properties.Resources.shield_01;
            this.LightShieldButton.Location = new System.Drawing.Point(175, 432);
            this.LightShieldButton.Name = "LightShieldButton";
            this.LightShieldButton.Size = new System.Drawing.Size(64, 64);
            this.LightShieldButton.TabIndex = 43;
            this.LightShieldButton.UseVisualStyleBackColor = true;
            this.LightShieldButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // HeavyWeaponButton
            // 
            this.HeavyWeaponButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeavyWeaponButton.Image = global::Talia_Zwyciestwa.Properties.Resources.weapon_03;
            this.HeavyWeaponButton.Location = new System.Drawing.Point(280, 548);
            this.HeavyWeaponButton.Name = "HeavyWeaponButton";
            this.HeavyWeaponButton.Size = new System.Drawing.Size(64, 64);
            this.HeavyWeaponButton.TabIndex = 47;
            this.HeavyWeaponButton.UseVisualStyleBackColor = true;
            this.HeavyWeaponButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // MediumWeaponButton
            // 
            this.MediumWeaponButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MediumWeaponButton.Image = global::Talia_Zwyciestwa.Properties.Resources.weapon_02;
            this.MediumWeaponButton.Location = new System.Drawing.Point(210, 548);
            this.MediumWeaponButton.Name = "MediumWeaponButton";
            this.MediumWeaponButton.Size = new System.Drawing.Size(64, 64);
            this.MediumWeaponButton.TabIndex = 46;
            this.MediumWeaponButton.UseVisualStyleBackColor = true;
            this.MediumWeaponButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // LightWeaponButton
            // 
            this.LightWeaponButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LightWeaponButton.Image = global::Talia_Zwyciestwa.Properties.Resources.weapon_01;
            this.LightWeaponButton.Location = new System.Drawing.Point(140, 548);
            this.LightWeaponButton.Name = "LightWeaponButton";
            this.LightWeaponButton.Size = new System.Drawing.Size(64, 64);
            this.LightWeaponButton.TabIndex = 45;
            this.LightWeaponButton.UseVisualStyleBackColor = true;
            this.LightWeaponButton.Click += new System.EventHandler(this.button10_Click);
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
            this.Controls.Add(this.HeavyWeaponButton);
            this.Controls.Add(this.MediumWeaponButton);
            this.Controls.Add(this.LightWeaponButton);
            this.Controls.Add(this.HeavyShieldButton);
            this.Controls.Add(this.LightShieldButton);
            this.Controls.Add(this.HeavyArmorButton);
            this.Controls.Add(this.MediumArmorButton);
            this.Controls.Add(this.LightArmorButton);
            this.Controls.Add(this.HeavyHelmetButton);
            this.Controls.Add(this.LightHelmetButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button26);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button LightHelmetButton;
        private System.Windows.Forms.Button HeavyHelmetButton;
        private System.Windows.Forms.Button MediumArmorButton;
        private System.Windows.Forms.Button LightArmorButton;
        private System.Windows.Forms.Button HeavyArmorButton;
        private System.Windows.Forms.Button HeavyShieldButton;
        private System.Windows.Forms.Button LightShieldButton;
        private System.Windows.Forms.Button HeavyWeaponButton;
        private System.Windows.Forms.Button MediumWeaponButton;
        private System.Windows.Forms.Button LightWeaponButton;
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
        private System.Windows.Forms.ToolTip LightHelmetToolTip;
        private System.Windows.Forms.ToolTip HeavyHelmetToolTip;
        private System.Windows.Forms.ToolTip LightArmorToolTip;
        private System.Windows.Forms.ToolTip MediumArmorToolTip;
        private System.Windows.Forms.ToolTip HeavyArmorToolTip;
        private System.Windows.Forms.ToolTip LightShieldToolTip;
        private System.Windows.Forms.ToolTip HeavyShieldToolTip;
        private System.Windows.Forms.ToolTip MediumWeaponToolTip;
        private System.Windows.Forms.ToolTip HeavyWeaponToolTip;
        private System.Windows.Forms.ToolTip LightWeaponToolTip;
    }
}