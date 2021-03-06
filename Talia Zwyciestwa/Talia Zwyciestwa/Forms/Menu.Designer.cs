﻿
using System;
using System.Media;
using System.Windows.Forms;
using Talia_Zwyciestwa.Assets.Music;
using Talia_Zwyciestwa.Classes;

namespace Talia_Zwyciestwa
{
	partial class Menu
	{

		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.LoadButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.LoadButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoadButton.FlatAppearance.BorderSize = 0;
            this.LoadButton.Location = new System.Drawing.Point(180, 453);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(308, 78);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Wczytaj";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.Location = new System.Drawing.Point(180, 622);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(308, 78);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Zamknij";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // playButton
            // 
            this.playButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.Location = new System.Drawing.Point(180, 369);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(308, 78);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Nowa gra";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.PlayButtonClick);
            // 
            // ContinueButton
            // 
            this.ContinueButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContinueButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.ContinueButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ContinueButton.FlatAppearance.BorderSize = 0;
            this.ContinueButton.Location = new System.Drawing.Point(180, 285);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(308, 78);
            this.ContinueButton.TabIndex = 6;
            this.ContinueButton.Text = "Kontynuuj";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HelpButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.HelpButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HelpButton.FlatAppearance.BorderSize = 0;
            this.HelpButton.Location = new System.Drawing.Point(180, 537);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(308, 78);
            this.HelpButton.TabIndex = 7;
            this.HelpButton.Text = "Pomoc";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.menu_background_01;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.LoadButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talia Zwyciestwa";
            this.Load += new System.EventHandler(this.Begin);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button LoadButton;
		private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playButton;
        private Button ContinueButton;
        private Button HelpButton;
    }
}

