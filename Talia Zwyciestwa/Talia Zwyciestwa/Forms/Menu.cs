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

namespace Talia_Zwyciestwa
{
	public partial class Menu : Form
	{
		private bool isGameOn = false;
		private Map map;
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
	}
}
