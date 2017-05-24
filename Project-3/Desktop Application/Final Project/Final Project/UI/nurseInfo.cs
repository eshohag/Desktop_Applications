using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class nurseInfo : Form
    {
        public nurseInfo()
        {
            InitializeComponent();
        }
        NurseManager aNurseManager = new NurseManager();
        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }

        private void nurseInfo_Load(object sender, EventArgs e)
        {
            cmb_sex.SelectedIndex = 0;
            cmb_department.SelectedIndex = 0;
            cmb_Specialties.SelectedIndex = 0;
        }

        private void btn_searchNurse_Click(object sender, EventArgs e)
        {

            int ID = Convert.ToInt32(txt_nurseIDAdmin.Text);
            Nurse aNurse = aNurseManager.SearchByID(ID);
            if (aNurse != null)
            {
                txt_nurseName.Text = aNurse.Name;
                txt_address.Text = aNurse.Address;
                txt_age.Text = aNurse.Age;
                txt_salary.Text = aNurse.Salary.ToString();
                cmb_department.Text = aNurse.Department;
                txt_educationLevel.Text = aNurse.Education;
                txt_mobileNumber.Text = aNurse.MobileNo;
                cmb_Specialties.Text = aNurse.Specialist;
                cmb_sex.Text = aNurse.Sex;
                dtp_dateOfjoining.Text = aNurse.DateOfJoining.ToString();
            }
            else
            {
                MessageBox.Show("Cann't found any Information for Nurse ID", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(txt_nurseName.Text)) || (string.IsNullOrEmpty(txt_address.Text)) ||
                (string.IsNullOrEmpty(txt_age.Text)) || (String.IsNullOrEmpty(cmb_sex.Text)) ||
                (string.IsNullOrEmpty(txt_mobileNumber.Text)) ||
                (string.IsNullOrEmpty(txt_educationLevel.Text)) || (String.IsNullOrEmpty(cmb_Specialties.Text)) ||
                (string.IsNullOrEmpty(cmb_department.Text)) ||
                (string.IsNullOrEmpty(txt_salary.Text)) || (String.IsNullOrEmpty(dtp_dateOfjoining.Text)))
            {
                MessageBox.Show("Please Insert all data", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Nurse aNurse = new Nurse();
                aNurse.Name = txt_nurseName.Text;
                aNurse.Address = txt_address.Text;
                aNurse.Age = txt_age.Text;
                aNurse.Sex = cmb_sex.Text;
                aNurse.MobileNo = txt_mobileNumber.Text;
                aNurse.Department = cmb_department.Text;
                aNurse.Specialist = cmb_Specialties.Text;
                aNurse.Salary = Convert.ToDecimal(txt_salary.Text);
                aNurse.Education = txt_educationLevel.Text;
                aNurse.DateOfJoining = Convert.ToDateTime(dtp_dateOfjoining.Text);

                //Insert Data
                DialogResult dialogResultYesNo = MessageBox.Show("Do you want to Add database?", "Nurse Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResultYesNo == DialogResult.Yes)
                {
                    ClearTextBox();
                    string message = aNurseManager.Add(aNurse);
                    Nurse FindID = aNurseManager.FindID(aNurse);

                    txt_nurseIDAdmin.BackColor = Color.Purple;
                    txt_nurseIDAdmin.ForeColor = Color.White;
                    txt_nurseIDAdmin.Text = FindID.ID.ToString();
                    MessageBox.Show(message, "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
            }

        }

        private void ClearTextBox()
        {
            txt_nurseName.Text = String.Empty;
            txt_age.Text = String.Empty;
            cmb_department.Text = String.Empty;
            txt_educationLevel.Text = String.Empty;
            txt_mobileNumber.Text = String.Empty;
            txt_salary.Text = String.Empty;
            cmb_sex.SelectedIndex = 0;
            cmb_Specialties.SelectedIndex = 0;
            txt_address.Text = String.Empty;

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            Nurse aNurse = new Nurse();
            aNurse.ID = Convert.ToInt32(txt_nurseIDAdmin.Text);
            aNurse.Name = txt_nurseName.Text;
            aNurse.Address = txt_address.Text;
            aNurse.Age = txt_age.Text;
            aNurse.Sex = cmb_sex.Text;
            aNurse.MobileNo = txt_mobileNumber.Text;
            aNurse.Department = cmb_department.Text;
            aNurse.Specialist = cmb_Specialties.Text;
            aNurse.Salary = Convert.ToDecimal(txt_salary.Text);
            aNurse.Education = txt_educationLevel.Text;
            aNurse.DateOfJoining = Convert.ToDateTime(dtp_dateOfjoining.Text);


            DialogResult dialogResultYesNo = MessageBox.Show("Do you want to Add database?", "Nurse Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResultYesNo == DialogResult.Yes)
            {
                string message = aNurseManager.Update(aNurse);
                MessageBox.Show(message, "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
