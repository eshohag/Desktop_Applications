using System;
using System.Windows.Forms;

namespace BloodGroupFinderWPF
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void donnerAddButton_Click(object sender, EventArgs e)
        {
            ProfileCreateForm aProfileCreateForm = new ProfileCreateForm();
            aProfileCreateForm.Show();
            this.Visible = false;
            this.Hide();
            this.Close();
            this.Dispose();

        }

        private void SearchFormButton_Click(object sender, EventArgs e)
        {
            SearchForm aSearchForm = new SearchForm();
            aSearchForm.Show();
            this.Visible = false;
            this.Hide();
            this.Close();
            this.Dispose();

        }

        private void displayAllButton_Click(object sender, EventArgs e)
        {
            DonnerListForm aDonnerListForm = new DonnerListForm();
            aDonnerListForm.Show();
            this.Visible = false;
            this.Hide();
            this.Close();
            this.Dispose();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomeForm aHomeForm = new HomeForm();
            aHomeForm.Show();
        }
    }
}
