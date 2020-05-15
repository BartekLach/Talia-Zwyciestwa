using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talia_Zwyciestwa
{
	public partial class Menu : Form
	{
		private bool isCollapsed;
		public Menu()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (isCollapsed)
			{
				panelDropDown.Height += 10;
				if (panelDropDown.Size == panelDropDown.MaximumSize)
				{
					timer1.Stop();
					isCollapsed = false;
				}
			}
			else
			{
				panelDropDown.Height -= 10;
				if (panelDropDown.Size == panelDropDown.MinimumSize)
				{
					timer1.Stop();
					isCollapsed = true;
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
