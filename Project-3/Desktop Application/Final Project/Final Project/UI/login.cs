using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        LoginInfoManager aLoginInfoManager = new LoginInfoManager();

        private void btn_go_Click(object sender, EventArgs e)
        {

            string userType = cmb_loginType.Text;
            string userName = txt_userName.Text;
            string password = txt_password.Text;

            loginInfo aPersonLoginInfo = new loginInfo();
            aPersonLoginInfo.UserType = userType;
            aPersonLoginInfo.UserName = userName;
            aPersonLoginInfo.Password = password;

            loginInfo match = aLoginInfoManager.MatchUser(aPersonLoginInfo);
            if (match != null)
            {
                if (match.UserType == "Administrator")
                {
                    messageshowLbl.Text = String.Empty;
                    admin ad = new admin();
                    ad.Show();
                }
                else
                {
                    messageshowLbl.Text = String.Empty;
                    user login = new user();
                    login.Show();
                }
            }
            else
            {

                messageshowLbl.ForeColor = System.Drawing.Color.White;
                messageshowLbl.BackColor = System.Drawing.Color.Red;
                messageshowLbl.Text = "Don't Match User Name or Password!";
            }

        }

        private void login_Load(object sender, EventArgs e)
        {
            cmb_loginType.SelectedIndex = 0;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

