using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetUI
{
    public partial class PlanetNameUI : Form
    {
        public PlanetNameUI()
        {
            InitializeComponent();
        }

        private void showPlanetButton_Click(object sender, EventArgs e)
        {
            string planetName = planetNameComboBoxText.Text;
            MessageBox.Show(planetName, "Your Choice ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
