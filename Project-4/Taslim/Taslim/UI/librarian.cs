using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taslim.BAL;
using Taslim.DAL.Model;

namespace Taslim
{
    public partial class librarian : Form
    {
        public librarian()
        {
            InitializeComponent();
        }

        
        private void btnback3_Click(object sender, EventArgs e)
        {
            this.Hide();
            facultyProfile fp = new facultyProfile();
            fp.Show();
        }

        LibraryManager aLibraryManager = new LibraryManager();
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
                Librarian librarian = new Librarian();

                librarian.Name = txtname.Text;
                librarian.FatherName = txtfathername.Text;
                librarian.MotherName = txtmothername.Text;
                librarian.Vilage = txtvillage.Text;
                librarian.Post = txtpost.Text;
                librarian.Thana = txtthana.Text;
                librarian.Disrict = txtdistric.Text;
                librarian.Country = txtcountry.Text;
                librarian.Nationality = txtnationality.Text;
                librarian.MobileNo = txtmobilenumber.Text;
                librarian.Email = txtemail.Text;

                librarian.SSCPoint = txtsscpoint.Text;
                librarian.HSCPoint = txthscpoint.Text;
                librarian.HonrsPoint = txthonspoint.Text;
                librarian.MastersPoint = txtmasterspoint.Text;


                librarian.SSCSession = txtsscsession.Text;
                librarian.HSCSession = txthscsession.Text;
                librarian.HonrsSession = txthonssession.Text;
                librarian.MastersSession = txtmasterssession.Text;

                librarian.SSCOn = txtsscon.Text;
                librarian.HSCOn = txthscon.Text;
                librarian.HonrsOn = txthonrson.Text;
                librarian.MastersOn = txtmasterson.Text;

                librarian.Designation = designationComboBox.Text;
                librarian.DateOfJoining = Convert.ToDateTime(dtp_dateOfJoining.Text);
                librarian.CurrentSalary = Convert.ToInt32(txtcurrrentsalary.Text);


                string message = aLibraryManager.Add(librarian);

                CLearTextBox();

            }
        }

        public void CLearTextBox()
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

        private void librarian_Load(object sender, EventArgs e)
        {
            designationComboBox.SelectedIndex = 0;
        }
    }
}
