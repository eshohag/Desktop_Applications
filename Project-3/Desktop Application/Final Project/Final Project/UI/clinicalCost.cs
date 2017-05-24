using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class clinicalCost : Form
    {
        public clinicalCost()
        {
            InitializeComponent();
        }

        PatientManager aPatientManager = new PatientManager();
        ClinicalManager aClinicalManager = new ClinicalManager();
        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }

        private void btn_searchPatientId_Click(object sender, EventArgs e)
        {
            //Search Patient Id for clinical Cost Add
            if (String.IsNullOrEmpty(txt_patientIDu.Text))
            {
                MessageBox.Show("Patient ID Missing!", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ID = txt_patientIDu.Text;
                Clinical aClinical = aClinicalManager.FindByID(ID);
                if (aClinical != null)
                {
                    textBox3_Cost.Text = aClinical.Cost.ToString();
                    textBox1_Description.Text = aClinical.Description;
                }
                else
                {
                    MessageBox.Show("Invalid Patient ID", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //Add Clinical cost
            if ((String.IsNullOrEmpty(txt_patientId1.Text)) || (string.IsNullOrEmpty(txt_clinicalCost.Text)) ||
                (string.IsNullOrEmpty(txt_description.Text)))
            {
                MessageBox.Show("Please Insert all data", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clinical aClinical = new Clinical();
                aClinical.PatientId = txt_patientId1.Text;
                aClinical.Cost = Convert.ToDecimal(txt_clinicalCost.Text);
                aClinical.Description = txt_description.Text;
                if (aPatientManager.searchPatientID(aClinical.PatientId) != null)
                {
                    DialogResult dialogResultYesNo = MessageBox.Show("Do you want to Add database?", "Clinical Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResultYesNo == DialogResult.Yes)
                    {
                        string message = aClinicalManager.Add(aClinical);
                        MessageBox.Show(message, "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBox();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Patient ID", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private void ClearTextBox()
        {

            txt_clinicalCost.Text = String.Empty;
            txt_description.Text = String.Empty;
            txt_patientId1.Text = String.Empty;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //Update Clinicale Cost
            Clinical aClinical = new Clinical();
            aClinical.PatientId = txt_patientIDu.Text;
            aClinical.Cost = Convert.ToDecimal(textBox3_Cost.Text);
            aClinical.Description = textBox1_Description.Text;


            DialogResult dialogResultYesNo = MessageBox.Show("Do you want to Add database?", "Clinical Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResultYesNo == DialogResult.Yes)
            {
                string message = aClinicalManager.Update(aClinical);
                MessageBox.Show(message, "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxUpdate();
            }



        }

        private void ClearTextBoxUpdate()
        {
            textBox1_Description.Text = String.Empty;
            textBox3_Cost.Text = String.Empty;
        }
    }
}
