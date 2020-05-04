namespace Talia_Zwyciestwa
{
	partial class B
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B));
            this.button2 = new System.Windows.Forms.Button();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(346, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "Wczytaj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelDropDown
            // 
            this.panelDropDown.BackColor = System.Drawing.Color.FloralWhite;
            this.panelDropDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDropDown.BackgroundImage")));
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
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
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
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
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
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
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
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
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
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.Location = new System.Drawing.Point(1677, 954);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(168, 62);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Zamknij";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(346, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 78);
            this.button1.TabIndex = 5;
            this.button1.Text = "Graj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panelDropDown);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("BlackCastleMF", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "B";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talia Zwyciestwa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panelDropDown;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
    }
}

