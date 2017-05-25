using BloodGroupFinderWPF.BLL;
using BloodGroupFinderWPF.DAL.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BloodGroupFinderWPF
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        UserManager aUserManager = new UserManager();
        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm aHomeForm = new HomeForm();
            aHomeForm.Show();
            this.Visible = false;
            this.Hide();
            this.Close();
            this.Dispose();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User aUser = new User();
            aUser.MobileNo = mobileNoTextBox.Text;
            aUser.Password = passwordTextBox.Text;

            if (aUser.MobileNo != String.Empty || aUser.Password != String.Empty)   //text box validation
            {
                if (aUserManager.IsExisting(aUser) != null)    //database e jodi mobile no & password thake taile login korte dibe ei application
                {
                    messageLabel.Text = String.Empty;
                    MenuForm aMenu = new MenuForm();
                    aMenu.Show();

                    this.Visible = false;
                    this.Hide();
                    this.Close();
                    this.Dispose();

                }
                else
                {
                    messageLabel.ForeColor = Color.Red;
                    messageLabel.BackColor = Color.AliceBlue;
                    messageLabel.Text = "Enter Your Valid Mobile No or Password";
                }



            }
            else
            {
                messageLabel.ForeColor = Color.Red;
                messageLabel.BackColor = Color.AliceBlue;
                messageLabel.Text = "Fillup the Balank";
            }



        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Page Load
        }
    }
}
