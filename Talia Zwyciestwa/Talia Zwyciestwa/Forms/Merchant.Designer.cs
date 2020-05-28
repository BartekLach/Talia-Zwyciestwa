using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Talia_Zwyciestwa.Classes;
using Talia_Zwyciestwa.Classes.Card_Types;
using Talia_Zwyciestwa.Classes.Items.Armors;
using Talia_Zwyciestwa.Classes.Items.Helmets;
using Talia_Zwyciestwa.Classes.Items.Shields;
using Talia_Zwyciestwa.Classes.Items.Weapons;

namespace Talia_Zwyciestwa.Forms
{
    partial class Merchant
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
            this.HealButton = new System.Windows.Forms.Button();
            this.UpgradeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UpgradeShieldButton = new System.Windows.Forms.Button();
            this.UpgradeWeaponButton = new System.Windows.Forms.Button();
            this.UpgradeArmorButton = new System.Windows.Forms.Button();
            this.UpgradeHelmetButton = new System.Windows.Forms.Button();
            this.GoldValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GoldLabel = new System.Windows.Forms.Label();
            this.HelmetUpgradeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ArmorUpgradeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ShieldUpgradeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.WeaponUpgradeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // HealButton
            // 
            this.HealButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HealButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_02;
            this.HealButton.Location = new System.Drawing.Point(140, 364);
            this.HealButton.Name = "HealButton";
            this.HealButton.Size = new System.Drawing.Size(91, 33);
            this.HealButton.TabIndex = 0;
            this.HealButton.Text = "Ulecz (100)";
            this.HealButton.UseVisualStyleBackColor = true;
            this.HealButton.Click += new System.EventHandler(this.Heal);
            // 
            // UpgradeButton
            // 
            this.UpgradeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpgradeButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_02;
            this.UpgradeButton.Location = new System.Drawing.Point(269, 364);
            this.UpgradeButton.Name = "UpgradeButton";
            this.UpgradeButton.Size = new System.Drawing.Size(152, 33);
            this.UpgradeButton.TabIndex = 1;
            this.UpgradeButton.Text = "Ulepsz losową kartę (150)";
            this.UpgradeButton.UseVisualStyleBackColor = true;
            this.UpgradeButton.Click += new System.EventHandler(this.UpgradeCard);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitButton.Location = new System.Drawing.Point(330, 540);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(125, 54);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Wyjdź";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit);
            // 
            // UpgradeShieldButton
            // 
            this.UpgradeShieldButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpgradeShieldButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_02;
            this.UpgradeShieldButton.Location = new System.Drawing.Point(489, 385);
            this.UpgradeShieldButton.Name = "UpgradeShieldButton";
            this.UpgradeShieldButton.Size = new System.Drawing.Size(127, 23);
            this.UpgradeShieldButton.TabIndex = 3;
            this.UpgradeShieldButton.UseVisualStyleBackColor = true;
            this.UpgradeShieldButton.Click += new System.EventHandler(this.UpgradeShieldButton_Click);
            // 
            // UpgradeWeaponButton
            // 
            this.UpgradeWeaponButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpgradeWeaponButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_02;
            this.UpgradeWeaponButton.Location = new System.Drawing.Point(489, 414);
            this.UpgradeWeaponButton.Name = "UpgradeWeaponButton";
            this.UpgradeWeaponButton.Size = new System.Drawing.Size(127, 23);
            this.UpgradeWeaponButton.TabIndex = 4;
            this.UpgradeWeaponButton.UseVisualStyleBackColor = true;
            this.UpgradeWeaponButton.Click += new System.EventHandler(this.UpgradeWeaponButton_Click);
            // 
            // UpgradeArmorButton
            // 
            this.UpgradeArmorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpgradeArmorButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_02;
            this.UpgradeArmorButton.Location = new System.Drawing.Point(489, 356);
            this.UpgradeArmorButton.Name = "UpgradeArmorButton";
            this.UpgradeArmorButton.Size = new System.Drawing.Size(127, 23);
            this.UpgradeArmorButton.TabIndex = 5;
            this.UpgradeArmorButton.UseVisualStyleBackColor = true;
            this.UpgradeArmorButton.Click += new System.EventHandler(this.UpgradeArmorButton_Click);
            // 
            // UpgradeHelmetButton
            // 
            this.UpgradeHelmetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpgradeHelmetButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_02;
            this.UpgradeHelmetButton.Location = new System.Drawing.Point(489, 327);
            this.UpgradeHelmetButton.Name = "UpgradeHelmetButton";
            this.UpgradeHelmetButton.Size = new System.Drawing.Size(127, 23);
            this.UpgradeHelmetButton.TabIndex = 6;
            this.UpgradeHelmetButton.UseVisualStyleBackColor = true;
            this.UpgradeHelmetButton.Click += new System.EventHandler(this.UpgradeHelmetButton_Click);
            // 
            // GoldValue
            // 
            this.GoldValue.AutoSize = true;
            this.GoldValue.BackColor = System.Drawing.Color.Transparent;
            this.GoldValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoldValue.Location = new System.Drawing.Point(449, 482);
            this.GoldValue.Name = "GoldValue";
            this.GoldValue.Size = new System.Drawing.Size(0, 31);
            this.GoldValue.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(231, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 31);
            this.label9.TabIndex = 63;
            this.label9.Text = "Złoto:";
            // 
            // GoldLabel
            // 
            this.GoldLabel.AutoSize = true;
            this.GoldLabel.BackColor = System.Drawing.Color.Transparent;
            this.GoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoldLabel.Location = new System.Drawing.Point(433, 482);
            this.GoldLabel.Name = "GoldLabel";
            this.GoldLabel.Size = new System.Drawing.Size(0, 31);
            this.GoldLabel.TabIndex = 65;
            // 
            // Merchant
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.merchant_01;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.GoldLabel);
            this.Controls.Add(this.GoldValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.UpgradeHelmetButton);
            this.Controls.Add(this.UpgradeArmorButton);
            this.Controls.Add(this.UpgradeWeaponButton);
            this.Controls.Add(this.UpgradeShieldButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UpgradeButton);
            this.Controls.Add(this.HealButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Merchant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handlarz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
            map.Show();
        }
        #endregion/

        private System.Windows.Forms.Button HealButton;
        private System.Windows.Forms.Button UpgradeButton;
        private Button ExitButton;
        private Button UpgradeShieldButton;
        private Button UpgradeWeaponButton;
        private Button UpgradeArmorButton;
        private Button UpgradeHelmetButton;
        private Label GoldValue;
        private Label label9;
        private Label GoldLabel;
        private ToolTip HelmetUpgradeToolTip;
        private ToolTip ArmorUpgradeToolTip;
        private ToolTip ShieldUpgradeToolTip;
        private ToolTip WeaponUpgradeToolTip;
    }
}