using BloodGroupFinderWPF.BLL;
using BloodGroupFinderWPF.DAL.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BloodGroupFinderWPF
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        UserManager aUserManager = new UserManager();
        private void SignUp_Click(object sender, EventArgs e)
        {
            User aUser = new User();
            aUser.Name = nameTextBox.Text;
            aUser.MobileNo = mobileNotextBox.Text;
            aUser.Password = passwordTextBox.Text;


            if (aUser.Name != String.Empty && aUser.MobileNo != String.Empty && aUser.Password != String.Empty)
            {
                DialogResult dialogResultYesNo = MessageBox.Show("Do you want to Sign-Up ?", "Sign-Up", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResultYesNo == DialogResult.Yes)
                {
                    //MessageBox.Show("Message", "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string message = aUserManager.SignUp(aUser);
                    messageNewLabel.ForeColor = Color.Green;
                    messageNewLabel.BackColor = Color.AliceBlue;
                    messageNewLabel.Text = message;

                    GetClearTextBox();

                    MenuForm aMenu = new MenuForm();
                    aMenu.Show();
                    this.Visible = false;
                    this.Hide();
                    this.Close();
                    this.Dispose();

                }

            }
            else
            {
                messageNewLabel.ForeColor = Color.Red;
                messageNewLabel.BackColor = Color.AliceBlue;
                messageNewLabel.Text = "Please Fill in the blank.";
            }
        }

        private void GetClearTextBox()
        {
            nameTextBox.Text = String.Empty;
            mobileNotextBox.Text = String.Empty;
            passwordTextBox.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm aHomeForm = new HomeForm();
            aHomeForm.Show();
            this.Visible = false;
        }
    }
}
