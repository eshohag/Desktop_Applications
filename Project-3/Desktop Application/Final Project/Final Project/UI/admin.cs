using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class admin : Form
    {
        public admin()
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
            patientInfo pa = new patientInfo();
            pa.Show();
        }

        private void btn_cabin_Click(object sender, EventArgs e)
        {
            this.Hide();
            cabinInfo ca = new cabinInfo();
            ca.Show();
        }

        private void btn_drug_Click(object sender, EventArgs e)
        {
            this.Hide();
            drugInfo dg = new drugInfo();
            dg.Show();
        }

        private void btn_treatment_Click(object sender, EventArgs e)
        {
            this.Hide();
            treatmentInfo tr = new treatmentInfo();
            tr.Show();
        }

        private void btn_doctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctorInfo doc = new doctorInfo();
            doc.Show();
        }

        private void btn_nurse_Click(object sender, EventArgs e)
        {
            this.Hide();
            nurseInfo nu = new nurseInfo();
            nu.Show();
        }

        private void btn_clinicalCost_Click(object sender, EventArgs e)
        {
            this.Hide();
            clinicalCost cl = new clinicalCost();
            cl.Show();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            this.Hide();
            payment pa = new payment();
            pa.Show();
        }

        private void btn_instrumentalCost_Click(object sender, EventArgs e)
        {
            this.Hide();
            instrumentalCost ins = new instrumentalCost();
            ins.Show();
        }

        private void btn_diagnosesCost_Click(object sender, EventArgs e)
        {
            this.Hide();
            diagnosesCost di = new diagnosesCost();
            di.Show();
        }

        private void btn_doctorSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctorSchedule2 docs = new doctorSchedule2();
            docs.Show();
        }

        private void btn_nurseSchedula_Click(object sender, EventArgs e)
        {
            this.Hide();
            nurseSchedule nus = new nurseSchedule();
            nus.Show();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
