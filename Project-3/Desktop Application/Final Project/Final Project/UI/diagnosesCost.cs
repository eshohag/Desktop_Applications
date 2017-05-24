using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class diagnosesCost : Form
    {
        public diagnosesCost()
        {
            InitializeComponent();
        }
        DiagnosesManager aDiagnosesManager = new DiagnosesManager();
        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //Search Patient Id
            if (String.IsNullOrEmpty(txt_patientId1.Text))
            {
                MessageBox.Show("Please Insert all data", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ID = txt_patientId1.Text;

                Diagnoses aDiagnoses = aDiagnosesManager.Search(ID);
                if (aDiagnoses != null)
                {
                    ClearTextBox();
                    txt_daignosesCost.Text = aDiagnoses.Cost.ToString();
                    txt_description.Text = aDiagnoses.Description;
                }
                else
                {
                    MessageBox.Show("Invalid Patient ID", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void ClearTextBox()
        {
            txt_daignosesCost.Text = String.Empty;
            txt_description.Text = String.Empty;
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            //Add patient Dignosis Cost
            if ((String.IsNullOrEmpty(txt_PatientID_diag.Text)) || (string.IsNullOrEmpty(txt_Cost_Diagnoses.Text)) ||
                (string.IsNullOrEmpty(txt_Description_Diag.Text)))
            {
                MessageBox.Show("Please Insert all data", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Diagnoses aDiagnoses = new Diagnoses();
                aDiagnoses.PatientId = txt_PatientID_diag.Text;
                aDiagnoses.Cost = Convert.ToDecimal(txt_Cost_Diagnoses.Text);
                aDiagnoses.Description = txt_Description_Diag.Text;
                DialogResult dialogResultYesNo = MessageBox.Show("Do you want to Add database?", "Clinical Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResultYesNo == DialogResult.Yes)
                {
                    string message = aDiagnosesManager.Add(aDiagnoses);
                    MessageBox.Show(message, "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Cost_Diagnoses.Text = String.Empty;
                    txt_Description_Diag.Text = String.Empty;

                }
            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //Update patient Dignosis Cost
            //Add patient Dignosis Cost
            if ((String.IsNullOrEmpty(txt_patientId1.Text)) || (string.IsNullOrEmpty(txt_description.Text)) ||
                (string.IsNullOrEmpty(txt_daignosesCost.Text)))
            {
                MessageBox.Show("Please Insert all data", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Diagnoses aDiagnoses = new Diagnoses();
                aDiagnoses.Cost = Convert.ToDecimal(txt_daignosesCost.Text);
                aDiagnoses.Description = txt_description.Text;
                aDiagnoses.PatientId = txt_patientId1.Text;
                DialogResult dialogResultYesNo = MessageBox.Show("Do you want to Add database?", "Diagnoses Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResultYesNo == DialogResult.Yes)
                {
                    string message = aDiagnosesManager.Update(aDiagnoses);
                    MessageBox.Show(message, "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }
    }
}
