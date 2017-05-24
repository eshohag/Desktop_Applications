using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class doctorInfo : Form
    {
        public doctorInfo()
        {
            InitializeComponent();
        }

        DoctorsManager aDoctorsManager = new DoctorsManager();

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }

        private void doctorInfo_Load(object sender, EventArgs e)
        {
            cmb_sex.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            cmb_Specialties.SelectedIndex = 0;
            comboBox_specilitiesSearch.SelectedIndex = 0;
            sexCombobox.SelectedIndex = 0;
        }


        private void btn_add_Click(object sender, EventArgs e)
        {

            //Add Doctor Information
            if ((String.IsNullOrEmpty(txt_doctorName.Text)) || (string.IsNullOrEmpty(txt_address.Text)) ||
                (string.IsNullOrEmpty(txt_age.Text)) || (String.IsNullOrEmpty(cmb_sex.Text)) || (string.IsNullOrEmpty(txt_mobileNumber.Text)) ||
                (string.IsNullOrEmpty(txt_educationLevel.Text)) || (String.IsNullOrEmpty(cmb_Specialties.Text)) || (string.IsNullOrEmpty(comboBox1.Text)) ||
                (string.IsNullOrEmpty(txt_salary.Text)) || (String.IsNullOrEmpty(dtp_dateOfJoining.Text)))
            {
                MessageBox.Show("Please Insert all data", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Doctors aDoctors = new Doctors();
                aDoctors.Name = txt_doctorName.Text;
                aDoctors.Address = txt_address.Text;
                aDoctors.Age = txt_age.Text;
                aDoctors.Sex = cmb_sex.Text;
                aDoctors.MobileNo = txt_mobileNumber.Text;
                aDoctors.Education = txt_educationLevel.Text;
                aDoctors.Speciality = cmb_Specialties.Text;
                aDoctors.Department = comboBox1.Text;
                aDoctors.Salary = Convert.ToDecimal(txt_salary.Text);
                aDoctors.DateOfJoining = Convert.ToDateTime(dtp_dateOfJoining.Text);
                //Insert data table

                string message = aDoctorsManager.Add(aDoctors);
                Doctors ID = aDoctorsManager.FindID(aDoctors);
                if (ID != null)
                {
                    ClearTextBox(); //Clear text box
                    IDTextBox(ID);
                    MessageBox.Show(message + "Your Identifier ID  " + ID.ID, "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(message + "Some error", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


        }

        private void ClearTextBox()
        {
            txt_doctorName.Text = String.Empty;
            txt_address.Text = String.Empty;
            txt_age.Text = String.Empty;
            comboBox1.SelectedIndex = 0;
            txt_educationLevel.Text = String.Empty;
            txt_mobileNumber.Text = String.Empty;
            txt_salary.Text = String.Empty;
            cmb_Specialties.SelectedIndex = 0;
            cmb_sex.SelectedIndex = 0;
            dtp_dateOfJoining.ResetText();

        }

        private void IDTextBox(Doctors ID)
        {
            txt_doctorIDAdmin.BackColor = Color.Purple;
            txt_doctorIDAdmin.ForeColor = Color.White;
            txt_doctorIDAdmin.Text = ID.ID.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            //Update Doctor Information
            Doctors aDoctors = new Doctors();
            aDoctors.ID = Convert.ToInt32(txt_doctorIDAdmin.Text);
            aDoctors.Name = NameTextBox.Text;
            aDoctors.Address = Address.Text;
            aDoctors.Age = Age.Text;
            aDoctors.MobileNo = Mobile.Text;
            aDoctors.Department = comboBox2.Text;
            aDoctors.DateOfJoining = Convert.ToDateTime(dateTimePicker1.Text);
            aDoctors.Education = Education.Text;
            aDoctors.Speciality = comboBox_specilitiesSearch.Text;
            aDoctors.Salary = Convert.ToDecimal(Salary.Text);
            aDoctors.Sex = sexCombobox.Text;


            DialogResult dialogResultYesNo = MessageBox.Show("Do you want to update database?", "Doctor Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResultYesNo == DialogResult.Yes)
            {
                string message = aDoctorsManager.Update(aDoctors);
                MessageBox.Show(message, "Confirmation!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btn_search1_Click(object sender, EventArgs e)
        {
            //Search
            if (String.IsNullOrEmpty(txt_doctorIDAdmin.Text))
            {
                MessageBox.Show("Please Insert all data", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(txt_doctorIDAdmin.Text);
                Doctors aDoctors = aDoctorsManager.SearchByID(id);
                if (aDoctors != null)
                {
                    NameTextBox.Text = aDoctors.Name;
                    Address.Text = aDoctors.Address;
                    Age.Text = aDoctors.Age;
                    Mobile.Text = aDoctors.MobileNo;
                    comboBox2.Text = aDoctors.Department;
                    Education.Text = aDoctors.Education;
                    Salary.Text = aDoctors.Salary.ToString();
                    comboBox_specilitiesSearch.Text = aDoctors.Speciality;
                    sexCombobox.Text = aDoctors.Sex;
                    dateTimePicker1.Text = aDoctors.DateOfJoining.ToString();

                }
                else
                {
                    MessageBox.Show("Con't find Doctor ID", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


        }
    }
}
