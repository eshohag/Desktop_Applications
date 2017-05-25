using System;
using System.Windows.Forms;

namespace BloodGroupFinderWPF
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginForm aLoginForm = new LoginForm();
            aLoginForm.Show();
            this.Visible = false;
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            SignUpForm aSignUp = new SignUpForm();
            aSignUp.Show();

            this.Visible = false;


        }
    }
}
