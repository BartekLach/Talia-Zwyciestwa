using System;
using System.Drawing;
using System.Windows.Forms;
using Talia_Zwyciestwa.Classes;
using Talia_Zwyciestwa.Classes.Enemies_Types;

namespace Talia_Zwyciestwa.Forms
{
    partial class Map
    {
        public Menu menu;
        private Player player;
        private Deck deck;

        
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
        public Map(Menu m)
        {
            menu = m;
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.EQButton = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(775, 833);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1Clicked);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(743, 694);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 64);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2Clicked);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(884, 805);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 64);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3Clicked);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1009, 819);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 64);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4Clicked);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1120, 747);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 64);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5Clicked);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1195, 916);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 64);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6Clicked);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1294, 644);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 64);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7Clicked);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(1676, 682);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 64);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8Clicked);
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(1630, 800);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 64);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9Clicked);
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(1684, 908);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(64, 64);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10Clicked);
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(1585, 523);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(64, 64);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11Clicked);
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(1450, 446);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(64, 64);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12Clicked);
            // 
            // button13
            // 
            this.button13.Enabled = false;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(1726, 297);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(64, 64);
            this.button13.TabIndex = 12;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13Clicked);
            // 
            // button14
            // 
            this.button14.Enabled = false;
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.Location = new System.Drawing.Point(1652, 386);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(64, 64);
            this.button14.TabIndex = 13;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14Clicked);
            // 
            // button15
            // 
            this.button15.Enabled = false;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(1267, 466);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(64, 64);
            this.button15.TabIndex = 14;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15Clicked);
            // 
            // button16
            // 
            this.button16.Enabled = false;
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.Location = new System.Drawing.Point(1243, 310);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(64, 64);
            this.button16.TabIndex = 15;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16Clicked);
            // 
            // button17
            // 
            this.button17.Enabled = false;
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.Location = new System.Drawing.Point(1057, 338);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(64, 64);
            this.button17.TabIndex = 16;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17Clicked);
            // 
            // button18
            // 
            this.button18.Enabled = false;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.Location = new System.Drawing.Point(850, 322);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(64, 64);
            this.button18.TabIndex = 17;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18Clicked);
            // 
            // button19
            // 
            this.button19.Enabled = false;
            this.button19.Image = ((System.Drawing.Image)(resources.GetObject("button19.Image")));
            this.button19.Location = new System.Drawing.Point(1010, 480);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(64, 64);
            this.button19.TabIndex = 18;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19Clicked);
            // 
            // button20
            // 
            this.button20.Enabled = false;
            this.button20.Image = ((System.Drawing.Image)(resources.GetObject("button20.Image")));
            this.button20.Location = new System.Drawing.Point(661, 249);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(64, 64);
            this.button20.TabIndex = 19;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20Clicked);
            // 
            // button21
            // 
            this.button21.Enabled = false;
            this.button21.Image = ((System.Drawing.Image)(resources.GetObject("button21.Image")));
            this.button21.Location = new System.Drawing.Point(695, 379);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(64, 64);
            this.button21.TabIndex = 20;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21Clicked);
            // 
            // button22
            // 
            this.button22.Enabled = false;
            this.button22.Image = ((System.Drawing.Image)(resources.GetObject("button22.Image")));
            this.button22.Location = new System.Drawing.Point(487, 240);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(64, 64);
            this.button22.TabIndex = 21;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22Clicked);
            // 
            // button23
            // 
            this.button23.Enabled = false;
            this.button23.Image = ((System.Drawing.Image)(resources.GetObject("button23.Image")));
            this.button23.Location = new System.Drawing.Point(537, 398);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(64, 64);
            this.button23.TabIndex = 22;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23Clicked);
            // 
            // button24
            // 
            this.button24.Enabled = false;
            this.button24.Image = ((System.Drawing.Image)(resources.GetObject("button24.Image")));
            this.button24.Location = new System.Drawing.Point(260, 492);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(64, 64);
            this.button24.TabIndex = 23;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24Clicked);
            // 
            // button25
            // 
            this.button25.Enabled = false;
            this.button25.Image = ((System.Drawing.Image)(resources.GetObject("button25.Image")));
            this.button25.Location = new System.Drawing.Point(338, 349);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(64, 64);
            this.button25.TabIndex = 24;
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25Clicked);
            // 
            // EQButton
            // 
            this.EQButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EQButton.BackgroundImage")));
            this.EQButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EQButton.FlatAppearance.BorderSize = 0;
            this.EQButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.EQButton.Location = new System.Drawing.Point(33, 64);
            this.EQButton.Name = "EQButton";
            this.EQButton.Size = new System.Drawing.Size(308, 78);
            this.EQButton.TabIndex = 25;
            this.EQButton.Text = "Ekwipunek";
            this.EQButton.UseVisualStyleBackColor = true;
            this.EQButton.Click += new System.EventHandler(this.EQButtonClick);
            // 
            // button26
            // 
            this.button26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button26.BackgroundImage")));
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.button26.Location = new System.Drawing.Point(33, 939);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(308, 78);
            this.button26.TabIndex = 26;
            this.button26.Text = "Cofnij";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1300, 1044);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.EQButton);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Begin);
            this.ResumeLayout(false);

        }

        private void button25Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button24Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button23Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button22Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button21Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button20Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button19Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button18Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button17Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button16Clicked(object sender, EventArgs e)
        {
            GameHandler.FightEngager(this, new EnemyElite());
        }

        private void button15Clicked(object sender, EventArgs e)
        {
            GameHandler.FightEngager(this, new EnemyCommon());
        }

        private void button14Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button13Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button12Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button11Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button10Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button9Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button8Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button7Clicked(object sender, EventArgs e)
        {
            GameHandler.FightEngager(this, new EnemyCommon());
        }

        private void button6Clicked(object sender, EventArgs e)
        {
            GameHandler.MerchantLauncher(this);
        }

        private void button5Clicked(object sender, EventArgs e)
        {
            GameHandler.RandomEvent(this);
        }

        private void button4Clicked(object sender, EventArgs e)
        {
            GameHandler.FightEngager(this, new EnemyCommon());
        }

        private void button3Clicked(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Blue;
            button2.Enabled = false;
            button3.Enabled = true;
            button3.BackColor = Color.Black;
            GameHandler.FightEngager(this, new EnemyCommon());
        }
        private void button2Clicked(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Blue;
            button2.Enabled = false;
            button3.Enabled = true;
            button3.BackColor = Color.Black;
            GameHandler.FightEngager(this, new EnemyCommon());
        }

        private void button1Clicked(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.BackColor = Color.Gray;
            button1.Enabled = false;
            button3.Enabled = true;
            button3.BackColor = Color.Black;
            GameHandler.RandomEvent(this);
        }

        private void Begin(object sender, System.EventArgs e)
        {
            deck = new Deck();
            player = new Player();
        
        }

        

        private void EQButtonClick(object sender, EventArgs e)
        {
            GameHandler.ShowEQ(this);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button EQButton;
        private System.Windows.Forms.Button button26;
  
        internal Deck Deck { get => deck; set => deck = value; }
        internal Player Player { get => player; set => player = value; }
    }
}