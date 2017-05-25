using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonCheckBoxApp
{
    public partial class RadioCheckBoxUI : Form
    {
        public RadioCheckBoxUI()
        {
            InitializeComponent();
        }
        private void showAnsRadioButton_Click(object sender, EventArgs e)
        {
            
            if (yesRadioButton.Checked)
            {
                MessageBox.Show("Confirm your Identity?\n Your Ans is Yes");
            }
            else if (noRadioButton.Checked)
            {
                MessageBox.Show("Confirm your Identity? \nYour Ans is No");
            }
            else
            {
                MessageBox.Show("Please checked your Answer!","Any one checked item",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
           
        }

        private void showAnsCheckBoxButton_Click(object sender, EventArgs e)
        {
             if (yesCheckBox.Checked && noCheckBox.Checked)
            {
                MessageBox.Show("Bothe are checked");
            }
            else if (yesCheckBox.Checked)
            {
                MessageBox.Show("Yes");
            }
            else if (noCheckBox.Checked)
            {
                MessageBox.Show("No");
            }  
            else
            {
                MessageBox.Show("Please Checked");
            }
        }    
    }
}
