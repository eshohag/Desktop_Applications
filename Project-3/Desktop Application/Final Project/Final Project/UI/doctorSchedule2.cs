using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class doctorSchedule2 : Form
    {
        public doctorSchedule2()
        {
            InitializeComponent();
        }
        DoctorsSchedulManager aDoctorsSchedulManager = new DoctorsSchedulManager();
        DoctorsManager aDoctorsManager = new DoctorsManager();

        private void doctorSchedule2_Load(object sender, EventArgs e)
        {
            cmb_shift.SelectedIndex = 0;
            cmb_department.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            user us = new user();
            us.Show();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_doctorId.Text))
            {
                MessageBox.Show("Please Insert all data", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ID = Convert.ToInt32(txt_doctorId.Text);
                DoctorsSchedule aSchedule = aDoctorsSchedulManager.FindSchedule(ID);
                if (aSchedule != null)
                {

                    txt_NameOfDoctors.Text = aSchedule.Name;
                    cmb_department.Text = aSchedule.Department;
                    txt_doctorEducation.Text = aSchedule.Education;
                    cmb_shift.Text = aSchedule.Shift;
                    txt_NameOfDoctors.ReadOnly = true;
                    cmb_department.Enabled = false;
                    txt_doctorEducation.ReadOnly = true;
                    txt_NameOfDoctors.ReadOnly = true;
                }
                else
                {
                    Doctors aDoctors = aDoctorsManager.SearchByID(ID);
                    if (aDoctors != null)
                    {
                        txt_NameOfDoctors.Text = aDoctors.Name;
                        cmb_department.Text = aDoctors.Department;
                        txt_doctorEducation.Text = aDoctors.Education;
                        txt_NameOfDoctors.ReadOnly = true;
                        cmb_department.Enabled = false;
                        txt_doctorEducation.ReadOnly = true;
                        txt_NameOfDoctors.ReadOnly = true;


                    }
                    else
                    {
                        MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }



        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_doctorId.Text) || String.IsNullOrEmpty(cmb_shift.Text))
            {
                MessageBox.Show("Please Insert all data", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DoctorsSchedule aDoctorsSchedule = new DoctorsSchedule();
                aDoctorsSchedule.DoctorID = Convert.ToInt32(txt_doctorId.Text);
                aDoctorsSchedule.Shift = cmb_shift.Text;

                string message = aDoctorsSchedulManager.Add(aDoctorsSchedule);
                MessageBox.Show(message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DoctorsSchedule aDoctorsSchedule = new DoctorsSchedule();
            aDoctorsSchedule.DoctorID = Convert.ToInt32(txt_doctorId.Text);
            aDoctorsSchedule.Shift = cmb_shift.Text;
            DialogResult dialogResultYesNo = MessageBox.Show("Do you want to update database?", "Doctor Schedule Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResultYesNo == DialogResult.Yes)
            {
                string message = aDoctorsSchedulManager.Update(aDoctorsSchedule);
                MessageBox.Show(message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_SearchDoctor_Click(object sender, EventArgs e)
        {
            DoctorsSchedule aDoctorsSchedule = new DoctorsSchedule();
            aDoctorsSchedule.Department = comboBox1.Text;
            aDoctorsSchedule.Shift = comboBox2.Text;

            //List<DoctorsSchedule> ALlDoctors = aDoctorsSchedulManager.SearchByDept_shift(aDoctorsSchedule);
            //DataGridview use

            SqlConnection aConnection = new SqlConnection();
            aConnection.ConnectionString = @"Data Source=DESKTOP-AI4OE3P\SQLEXPRESS;Initial Catalog=DiagnosesCenterDB;Integrated Security=True";
            aConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from DoctorScheduleUserView where Department='" + aDoctorsSchedule.Department + "' AND Shift='" + aDoctorsSchedule.Shift + "'", aConnection);

            DataTable aDataTable = new DataTable();
            adapter.Fill(aDataTable);
            dataGridView1.DataSource = aDataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }
    }
}
