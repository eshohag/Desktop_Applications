using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodGroupFinderWPF
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {


            string constring = @"server=DESKTOP-H5N8VAJ\SQLEXPRESS;database=BloodGroupFinderDB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Name,BloodGroup, ContactNo,Address  FROM Donner", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            loadDataGridView.DataSource = dt;

                        }
                    }
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            loadDataGridView.Hide();
            string search = searchTextBox.Text;
            BindGrid(search); //methods
        }
        private void BindGrid(string search)
        {

            string constring = @"server=DESKTOP-H5N8VAJ\SQLEXPRESS;database=BloodGroupFinderDB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Name,BloodGroup, ContactNo,Address  FROM Donner where Name='" + search + "' OR BloodGroup='" + search + "' OR ContactNo='" + search + "' OR Address='" + search + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm aMenuForm = new MenuForm();
            aMenuForm.Show();
            this.Visible = false;
            this.Hide();
            this.Close();
            this.Dispose();

        }
    }
}
