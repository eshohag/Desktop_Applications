using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            MessageBox.Show("Hello " + name);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            //string item = foodComboBox.Text;
            //MessageBox.Show(item, "Food Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            //if (oddRadioButton.Checked)
            //{
            //    MessageBox.Show("Odd");
            //}
            //else if (evenRadioButton.Checked)
            //{
            //    MessageBox.Show("Even");
            //}
            //else
            //{
            //    MessageBox.Show("Please select one");
            //}
            if (oddCheckBox.Checked && evenCheckBox.Checked)
            {
                MessageBox.Show("Both");
            }
            else if (oddCheckBox.Checked)
            {
                MessageBox.Show("Odd");
            }
            else if (evenCheckBox.Checked)
            {
                MessageBox.Show("Even");
            }
            else
            {
                MessageBox.Show("Please select one");
            }
        }
    }
}
