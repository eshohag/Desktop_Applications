using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Taslim
{
    public partial class moduleSelect : Form
    {
        public moduleSelect()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            facultyProfile f2 = new facultyProfile();
            f2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendance at = new attendance();
            at.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lo = new Login();
            lo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modualSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
