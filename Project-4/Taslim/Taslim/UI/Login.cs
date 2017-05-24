using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taslim.BAL;
using Taslim.DAL.Model;

namespace Taslim
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        LoginInfoManager aLoginInfoManager = new LoginInfoManager();
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            LoginInfo aPersonLoginInfo = new LoginInfo();
            aPersonLoginInfo.UserName = userName;
            aPersonLoginInfo.Password = password;

            LoginInfo match = aLoginInfoManager.MatchUser(aPersonLoginInfo);


            if (match != null)
            {
                moduleSelect oModuleSelect = new moduleSelect();
                oModuleSelect.Show();
            }
            else
            {
                MessageBox.Show("Don't Match User Name or Password!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
