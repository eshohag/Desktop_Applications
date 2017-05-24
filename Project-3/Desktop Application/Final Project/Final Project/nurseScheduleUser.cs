using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class nurseScheduleUser : Form
    {
        public nurseScheduleUser()
        {
            InitializeComponent();
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
            user ad = new user();
            ad.Show();
        }

        private void nurseScheduleUser_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
    }
}
