﻿using System;
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
		public Menu()
		{
			InitializeComponent();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
