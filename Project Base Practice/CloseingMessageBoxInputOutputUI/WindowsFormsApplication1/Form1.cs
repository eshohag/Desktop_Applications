using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ClosingMessageBoxInputOutpueUI : Form
    {
        private string name;
        private string name1;
        public ClosingMessageBoxInputOutpueUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            name = nameMe();
            nameTextBox.Clear();
            MessageBox.Show("Hello " + name);
            
        }

        private void dispalyButton_Click(object sender, EventArgs e)
        {
            name1 = nameMe();
            displayTextBox.Text = name;
        }

        private string nameMe()
        {
            return nameTextBox.Text;
        }

       
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close the Application?", "Exit", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }             
        }       
    }
}
