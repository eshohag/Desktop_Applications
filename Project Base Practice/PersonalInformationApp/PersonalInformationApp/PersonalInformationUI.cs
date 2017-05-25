using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class PersonalInformationUI : Form
    {
        private string fName;
        private string lName;
        private string father;
        private string mother;
        private string address;
        public PersonalInformationUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            fName = firstNameTextBox.Text;
            lName = lastNameTextBox.Text;
            father = fathersNameTextBox.Text;
            father = fathersNameTextBox.Text;
            mother = mothersNameTextBox.Text;
            address = addressTextBox.Text;

            MessageBox.Show(" Your Information have been Saved", "Personal Information Saved", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fathersNameTextBox.Clear();
            mothersNameTextBox.Clear();
            addressTextBox.Clear();

        }

        private void showAllInformatinButton_Click(object sender, EventArgs e)
        {
           firstNameTextBox.Text=fName;
            lastNameTextBox.Text=lName;
            fathersNameTextBox.Text = father;
            mothersNameTextBox.Text = mother;
            addressTextBox.Text = address;

        }

        private void PersonalInformationUI_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Your Identity ");
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = fName;
            lastNameTextBox.Text = lName;

            fathersNameTextBox.Clear();
            mothersNameTextBox.Clear();
            addressTextBox.Clear();
        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fathersNameTextBox.Text = father;
            mothersNameTextBox.Text = mother;
            addressTextBox.Clear();
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fathersNameTextBox.Clear();
            mothersNameTextBox.Clear();
            addressTextBox.Text = address;
        }
    }
}
