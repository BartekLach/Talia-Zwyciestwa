using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Talia_Zwyciestwa.Classes;

namespace Talia_Zwyciestwa.Forms
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            GameHandler.SaveToFile(this);
            MessageBox.Show("Twój postęp został zapisany.");
        }
    }
}
