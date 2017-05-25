using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxApp
{
    public partial class ListBoxItemDeleteUI : Form
    {
        List<String>myArrayName=new List<string>();
        private string name;
        public ListBoxItemDeleteUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            if (name != "")
            {
                if (myArrayName.Contains(name))
                {
                    MessageBox.Show("Already ENtered Name");
                }
                else
                {
                    myArrayName.Add(name);
                    nameTextBox.Clear();
                    nameListBox.Items.Add(name);
                }
               
            }
            else
            {
                MessageBox.Show("Please Enter Your Name", "Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (nameListBox.SelectedIndex >= 0)
            {
                nameListBox.Items.RemoveAt(nameListBox.SelectedIndex);
                //myArrayName.RemoveAt(nameListBox.SelectedIndex);
            }
        }
    }
}
