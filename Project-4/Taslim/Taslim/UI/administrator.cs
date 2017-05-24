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
    public partial class administrator : Form
    {
        public administrator()
        {
            InitializeComponent();
        }
                
        //private void button5_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    facultyProfile fa = new facultyProfile();
        //    fa.Show();
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void btnback_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    facultyProfile fp = new facultyProfile();
        //    fp.Show();
        //}

        //private void btnback2_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    facultyProfile fp = new facultyProfile();
        //    fp.Show();
        //}

        //private void btnback3_Click(object sender, EventArgs e)
        //{
           
        //}


        AdministratorManager administratorManager = new AdministratorManager();

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
                Administrator administrator = new Administrator();
                administrator.Name = txtname.Text;
                administrator.FatherName = txtfathername.Text;
                administrator.MotherName = txtmothername.Text;
                administrator.Vilage = txtvillage.Text;
                administrator.Post = txtpost.Text;
                administrator.Thana = txtthana.Text;
                administrator.Disrict = txtdistric.Text;
                administrator.Country = txtcountry.Text;
                administrator.Nationality = txtnationality.Text;
                administrator.MobileNo = txtmobilenumber.Text;
                administrator.Email = txtemail.Text;

                administrator.SSCPoint = txtsscpoint.Text;
                administrator.HSCPoint = txthscpoint.Text;
                administrator.HonrsPoint = txthonspoint.Text;
                administrator.MastersPoint = txtmasterspoint.Text;


                administrator.SSCSession = txtsscsession.Text;
                administrator.HSCSession = txthscsession.Text;
                administrator.HonrsSession = txthonssession.Text;
                administrator.MastersSession = txtmasterssession.Text;

                administrator.SSCOn = txtsscon.Text;
                administrator.HSCOn = txthscon.Text;
                administrator.HonrsOn = txthonrson.Text;
                administrator.MastersOn = txtmasterson.Text;

                administrator.DateOfJoining = Convert.ToDateTime(dtp_dateOfJoining.Text);
                administrator.CurrentSalary = Convert.ToInt32(txtcurrrentsalary.Text);


                string message = administratorManager.Add(administrator);

                CLearTextBox();

                }
        }

        public void CLearTextBox()
        {
            //Administrator Status
            txtname.Text = String.Empty;
            txtfathername.Text = String.Empty;
            txtmothername.Text= String.Empty;
            txtvillage.Text=String.Empty;
            txtpost.Text = String.Empty;
            txtthana.Text= String.Empty;
            txtdistric.Text = String.Empty;
            txtcountry.Text=String.Empty;
            txtnationality.Text = String.Empty;
            txtmobilenumber.Text = String.Empty;
            txtemail.Text = String.Empty;

            //Education Qualification
            txtsscpoint.Text = String.Empty;
            txthscpoint.Text =String.Empty;
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

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            facultyProfile fp = new facultyProfile();
            fp.Show();
        }
    }
}
