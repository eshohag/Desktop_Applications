using System;
using System.Windows.Forms;

namespace BloodGroupFinderWPF
{
    public partial class DonnerListForm : Form
    {
        public DonnerListForm()
        {
            InitializeComponent();
        }
        private void ResultForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodGroupFinderDBDataSet.Donner' table. You can move, or remove it, as needed.
            this.donnerTableAdapter.Fill(this.bloodGroupFinderDBDataSet.Donner);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm aMenu = new MenuForm();
            aMenu.Show();
            this.Visible = false;
            this.Hide();
            this.Close();
            this.Dispose();

        }
    }
}
