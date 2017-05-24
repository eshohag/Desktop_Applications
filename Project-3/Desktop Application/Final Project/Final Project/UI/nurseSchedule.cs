using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class nurseSchedule : Form
    {
        public nurseSchedule()
        {
            InitializeComponent();
        }


        NurseScheduleManager aNurseScheduleManager = new NurseScheduleManager();
        NurseManager aNurseManager = new NurseManager();

        private void nurseSchedule_Load(object sender, EventArgs e)
        {
            cmb_shift.SelectedIndex = 0;
            cmb_department.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        private void btn_search_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_NurseID.Text))
            {
                MessageBox.Show("Missing  ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ID = Convert.ToInt32(txt_NurseID.Text);
                NurseSchedule aSchedule = aNurseScheduleManager.FindSchedule(ID);
                if (aSchedule != null)
                {
                    ClearTextBox();
                    txt_NameOfNurse.Text = aSchedule.Name;
                    cmb_department.Text = aSchedule.Department;
                    txt_EducationNurse.Text = aSchedule.Education;
                    cmb_shift.Text = aSchedule.Shift;
                    txt_NameOfNurse.ReadOnly = true;
                    cmb_department.Enabled = false;
                    txt_EducationNurse.ReadOnly = true;
                }
                else
                {
                    Nurse aDoctors = aNurseManager.SearchByID(ID);
                    if (aDoctors != null)
                    {
                        ClearTextBox();
                        txt_NameOfNurse.Text = aDoctors.Name;
                        cmb_department.Text = aDoctors.Department;
                        txt_EducationNurse.Text = aDoctors.Education;
                        txt_NameOfNurse.ReadOnly = true;
                        cmb_department.Enabled = false;
                        txt_EducationNurse.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(cmb_shift.Text)) || (String.IsNullOrEmpty(txt_NurseID.Text)))
            {
                MessageBox.Show("Missing Some text", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                NurseSchedule aDoctorsSchedule = new NurseSchedule();
                aDoctorsSchedule.NurseID = Convert.ToInt32(txt_NurseID.Text);
                aDoctorsSchedule.Shift = cmb_shift.Text;

                string message = aNurseScheduleManager.Add(aDoctorsSchedule);
                MessageBox.Show(message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ClearTextBox();
            }
        }

        private void ClearTextBox()
        {

            txt_NameOfNurse.Text = String.Empty;
            txt_EducationNurse.Text = String.Empty;
            cmb_shift.SelectedIndex = 0;
            cmb_department.SelectedIndex = 0;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(cmb_shift.Text)) || (String.IsNullOrEmpty(txt_NurseID.Text)))
            {
                MessageBox.Show("Missing Some text", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dialogResultYesNo = MessageBox.Show("Do you want to update database?", "Doctor Schedule Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResultYesNo == DialogResult.Yes)
                {
                    NurseSchedule aDoctorsSchedule = new NurseSchedule();
                    aDoctorsSchedule.NurseID = Convert.ToInt32(txt_NurseID.Text);
                    aDoctorsSchedule.Shift = cmb_shift.Text;
                    string message = aNurseScheduleManager.Update(aDoctorsSchedule);
                    MessageBox.Show(message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ClearTextBox();
                }
            }


        }

        private void btn_SearchDoctor_Click(object sender, EventArgs e)
        {
            string department = comboBox1.Text;
            string shift = comboBox2.Text;
            SqlConnection aConnection = new SqlConnection();
            aConnection.ConnectionString = @"Data Source=DESKTOP-AI4OE3P\SQLEXPRESS;Initial Catalog=DiagnosesCenterDB;Integrated Security=True";
            aConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from NurseScheduleUserView where Department='" + department + "' AND Shift='" + shift + "'", aConnection);

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
