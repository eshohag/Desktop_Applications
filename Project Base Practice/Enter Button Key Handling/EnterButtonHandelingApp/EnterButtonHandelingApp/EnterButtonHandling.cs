using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterButtonHandelingApp
{
    public partial class EnterButtonHandling : Form
    {
        public EnterButtonHandling()
        {
            InitializeComponent();
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                schoolTextBox.Focus();
            }
        }

        private void schoolTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                districtTextBox.Focus();
            }
        }

        private void districtTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showButton.Focus();
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string school = schoolTextBox.Text;
            string district = districtTextBox.Text;
            MessageBox.Show("Hello "+name + "\nYour School is " + school + "\nYour District is " + district,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
