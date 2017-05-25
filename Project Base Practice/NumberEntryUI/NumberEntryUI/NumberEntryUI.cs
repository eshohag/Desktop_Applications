using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberEntryUI
{
    public partial class NumberEntryUI : Form
    {
        List<double> numbers = new List<double>(); 
        public NumberEntryUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(enterNumberTextBox.Text);
            if (numbers.Contains(number))
            {
                MessageBox.Show("Number Is Already Entered in Database", "Existing Number", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                numbers.Add(number);
                MessageBox.Show("Saved Your Number In our Database","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            
            foreach (double numberA in numbers)
            {
                showListBox.Items.Add(numberA);

            }
            
            sumResultTextBox.Text=numbers.Count.ToString();

        }
    }
}
