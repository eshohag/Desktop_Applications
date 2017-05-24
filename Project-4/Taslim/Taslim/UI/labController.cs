using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Taslim.BAL;
using Taslim.DAL.Model;

namespace Taslim
{
    public partial class labController : Form
    {
        public labController()
        {
            InitializeComponent();
        }

        
        private void btnback3_Click(object sender, EventArgs e)
        {
            this.Hide();
            facultyProfile fp = new facultyProfile();
            fp.Show();
        }

        LabControllerManager aLabControllerManager = new LabControllerManager();

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if ((String.IsNullOrEmpty(txtname.Text)) || (string.IsNullOrEmpty(txtfathername.Text)) ||
                (string.IsNullOrEmpty(txtmothername.Text)) || (String.IsNullOrEmpty(txtvillage.Text)) ||
                (string.IsNullOrEmpty(txtpost.Text)) ||
                (string.IsNullOrEmpty(txtthana.Text)) || (String.IsNullOrEmpty(txtdistric.Text)) ||
                (string.IsNullOrEmpty(txtcountry.Text)) ||
                (string.IsNullOrEmpty(txtnationality.Text)) || (string.IsNullOrEmpty(txtmobilenumber.Text)) ||
                (string.IsNullOrEmpty(txtemail.Text)) || (string.IsNullOrEmpty(txtsscpoint.Text)) ||
                (string.IsNullOrEmpty(txthscpoint.Text)) || (string.IsNullOrEmpty(txthonspoint.Text)) ||
                (string.IsNullOrEmpty(txtmasterspoint.Text)) || (string.IsNullOrEmpty(txtsscsession.Text)) ||
                (string.IsNullOrEmpty(txthscsession.Text)) || (string.IsNullOrEmpty(txthonssession.Text)) ||
                (string.IsNullOrEmpty(txtmasterssession.Text)) || (string.IsNullOrEmpty(txtsscon.Text)) ||
                (string.IsNullOrEmpty(txthscon.Text)) || (string.IsNullOrEmpty(txthonrson.Text)) ||
                (string.IsNullOrEmpty(txtmasterson.Text)) ||
                (string.IsNullOrEmpty(designationComboBox.Text)) || (String.IsNullOrEmpty(dtp_dateOfJoining.Text)) ||
                (string.IsNullOrEmpty(txtcurrrentsalary.Text)))
            {
                MessageBox.Show("Please Insert all data", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DAL.Model.labController aLabController = new DAL.Model.labController();


                aLabController.Name = txtname.Text;
                aLabController.FatherName = txtfathername.Text;
                aLabController.MotherName = txtmothername.Text;
                aLabController.Vilage = txtvillage.Text;
                aLabController.Post = txtpost.Text;
                aLabController.Thana = txtthana.Text;
                aLabController.Disrict = txtdistric.Text;
                aLabController.Country = txtcountry.Text;
                aLabController.Nationality = txtnationality.Text;
                aLabController.MobileNo = txtmobilenumber.Text;
                aLabController.Email = txtemail.Text;

                aLabController.SSCPoint = txtsscpoint.Text;
                aLabController.HSCPoint = txthscpoint.Text;
                aLabController.HonrsPoint = txthonspoint.Text;
                aLabController.MastersPoint = txtmasterspoint.Text;


                aLabController.SSCSession = txtsscsession.Text;
                aLabController.HSCSession = txthscsession.Text;
                aLabController.HonrsSession = txthonssession.Text;
                aLabController.MastersSession = txtmasterssession.Text;

                aLabController.SSCOn = txtsscon.Text;
                aLabController.HSCOn = txthscon.Text;
                aLabController.HonrsOn = txthonrson.Text;
                aLabController.MastersOn = txtmasterson.Text;

                aLabController.Designation = designationComboBox.Text;
                aLabController.DateOfJoining = Convert.ToDateTime(dtp_dateOfJoining.Text);
                aLabController.CurrentSalary = Convert.ToInt32(txtcurrrentsalary.Text);


                string message = aLabControllerManager.Add(aLabController);

                CLearTextBox();

            }
        }

        public  void CLearTextBox()
        {
            //Lab Status
            txtname.Text = String.Empty;
            txtfathername.Text = String.Empty;
            txtmothername.Text = String.Empty;
            txtvillage.Text = String.Empty;
            txtpost.Text = String.Empty;
            txtthana.Text = String.Empty;
            txtdistric.Text = String.Empty;
            txtcountry.Text = String.Empty;
            txtnationality.Text = String.Empty;
            txtmobilenumber.Text = String.Empty;
            txtemail.Text = String.Empty;

            //Education Qualification
            txtsscpoint.Text = String.Empty;
            txthscpoint.Text = String.Empty;
            txthonspoint.Text = String.Empty;
            txtmasterspoint.Text = String.Empty;

            txtsscsession.Text = String.Empty;
            txthscsession.Text = String.Empty;
            txthonssession.Text = String.Empty;
            txtmasterssession.Text = String.Empty;

            txtsscon.Text = String.Empty;
            txthscon.Text = String.Empty;
            txthonrson.Text = String.Empty;
            txtmasterson.Text = String.Empty;

            //Official Status
            designationComboBox.SelectedIndex = 0;
            dtp_dateOfJoining.ResetText();
            txtcurrrentsalary.Text = String.Empty;

        }

        private void labController_Load(object sender, EventArgs e)
        {
            designationComboBox.SelectedIndex = 0;
        }
    }
}
