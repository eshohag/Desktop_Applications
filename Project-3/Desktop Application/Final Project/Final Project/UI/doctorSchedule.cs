using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class doctorSchedule : Form
    {
        public doctorSchedule()
        {
            InitializeComponent();
        }
        DoctorsSchedulManager aDoctorsSchedulManager = new DoctorsSchedulManager();

        private void doctorSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diagnosesCenterDBDataSet.DoctorScheduleUserView' table. You can move, or remove it, as needed.
            this.doctorScheduleUserViewTableAdapter.Fill(this.diagnosesCenterDBDataSet.DoctorScheduleUserView);
            cmb_shift.SelectedIndex = 0;
            cmb_department.SelectedIndex = 0;
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            user ad = new user();
            ad.Show();
        }

        private void btn_SearchDoctor_Click(object sender, EventArgs e)
        {
            DoctorsSchedule aDoctorsSchedule = new DoctorsSchedule();
            aDoctorsSchedule.Department = cmb_department.Text;
            aDoctorsSchedule.Shift = cmb_shift.Text;

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
    }
}
