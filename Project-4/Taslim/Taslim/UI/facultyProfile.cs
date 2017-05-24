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
    public partial class facultyProfile : Form
    {
        public facultyProfile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacher te = new teacher();
            te.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            administrator ad = new administrator();
            ad.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            accounts ac = new accounts();
            ac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            labController la = new labController();
            la.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            librarian li = new librarian();
            li.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            stuff st = new stuff();
            st.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            moduleSelect mo = new moduleSelect();
            mo.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
