using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DAddNumber
{
    public partial class AddNumber : Form
    {
        public AddNumber()
        {
            InitializeComponent();
        }
        List<int> addNumberList = new List<int>();
        private int aNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            aNumber = Convert.ToInt32(numberTextBox.Text);
            if (addNumberList.Contains(aNumber))
            {
                MessageBox.Show("Already Entered Your Value " + aNumber, "Existing Value", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                addNumberList.Add(aNumber);
                displayListBox.Items.Add(aNumber.ToString());
            }
        }
    }
}
