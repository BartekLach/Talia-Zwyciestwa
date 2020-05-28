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
			ContinueButton.Hide();
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

		private void HelpButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Witaj! Oto podstawowe zasady w grze:" + "\n"+ "\n" +
				"Poruszanie się po mapie: Na mapie będziesz mieć do wyboru lokacje, do których możesz się wybrać. Mieszek oznacza kupca, skrzyżowane miecze oznaczają walkę, a pytajnik wydarzenie losowe." + "\n" + "\n" +
				"Zagrywanie kart: Podczas walki będziesz mieć do wyboru 5 kart wylosowanych z Twojej talii, zagranie każdej karty kosztuje Cię manę. Koszt karty jest oznaczony cyferką natomiast aktualną manę znajdziesz w swoich statystykach podczas walki" + "\n" + "\n" +
				"Punkty obrony: Podczas przyjmowania przez postać obrażeń punkty obrony są pomniejszone o punkty obrażeń. Jeśli punkty obrony spadną poniżej 0 to liczba punktów życia zostaje pomniejszona o tyle ile punkty obrony spadły poniżej 0 a następnie punkty obrony wracają do 0." +"\n" + "\n" +
				"Ekwipunek: Możesz tam zobaczyć aktualne punkty życia, zgromadzone złoto, swoją talię kart i dysponować swoim ekwipunkiem" +"\n" + "\n" +
				"" );

		}
	}
}
