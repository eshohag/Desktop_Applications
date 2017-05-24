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
    public partial class stuff : Form
    {
        public stuff()
        {
            InitializeComponent();
        }

        
        private void btnback3_Click(object sender, EventArgs e)
        {
            this.Hide();
            facultyProfile fp = new facultyProfile();
            fp.Show();
        }

        StuffManager stuffManager = new StuffManager();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(txtname.Text)) || (string.IsNullOrEmpty(txtfathername.Text)) ||
               (string.IsNullOrEmpty(txtmothername.Text)) || (String.IsNullOrEmpty(txtvillage.Text)) ||
               (string.IsNullOrEmpty(txtpost.Text)) ||
               (string.IsNullOrEmpty(txtthana.Text)) || (String.IsNullOrEmpty(txtdistric.Text)) ||
               (string.IsNullOrEmpty(txtcountry.Text)) ||
               (string.IsNullOrEmpty(txtnationality.Text)) || (string.IsNullOrEmpty(txtmobilenumber.Text)) ||
               (string.IsNullOrEmpty(txtemail.Text)) || (string.IsNullOrEmpty(txtsscpoint.Text)) ||
               (string.IsNullOrEmpty(txthscpoint.Text)) || (string.IsNullOrEmpty(txtjscpoint.Text)) ||
               (string.IsNullOrEmpty(txtsscsession.Text)) || (string.IsNullOrEmpty(txthscsession.Text)) || 
               (string.IsNullOrEmpty(txtjscsession.Text)) || (string.IsNullOrEmpty(txtsscon.Text)) ||
               (string.IsNullOrEmpty(txthscon.Text))  || (String.IsNullOrEmpty(dtp_dateOfJoining.Text)) ||
               (string.IsNullOrEmpty(txtcurrrentsalary.Text)))
            {
                MessageBox.Show("Please Insert all data", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Stuff stuff = new Stuff();

                stuff.Name = txtname.Text;
                stuff.FatherName = txtfathername.Text;
                stuff.MotherName = txtmothername.Text;
                stuff.Vilage = txtvillage.Text;
                stuff.Post = txtpost.Text;
                stuff.Thana = txtthana.Text;
                stuff.Disrict = txtdistric.Text;
                stuff.Country = txtcountry.Text;
                stuff.Nationality = txtnationality.Text;
                stuff.MobileNo = txtmobilenumber.Text;
                stuff.Email = txtemail.Text;

                stuff.SSCPoint = txtsscpoint.Text;
                stuff.HSCPoint = txthscpoint.Text;
                stuff.JSCPoint = txtjscpoint.Text;

                stuff.SSCSession = txtsscsession.Text;
                stuff.HSCSession = txthscsession.Text;
                stuff.JSCSession = txtjscsession.Text;


                stuff.SSCOn = txtsscon.Text;
                stuff.HSCOn = txthscon.Text;

                stuff.DateOfJoining = Convert.ToDateTime(dtp_dateOfJoining.Text);
                stuff.CurrentSalary = Convert.ToInt32(txtcurrrentsalary.Text);


                string message = stuffManager.Add(stuff);

                CLearTextBox();

            }

        }

        public void CLearTextBox()
        {
            //Stuff Status
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
            txtjscpoint.Text = String.Empty;
           

            txtsscsession.Text = String.Empty;
            txthscsession.Text = String.Empty;
            txtjscsession.Text = String.Empty;
           

            txtsscon.Text = String.Empty;
            txthscon.Text = String.Empty;
           
            //Official Status
          
            dtp_dateOfJoining.ResetText();
            txtcurrrentsalary.Text = String.Empty;

        }

    }
}
