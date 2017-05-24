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
    public partial class accounts : Form
    {
        public accounts()
        {
            InitializeComponent();
        }

        private void btnback3_Click(object sender, EventArgs e)
        {
            this.Hide();
            facultyProfile fp = new facultyProfile();
            fp.Show();
        }

        AccountManager accountManager = new AccountManager();

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
               (string.IsNullOrEmpty(txtmasterson.Text)) || (String.IsNullOrEmpty(dtp_dateOfJoining.Text)) ||
               (string.IsNullOrEmpty(txtcurrrentsalary.Text)))
            {
                MessageBox.Show("Please Insert all data", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Account account = new Account();


                account.Name = txtname.Text;
                account.FatherName = txtfathername.Text;
                account.MotherName = txtmothername.Text;
                account.Vilage = txtvillage.Text;
                account.Post = txtpost.Text;
                account.Thana = txtthana.Text;
                account.Disrict = txtdistric.Text;
                account.Country = txtcountry.Text;
                account.Nationality = txtnationality.Text;
                account.MobileNo = txtmobilenumber.Text;
                account.Email = txtemail.Text;

                account.SSCPoint = txtsscpoint.Text;
                account.HSCPoint = txthscpoint.Text;
                account.HonrsPoint = txthonspoint.Text;
                account.MastersPoint = txtmasterspoint.Text;


                account.SSCSession = txtsscsession.Text;
                account.HSCSession = txthscsession.Text;
                account.HonrsSession = txthonssession.Text;
                account.MastersSession = txtmasterssession.Text;

                account.SSCOn = txtsscon.Text;
                account.HSCOn = txthscon.Text;
                account.HonrsOn = txthonrson.Text;
                account.MastersOn = txtmasterson.Text;

                account.DateOfJoining = Convert.ToDateTime(dtp_dateOfJoining.Text);
                account.CurrentSalary = Convert.ToInt32(txtcurrrentsalary.Text);


                string message = accountManager.Add(account);

                CLearTextBox();

            }
        }


        public void CLearTextBox()
        {
            //Accont Status
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
            dtp_dateOfJoining.ResetText();
            txtcurrrentsalary.Text = String.Empty;

        }
    }
}
