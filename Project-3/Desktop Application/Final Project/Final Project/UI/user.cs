using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientInfo2 pa2 = new patientInfo2();
            pa2.Show();
        }

        private void btn_doctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctorInfo2 doc2 = new doctorInfo2();
            doc2.Show();
        }

        private void btn_doctorSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctorSchedule docs2 = new doctorSchedule();
            docs2.Show();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            this.Hide();
            payment2 pa2 = new payment2();
            pa2.Show();
        }

        private void button_NurseSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            nurseScheduleUser pa2 = new nurseScheduleUser();
            pa2.Show();
        }
    }
}
