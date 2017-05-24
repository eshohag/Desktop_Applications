using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class patientInfo : Form
    {
        public patientInfo()
        {
            InitializeComponent();
        }
        PatientManager aPatientManager = new PatientManager();
        private void btn_back_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }

        private string searchId;
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_patientIdSearch.Text))
            {
                MessageBox.Show("Missing  ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Search & Update Patient Information

                searchId = txt_patientIdSearch.Text;
                Patient aPatient = aPatientManager.searchPatientID(searchId);
                txt_PatientNameUpdate.Text = aPatient.Name;
                txt_patientAddressUpdate.Text = aPatient.AddressP;
                txt_PAgeUpdate.Text = aPatient.Age.ToString();
                txt_MobileNumberUpdate.Text = aPatient.MobileNo;
                txt_admissionDateUpdate.Text = aPatient.Admission.ToString();
                txt_BedNoUpdate.Text = aPatient.BedNo;
                txt_CabinNoUpdate.Text = aPatient.CabinNo;
                cmb_CabinTypeUpdate.Text = aPatient.CabinType;
                cmb_SexUpdate.Text = aPatient.Sex;
                cmb_typeUpdate.Text = aPatient.Type;
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //Update Patient Information database here....
            //Permission from user yes or No by Messagebox.show();
            DialogResult dialogResultYesNo = MessageBox.Show("Do you want to update database?", "Patients Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResultYesNo == DialogResult.Yes)
            {
                string name = txt_PatientNameUpdate.Text;
                string address = txt_patientAddressUpdate.Text;
                int age = Convert.ToInt32(txt_PAgeUpdate.Text);
                string MobileNo = txt_MobileNumberUpdate.Text;
                DateTime admission = Convert.ToDateTime(txt_admissionDateUpdate.Text);
                string bedNo = txt_BedNoUpdate.Text;
                string cabinNo = txt_CabinNoUpdate.Text;
                string cabinType = cmb_CabinTypeUpdate.Text;
                string sex = cmb_SexUpdate.Text;
                string type = cmb_typeUpdate.Text;

                Patient aPatientInfoUpdate = new Patient();
                aPatientInfoUpdate.PatientId = searchId;
                aPatientInfoUpdate.Sex = sex;
                aPatientInfoUpdate.AddressP = address;
                aPatientInfoUpdate.Age = age;
                aPatientInfoUpdate.BedNo = bedNo;
                aPatientInfoUpdate.CabinNo = cabinNo;
                aPatientInfoUpdate.CabinType = cabinType;
                aPatientInfoUpdate.Type = type;
                aPatientInfoUpdate.MobileNo = MobileNo;
                aPatientInfoUpdate.Admission = admission;
                aPatientInfoUpdate.Name = name;

                //Update Database
                string updateInfo = aPatientManager.Update(aPatientInfoUpdate);
                MessageBox.Show(updateInfo, "Update Patient Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Clear TextBox
                txt_BedNoUpdate.Text = String.Empty;
                txt_CabinNoUpdate.Text = String.Empty;
                txt_MobileNumberUpdate.Text = String.Empty;
                txt_PAgeUpdate.Text = String.Empty;
                txt_PatientNameUpdate.Text = String.Empty;
                txt_admissionDateUpdate.Text = String.Empty;
                txt_patientAddressUpdate.Text = String.Empty;
                cmb_CabinTypeUpdate.SelectedIndex = 0;
                cmb_SexUpdate.SelectedIndex = 0;
                cmb_CabinTypeUpdate.SelectedIndex = 0;
                cmb_typeUpdate.SelectedIndex = 0;
            }
            //else
            //{
            //    MessageBox.Show("Check");
            //}
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(txt_patientName.Text)) || (string.IsNullOrEmpty(txt_address.Text)) ||
                (string.IsNullOrEmpty(txt_age.Text)) || (String.IsNullOrEmpty(cmb_sex.Text)) ||
                (string.IsNullOrEmpty(txt_mobileNumber.Text)) ||
                (string.IsNullOrEmpty(txt_bedNo.Text)) || (String.IsNullOrEmpty(txt_cabinNo.Text)) ||
                (string.IsNullOrEmpty(admissionDateForPatient.Text)) ||
                (string.IsNullOrEmpty(cmb_type.Text)) || (String.IsNullOrEmpty(cmb_cabinType.Text)))
            {
                MessageBox.Show("Please Insert all data", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Add patient Information 
                string name = txt_patientName.Text;
                string address = txt_address.Text;
                int age = Convert.ToInt32(txt_age.Text);
                string sex = cmb_sex.Text;
                string mobileNo = txt_mobileNumber.Text;
                string bedNo = txt_bedNo.Text;
                string cabinNo = txt_cabinNo.Text;
                DateTime admission = Convert.ToDateTime(admissionDateForPatient.Text);
                string type = cmb_type.Text;
                string cabinType = cmb_cabinType.Text;


                //Patient ID Auto Generated process
                //string nameLength = name.Length.ToString();
                string patientID;
                if (sex == "Male")
                {
                    patientID = Convert.ToString("M" + admission.Year + admission.Month + cabinNo + bedNo);
                }
                else if (sex == "Female")
                {
                    patientID = Convert.ToString("F" + admission.Year + admission.Month + cabinNo + bedNo);

                }
                else
                {
                    patientID = Convert.ToString("O" + admission.Year + admission.Month + cabinNo + bedNo);
                }

                txt_patientId.Text = String.Empty;
                txt_patientId.BackColor = Color.DarkOrange;
                txt_patientId.ForeColor = Color.White;
                txt_patientId.Text = patientID;
                txt_patientId.ReadOnly = true;
                //txt_patientId.Enabled = false;


                Patient aPatient = new Patient();   //Assign to all values on Patient Class
                aPatient.PatientId = patientID;
                aPatient.Name = name;
                aPatient.AddressP = address;
                aPatient.Age = age;
                aPatient.Admission = admission;
                aPatient.Sex = sex;
                aPatient.MobileNo = mobileNo;
                aPatient.Type = type;
                aPatient.BedNo = bedNo;
                aPatient.CabinNo = cabinNo;
                aPatient.CabinType = cabinType;

                //Save database Patient Information
                string add = aPatientManager.Add(aPatient);
                MessageBox.Show(add, "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show(add + "\n Your Patient ID is " + patientID, "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //clear all text box 
                txt_patientName.Text = String.Empty;
                txt_age.Text = String.Empty;
                txt_address.Text = String.Empty;
                txt_bedNo.Text = String.Empty;
                txt_cabinNo.Text = String.Empty;
                cmb_sex.SelectedIndex = 0;
                cmb_cabinType.SelectedIndex = 0;
                cmb_type.SelectedIndex = 0;
                txt_mobileNumber.Text = String.Empty;
            }

        }
        private void patientInfo_Load(object sender, EventArgs e)
        {
            txt_patientId.ReadOnly = true;

            cmb_sex.SelectedIndex = 0;
            cmb_type.SelectedIndex = 0;
            cmb_cabinType.SelectedIndex = 0;
            cmb_CabinTypeUpdate.SelectedIndex = 0;
            cmb_SexUpdate.SelectedIndex = 0;
            cmb_typeUpdate.SelectedIndex = 0;
        }
    }
}
