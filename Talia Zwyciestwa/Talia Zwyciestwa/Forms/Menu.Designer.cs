
using System;
using System.Media;
using System.Windows.Forms;
using Talia_Zwyciestwa.Assets.Music;
using Talia_Zwyciestwa.Classes;

namespace Talia_Zwyciestwa
{
	partial class Menu
	{
        private SoundPlayer soundPlayer = new SoundPlayer(Music.battleThemeA);
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
            this.components = new System.ComponentModel.Container();
            this.LoadButton = new System.Windows.Forms.Button();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.panelDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.LoadButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoadButton.FlatAppearance.BorderSize = 0;
            this.LoadButton.Location = new System.Drawing.Point(346, 565);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(308, 78);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Wczytaj";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButtonClick);
            // 
            // panelDropDown
            // 
            this.panelDropDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDropDown.BackColor = System.Drawing.Color.FloralWhite;
            this.panelDropDown.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.panelDropDown.Controls.Add(this.button6);
            this.panelDropDown.Controls.Add(this.button5);
            this.panelDropDown.Controls.Add(this.button4);
            this.panelDropDown.Controls.Add(this.button3);
            this.panelDropDown.Location = new System.Drawing.Point(346, 652);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(308, 226);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(308, 78);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(308, 78);
            this.panelDropDown.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button6.Location = new System.Drawing.Point(0, 176);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(308, 49);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button5.Location = new System.Drawing.Point(0, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(308, 49);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.Location = new System.Drawing.Point(0, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(308, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(308, 78);
            this.button3.TabIndex = 2;
            this.button3.Text = "Opcje";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exitButton
            // 
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.Location = new System.Drawing.Point(421, 947);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(168, 62);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Zamknij";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // playButton
            // 
            this.playButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playButton.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.button_background_01;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.Location = new System.Drawing.Point(346, 479);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(308, 78);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Graj";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.PlayButtonClick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = global::Talia_Zwyciestwa.Properties.Resources.menu_background_01;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panelDropDown);
            this.Controls.Add(this.LoadButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talia Zwyciestwa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Begin);
            this.panelDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private void Begin(object sender, System.EventArgs e)
        {
            soundPlayer.PlayLooping();
        }
            private void LoadButtonClick(object sender, EventArgs e)
        {
            GameHandler.Load(this);
        }

        private void PlayButtonClick(object sender, EventArgs e)
        {
            GameHandler.Play(this);
        }
        private System.Windows.Forms.Button LoadButton;
		private System.Windows.Forms.Panel panelDropDown;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playButton;


    }
}

