using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSaveApp
{
    public partial class nameSaveUI : Form
    {
        List<string>myName=new List<string>();
        private string name;
        public nameSaveUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            myName.Add(name);
            MessageBox.Show("Your Information has Saved", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nameTextBox.Clear();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            
            foreach (string i in myName)
            {
                //showAllNameTextBox.Items.Add(i);

                showAllNameTextBox.Text =i;      
                totalNameTextBox.Text = myName.Count.ToString();             
               
            }
        }
       
    }
}
