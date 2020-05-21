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
            this.button26 = new System.Windows.Forms.Button();
            this.helmet = new System.Windows.Forms.CheckedListBox();
            this.armor = new System.Windows.Forms.CheckedListBox();
            this.shield = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weapon = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button26
            // 
            this.button26.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button26.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.button26.Location = new System.Drawing.Point(27, 979);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(308, 78);
            this.button26.TabIndex = 27;
            this.button26.Text = "Cofnij";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // helmet
            // 
            this.helmet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.helmet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.helmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helmet.FormattingEnabled = true;
            this.helmet.Items.AddRange(new object[] {
            "Lekki chełm",
            "Średni chełm",
            "Ciżęki chełm"});
            this.helmet.Location = new System.Drawing.Point(121, 303);
            this.helmet.Name = "helmet";
            this.helmet.Size = new System.Drawing.Size(496, 72);
            this.helmet.TabIndex = 28;
            // 
            // armor
            // 
            this.armor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.armor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.armor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.armor.FormattingEnabled = true;
            this.armor.Items.AddRange(new object[] {
            "Lekki pancerz",
            "Średni pancerz",
            "Ciżęki pancerz"});
            this.armor.Location = new System.Drawing.Point(121, 460);
            this.armor.Name = "armor";
            this.armor.Size = new System.Drawing.Size(496, 72);
            this.armor.TabIndex = 30;
            // 
            // shield
            // 
            this.shield.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.shield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shield.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shield.FormattingEnabled = true;
            this.shield.Items.AddRange(new object[] {
            "Lekka tarcza",
            "Średnia tarcza",
            "Ciżęka tarcza"});
            this.shield.Location = new System.Drawing.Point(121, 624);
            this.shield.Name = "shield";
            this.shield.Size = new System.Drawing.Size(496, 72);
            this.shield.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(311, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Chełmy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(299, 426);
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
            this.label3.Location = new System.Drawing.Point(313, 590);
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
            this.label4.Location = new System.Drawing.Point(324, 752);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "Broń";
            // 
            // weapon
            // 
            this.weapon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.weapon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weapon.FormattingEnabled = true;
            this.weapon.Items.AddRange(new object[] {
            "Miecz",
            "Topór",
            "Dobry miecz",
            "Ciężki topór"});
            this.weapon.Location = new System.Drawing.Point(121, 786);
            this.weapon.Name = "weapon";
            this.weapon.Size = new System.Drawing.Size(496, 96);
            this.weapon.TabIndex = 36;
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.equipment_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weapon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shield);
            this.Controls.Add(this.armor);
            this.Controls.Add(this.helmet);
            this.Controls.Add(this.button26);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Equipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.CheckedListBox helmet;
        private System.Windows.Forms.CheckedListBox armor;
        private System.Windows.Forms.CheckedListBox shield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox weapon;
    }
}