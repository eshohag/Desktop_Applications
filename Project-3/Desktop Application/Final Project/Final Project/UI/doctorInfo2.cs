using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class doctorInfo2 : Form
    {
        public doctorInfo2()
        {
            InitializeComponent();
        }
        DoctorsManager aDoctorsManager = new DoctorsManager();

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            user us = new user();
            us.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            txt_doctorIDUser.Text = String.Empty;
            txt_address.Text = String.Empty;
            txt_DateOfJoining.Text = String.Empty;
            txt_SexUser.Text = String.Empty;
            txt_age.Text = String.Empty;
            txt_department.Text = String.Empty;
            txt_doctorName.Text = String.Empty;
            txt_educationLevel.Text = String.Empty;
            txt_mobileNumber.Text = String.Empty;
            txt_salary.Text = String.Empty;
            txt_speciality.Text = String.Empty;
        }

        private void btn_search1_Click(object sender, EventArgs e)
        {
            //Database Search for Doctors
            if (String.IsNullOrEmpty(txt_doctorIDUser.Text))
            {
                MessageBox.Show("Missing ID,Please Insert ID", " Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ID = Convert.ToInt32(txt_doctorIDUser.Text);

                Doctors aDoctors = aDoctorsManager.SearchByID(ID);
                if (aDoctors != null)
                {
                    txt_doctorName.Text = aDoctors.Name;
                    txt_address.Text = aDoctors.Address;
                    txt_age.Text = aDoctors.Age;
                    txt_mobileNumber.Text = aDoctors.MobileNo;
                    txt_educationLevel.Text = aDoctors.Education;
                    txt_speciality.Text = aDoctors.Speciality;
                    txt_department.Text = aDoctors.Department;
                    txt_salary.Text = aDoctors.Salary.ToString();
                    txt_DateOfJoining.Text = aDoctors.DateOfJoining.ToString();
                    txt_SexUser.Text = aDoctors.Sex;
                }
                else
                {
                    MessageBox.Show("Invalid ID", " Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void doctorInfo2_Load(object sender, EventArgs e)
        {
            //Page Load er shomoy ja hoy shai code gula akhane hobe 
        }
    }
}
