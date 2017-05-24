using System;
using System.Windows.Forms;

namespace DPersonalInfor
{
    public partial class PersonalInfoUI : Form
    {
        public PersonalInfoUI()
        {
            InitializeComponent();
        }

        private void PersonalInfoUI_Load(object sender, EventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string dept = deptComboBox.Text;
            string district = districtComboBox.Text;
            string gender;
            if (maleRadioButton.Checked)
            {
                gender = "Male";
            }
            else if (femaleRadioButton.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Please Check yout Radio Button";
            }
            string like;
            if (purfumeCheckBox.Checked && drinkCheckBox.Checked)
            {
                like = "Purfume & Drink";

            }
            else if (drinkCheckBox.Checked)
            {
                like = "Drink";
            }

            else if (purfumeCheckBox.Checked)
            {
                like = "Purfume";
            }
            else
            {
                like = "Please Chose your Like";
            }

            MessageBox.Show(name + "\n" + dept + "\n" + district + "\n" + gender + "\n" + like, "Details Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
