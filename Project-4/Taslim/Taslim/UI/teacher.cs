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
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
        }

        private void btnback3_Click(object sender, EventArgs e)
        {
            this.Hide();
            facultyProfile fp = new facultyProfile();
            fp.Show();
        }


        TeacherManager teacherManager = new TeacherManager();
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
                (string.IsNullOrEmpty(txtmasterson.Text)) || (string.IsNullOrEmpty(txtphdon.Text)) ||
                (string.IsNullOrEmpty(designationcomboBox.Text)) || (String.IsNullOrEmpty(dtp_dateOfJoining.Text)) ||
                (string.IsNullOrEmpty(txtcurrrentsalary.Text)))
            {
                MessageBox.Show("Please Insert all data", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Teacher teacher = new Teacher();


                teacher.Name = txtname.Text;
                teacher.FatherName = txtfathername.Text;
                teacher.MotherName = txtmothername.Text;
                teacher.Vilage = txtvillage.Text;
                teacher.Post = txtpost.Text;
                teacher.Thana = txtthana.Text;
                teacher.Disrict = txtdistric.Text;
                teacher.Country = txtcountry.Text;
                teacher.Nationality = txtnationality.Text;
                teacher.MobileNo = txtmobilenumber.Text;
                teacher.Email = txtemail.Text;

                teacher.SSCPoint = txtsscpoint.Text;
                teacher.HSCPoint = txthscpoint.Text;
                teacher.HonrsPoint = txthonspoint.Text;
                teacher.MastersPoint = txtmasterspoint.Text;


                teacher.SSCSession = txtsscsession.Text;
                teacher.HSCSession = txthscsession.Text;
                teacher.HonrsSession = txthonssession.Text;
                teacher.MastersSession = txtmasterssession.Text;

                teacher.SSCOn = txtsscon.Text;
                teacher.HSCOn = txthscon.Text;
                teacher.HonrsOn = txthonrson.Text;
                teacher.MastersOn = txtmasterson.Text;
                teacher.PHDOn = txtphdon.Text;


                teacher.Designation = designationcomboBox.Text;
                teacher.DateOfJoining = Convert.ToDateTime(dtp_dateOfJoining.Text);
                teacher.CurrentSalary = Convert.ToInt32(txtcurrrentsalary.Text);


                string message = teacherManager.Add(teacher);


                CLearTextBox();
            }
        }

        public void CLearTextBox()
        {
            //Teacher Status
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
            txtphdon.Text= String.Empty;

            //Official Status

            designationcomboBox.SelectedIndex = 0;
            dtp_dateOfJoining.ResetText();
            txtcurrrentsalary.Text = String.Empty;

        }

        private void teacher_Load(object sender, EventArgs e)
        {
            designationcomboBox.SelectedIndex = 0;
        }
    }
}
