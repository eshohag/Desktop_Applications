using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class cabinInfo : Form
    {
        public cabinInfo()
        {
            InitializeComponent();
        }
        CabinInfoManager aCabinInfoManager = new CabinInfoManager();
        PatientManager aPatientManager = new PatientManager();



        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }


        private CabinInfo aCabinInfo;
        private Patient aPatient;
        private string searchID;
        private void btn_search_Click(object sender, EventArgs e)
        {
            //Search Patient Information
            if (String.IsNullOrEmpty(txt_patientId1.Text))
            {
                MessageBox.Show("Missing data !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                searchID = txt_patientId1.Text;

                aPatient = aPatientManager.searchPatientID(searchID);
                aCabinInfo = aCabinInfoManager.searchPatientID(searchID);
                if (aPatient != null)
                {
                    clearTextBox();
                    txt_patientCabinInfo.Text = aPatient.Name;
                    txt_patientCabinInfo.ReadOnly = true;
                    txt_cabinId.Text = aPatient.CabinNo;
                    txt_cabinId.ReadOnly = true;
                    txt_location.Text = aPatient.AddressP;
                    txt_location.ReadOnly = true;
                    txt_bedNumber.Text = aPatient.BedNo;
                    txt_bedNumber.ReadOnly = true;
                    cmb_cabinType.Text = aPatient.CabinType;
                    cmb_cabinType.Enabled = false;
                    dtp_joining.Text = aPatient.Admission.ToString();
                    dtp_joining.Enabled = false;
                    if (aCabinInfo != null)
                    {

                        dtp_release.Text = aCabinInfo.ReleaseDate.ToString();
                        txt_amoutOfStay.Text = aCabinInfo.AmountOfStay.ToString();
                        txt_amoutOfStay.ReadOnly = true;
                        txt_perDayCost.Text = aCabinInfo.PerDayCost.ToString();
                        txt_totalCost.Text = aCabinInfo.TotalCost.ToString();
                        txt_totalCost.ReadOnly = true;
                    }

                }
                else
                {
                    MessageBox.Show("Not Found", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //Amount Calculate
            if (String.IsNullOrEmpty(dtp_release.Text) || (String.IsNullOrEmpty(txt_perDayCost.Text)))
            {
                MessageBox.Show("Missing data !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double difference = (Convert.ToDateTime(dtp_release.Text)).ToOADate() - aPatient.Admission.ToOADate();
                if (difference == 0)
                {
                    txt_amoutOfStay.Text = 1.ToString();
                    double totalCost = 1 * (Convert.ToDouble(txt_perDayCost.Text));
                    txt_totalCost.Text = totalCost.ToString();
                }
                else if (difference >= 0)
                {
                    txt_amoutOfStay.Text = difference.ToString();
                    double totalCost = difference * (Convert.ToDouble(txt_perDayCost.Text));
                    txt_totalCost.Text = totalCost.ToString();
                }
                else
                {
                    MessageBox.Show("Is Not Possible Date formate !", "Unordered date!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }



        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //Add Information
            aCabinInfo = new CabinInfo();
            aCabinInfo.PatientId = searchID;
            aCabinInfo.ReleaseDate = Convert.ToDateTime(dtp_release.Text);
            aCabinInfo.AmountOfStay = Convert.ToInt32(txt_amoutOfStay.Text);
            aCabinInfo.PerDayCost = Convert.ToInt32(txt_perDayCost.Text);
            aCabinInfo.TotalCost = Convert.ToInt32(txt_totalCost.Text);
            if (aCabinInfoManager.IsExisting(searchID) == null)
            {
                DialogResult dialogResultYesNo = MessageBox.Show("Do you want to Add Information?", "Cabin Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResultYesNo == DialogResult.Yes)
                {
                    string message = aCabinInfoManager.AddedCabinInfo(aCabinInfo);   //Update
                    MessageBox.Show(message, "Update Cabin Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTextBox();

                }

            }
            else
            {
                MessageBox.Show("Already Added this patientID", "Update Cabin Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTextBox();
            }

        }

        public void clearTextBox()    //Methods Create for clear Text Box
        {
            dtp_release.Text = String.Empty;
            txt_perDayCost.Text = String.Empty;
            txt_amoutOfStay.Text = String.Empty;
            txt_totalCost.Text = String.Empty;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            //Update Database

            aCabinInfo.PatientId = txt_patientId1.Text;
            aCabinInfo.ReleaseDate = Convert.ToDateTime(dtp_release.Text);
            aCabinInfo.PerDayCost = Convert.ToDouble(txt_perDayCost.Text);
            aCabinInfo.AmountOfStay = Convert.ToInt32(txt_amoutOfStay.Text);
            aCabinInfo.TotalCost = Convert.ToDouble(txt_totalCost.Text);
            DialogResult dialogResultYesNo = MessageBox.Show("Do you want to update database?", "Sure!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResultYesNo == DialogResult.Yes)
            {
                string message = aCabinInfoManager.UpdateCabinInfo(aCabinInfo);

                MessageBox.Show(message, "Update Cabin Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cabinInfo_Load(object sender, EventArgs e)
        {
            txt_amoutOfStay.ReadOnly = true;
            txt_totalCost.ReadOnly = true;

        }


    }
}
