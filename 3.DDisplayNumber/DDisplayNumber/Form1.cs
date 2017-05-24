using System;
using System.Windows.Forms;

namespace DDisplayNumber
{
    public partial class DisplayUI : Form
    {
        public DisplayUI()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            int aNumber = Convert.ToInt32(numberTextBox.Text);
            displayListBox.Items.Clear();
            for (int i = 0; i <= aNumber; i++)
            {
                displayListBox.Items.Add(i);
            }
        }
    }
}
