using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class treatmentInfo : Form
    {
        public treatmentInfo()
        {
            InitializeComponent();
        }
        PatientManager aPatientManager = new PatientManager();
        TreatmentManager aTreatmentManager = new TreatmentManager();
        private void ClearTextBox()
        {
            txt_nameOfTreatment.Text = String.Empty;
            txt_diseaseName.Text = String.Empty;
            txt_description.Text = String.Empty;
            txt_cost.Text = String.Empty;

        }

        private string ID;
        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_diseaseName.Text) || String.IsNullOrEmpty(txt_nameOfTreatment.Text) ||
                String.IsNullOrEmpty(txt_cost.Text) || String.IsNullOrEmpty(txt_description.Text))
            {
                MessageBox.Show("Please Insert FUlly Data", "Missing ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Add Treatment Information
                if (aPatientManager.searchPatientID(ID) != null)
                {
                    if (aTreatmentManager.SearchPatientID(ID) == null)
                    {
                        var aTreatment = AlldataForATreatment();

                        string message = aTreatmentManager.Add(aTreatment);
                        MessageBox.Show(message, "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Already Assign a Treatment Information!", "Already Assign", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    NotRecognizeID();
                }
            }



        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //Update Information
            var aTreatment = AlldataForATreatment();
            DialogResult dialogResultYesNo = MessageBox.Show("Do you want to Update Information?", "Treatment Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResultYesNo == DialogResult.Yes)
            {
                string message = aTreatmentManager.Update(aTreatment);
                MessageBox.Show(message, "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
            }
        }

        private Treatment AlldataForATreatment()
        {
            Treatment aTreatment = new Treatment();
            aTreatment.Name = txt_nameOfTreatment.Text;
            aTreatment.DiseaseName = txt_diseaseName.Text;
            aTreatment.Description = txt_description.Text;
            aTreatment.Cost = Convert.ToDecimal(txt_cost.Text);
            aTreatment.PatientId = txt_patientId.Text;
            return aTreatment;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_patientId.Text))
            {
                MessageBox.Show("Please Insert FUlly Data", "Missing ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ID = txt_patientId.Text;
                if (aPatientManager.searchPatientID(ID) != null)
                {
                    Treatment aTreatment = aTreatmentManager.SearchPatientID(ID);
                    if (aTreatment != null)
                    {
                        ClearTextBox();
                        txt_nameOfTreatment.Text = aTreatment.Name;
                        txt_diseaseName.Text = aTreatment.DiseaseName;
                        txt_description.Text = aTreatment.Description;
                        txt_cost.Text = aTreatment.Cost.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Can't assign any Treatment Information ! ", " No Information!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        ClearTextBox();
                    }

                }
                else
                {
                    NotRecognizeID();
                    ClearTextBox();
                }
            }

        }

        private static void NotRecognizeID()
        {
            MessageBox.Show("Your Provided ID isn't recognize on Othority! ", "Wrrong Patient ID!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
