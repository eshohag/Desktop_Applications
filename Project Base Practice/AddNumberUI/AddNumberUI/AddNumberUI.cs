using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddNumberUI
{
    public partial class AddNumberUI : Form
    {
        List<int>myListArray=new List<int>();
        private int number;
        public AddNumberUI()
        {
            InitializeComponent();
        }
        private void Addbutton_Click(object sender, EventArgs e)
        {          
            number = Convert.ToInt32(numberTextBox.Text);        
            if (myListArray.Contains(number))
            {
                MessageBox.Show("Already Entered Your Value","Existing Value",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                myListArray.Add(number);
                showListBox.Items.Add(number.ToString());
            }   
        }
    }
}
