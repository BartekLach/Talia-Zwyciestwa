using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Talia_Zwyciestwa.Forms;
using Talia_Zwyciestwa.Assets.Music;
using Talia_Zwyciestwa.Classes;
using System.Media;

namespace Talia_Zwyciestwa
{
	public partial class Menu : Form
	{
		private bool isGameOn = false;
		private Map map;
		private SoundPlayer soundPlayer = new SoundPlayer(Music.battleThemeA);
		public Menu()
		{
			InitializeComponent();
		}

		public bool IsGameOn { get => isGameOn; set => isGameOn = value; }
		public void ShowContinueButton(Map m)
		{
			map = m;
			ContinueButton.Show();
		}
		public void HideContinueButton(Map m)
		{
			map = m;
			ContinueButton.Hide();
		}
		private void ExitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ContinueButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			map.Show();
		}
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
	}
}
