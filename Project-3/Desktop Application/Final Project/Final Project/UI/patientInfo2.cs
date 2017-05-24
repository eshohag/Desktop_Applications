using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class patientInfo2 : Form
    {
        public patientInfo2()
        {
            InitializeComponent();
        }
        PatientManager aPatientManager = new PatientManager();
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            user us = new user();
            us.Show();
        }

        private void patientInfo2_Load_1(object sender, EventArgs e)
        {
            cmb_sex.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;

        }



        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_address.Text = String.Empty;
            txt_admissionDate.Text = String.Empty;
            txt_age.Text = String.Empty;
            txt_bedNo.Text = String.Empty;
            txt_cabinNo.Text = String.Empty;
            txt_mobileNumber.Text = String.Empty;
            txt_patient2.Text = String.Empty;

            txt_patientName.Text = String.Empty;
            txt_type.Text = String.Empty;
            comboBox1.SelectedIndex = 0;
            cmb_sex.SelectedIndex = 0;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_patient2.Text))
            {
                MessageBox.Show("Insert Your patients ID  ", "Missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ID = txt_patient2.Text;
                Patient aPatient = aPatientManager.searchPatientID(ID);
                if (aPatient != null)
                {
                    txt_patientName.Text = aPatient.Name;
                    txt_address.Text = aPatient.AddressP;
                    txt_admissionDate.Text = aPatient.Admission.ToString();
                    txt_age.Text = aPatient.Age.ToString();
                    txt_bedNo.Text = aPatient.BedNo;
                    txt_cabinNo.Text = aPatient.CabinNo;
                    cmb_sex.Text = aPatient.Sex;
                    txt_mobileNumber.Text = aPatient.MobileNo;
                    txt_type.Text = aPatient.Type;
                    comboBox1.Text = aPatient.CabinType;
                }
                else
                {
                    MessageBox.Show("Not Found Your patients ID  ", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

    }
}
