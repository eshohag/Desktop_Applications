using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }
        PaymentManager aPaymentManager = new PaymentManager();
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }

        //private void btn_Calculate1_Click(object sender, EventArgs e)
        //{
        //    if ((String.IsNullOrEmpty(txt_treatmentCost.Text)) || (string.IsNullOrEmpty(txt_cabinCost.Text)) || (String.IsNullOrEmpty(txt_clinicalCost.Text)) || (string.IsNullOrEmpty(txt_instrumentalCost.Text)) || (String.IsNullOrEmpty(txt_diagnosesCost.Text)))
        //    {
        //        MessageBox.Show("Please insert a number value", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Question);

        //    }
        //    else
        //    {
        //        Double a1, a2, a3, a4, a5, sum;
        //        a1 = Convert.ToDouble(txt_treatmentCost.Text);
        //        a2 = Convert.ToDouble(txt_cabinCost.Text);
        //        a3 = Convert.ToDouble(txt_clinicalCost.Text);
        //        a4 = Convert.ToDouble(txt_instrumentalCost.Text);
        //        a5 = Convert.ToDouble(txt_diagnosesCost.Text);

        //        sum = (a1 + a2 + a3 + a4 + a5);

        //        txt_totalCost.Text = sum.ToString();
        //    }


        //}



        private void btn_Calculate2_Click(object sender, EventArgs e)
        {
            //Calculate Discunt
            if ((String.IsNullOrEmpty(txt_totalCost.Text)) || (string.IsNullOrEmpty(txt_discount.Text)))
            {
                MessageBox.Show("Please insert a number any value", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                decimal Discount, TotalCost, NetPayment;
                TotalCost = Convert.ToDecimal(txt_totalCost.Text);
                Discount = Convert.ToDecimal(txt_discount.Text);
                decimal Percentage = (Discount / 100) * TotalCost;
                NetPayment = Convert.ToDecimal(TotalCost - Percentage);
                if (NetPayment >= 0)
                {
                    txt_netPayment.Text = NetPayment.ToString();
                    btn_Calculate3.Enabled = true;
                    btn_add.Enabled = true;
                    btn_print.Enabled = true;
                    txt_netPayment.BackColor = Color.White;
                }
                else
                {
                    txt_netPayment.Text = "Not Accepted your Discount ";
                    txt_netPayment.BackColor = Color.Red;
                    btn_Calculate3.Enabled = false;
                    btn_add.Enabled = false;
                    btn_print.Enabled = false;

                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if ((String.IsNullOrEmpty(txt_patientId2.Text)) || (string.IsNullOrEmpty(txt_patientName.Text)) || (String.IsNullOrEmpty(txt_clinicalCost.Text)) ||
                (string.IsNullOrEmpty(txt_instrumentalCost.Text)) || (String.IsNullOrEmpty(txt_diagnosesCost.Text)) || (String.IsNullOrEmpty(txt_cabinCost.Text)) || (String.IsNullOrEmpty(txt_treatmentCost.Text)) ||
                (String.IsNullOrEmpty(txt_advancePaid.Text)) || (String.IsNullOrEmpty(txt_discount.Text)) || (String.IsNullOrEmpty(txt_due.Text)))
            {
                MessageBox.Show("Please insert a number value", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            else
            {
                Payment aPayment = new Payment();
                aPayment.PatientId = txt_patientId2.Text;
                aPayment.Name = txt_patientName.Text;
                aPayment.CabinCost = Convert.ToDecimal(txt_cabinCost.Text);
                aPayment.ClinicalCost = Convert.ToDecimal(txt_clinicalCost.Text);
                aPayment.DiagnosesCost = Convert.ToDecimal(txt_diagnosesCost.Text);
                aPayment.InstrumentCost = Convert.ToDecimal(txt_instrumentalCost.Text);
                aPayment.TreatmentCost = Convert.ToDecimal(txt_treatmentCost.Text);
                aPayment.AdvancePaid = Convert.ToDecimal(txt_advancePaid.Text);
                aPayment.Discount = Convert.ToDecimal(txt_discount.Text);
                aPayment.TotalDue = Convert.ToDecimal(txt_due.Text);
                aPayment.NetPayment = Convert.ToDecimal(txt_netPayment.Text);
                aPayment.TotalCost = Convert.ToDecimal(txt_totalCost.Text);

                string message = aPaymentManager.Add(aPayment);
                MessageBox.Show(message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (message == "Successfully Saved or Added info!")
                {
                    ClearTextBox();
                }
            }

        }

        private void btn_Calculate3_Click(object sender, EventArgs e)
        {
            //Calculate Dues
            if ((String.IsNullOrEmpty(txt_netPayment.Text)) || (string.IsNullOrEmpty(txt_advancePaid.Text)))
            {
                MessageBox.Show("Please insert a number value", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                double Netpayment = Convert.ToDouble(txt_netPayment.Text);
                double AdvancedPayment = Convert.ToDouble(txt_advancePaid.Text);
                double Due = Netpayment - AdvancedPayment;
                txt_due.Text = Due.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_patientId2.Text))
            {
                MessageBox.Show("Insert Your patients ID  ", "Missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Search Patient Id
                ClearTextBox();
                string PatientId = txt_patientId2.Text;
                Payment aPayment = aPaymentManager.SearchByID(PatientId);
                if (aPayment != null)
                {
                    txt_patientName.Text = aPayment.Name;
                    txt_cabinCost.Text = aPayment.CabinCost.ToString();
                    txt_clinicalCost.Text = aPayment.ClinicalCost.ToString();
                    txt_treatmentCost.Text = aPayment.TreatmentCost.ToString();
                    txt_instrumentalCost.Text = aPayment.InstrumentCost.ToString();
                    txt_diagnosesCost.Text = aPayment.DiagnosesCost.ToString();
                    txt_totalCost.Text = aPayment.TotalDue.ToString();
                    txt_advancePaid.Text = aPayment.AdvancePaid.ToString();
                    txt_discount.Text = aPayment.Discount.ToString();
                    txt_netPayment.Text = aPayment.NetPayment.ToString();
                    txt_due.Text = aPayment.TotalDue.ToString();



                    Double a1, a2, a3, a4, a5, sum;
                    a1 = Convert.ToDouble(txt_treatmentCost.Text);
                    a2 = Convert.ToDouble(txt_cabinCost.Text);
                    a3 = Convert.ToDouble(txt_clinicalCost.Text);
                    a4 = Convert.ToDouble(txt_instrumentalCost.Text);
                    a5 = Convert.ToDouble(txt_diagnosesCost.Text);

                    sum = (a1 + a2 + a3 + a4 + a5);
                    txt_totalCost.Text = String.Empty;
                    txt_totalCost.Text = sum.ToString();


                    txt_patientName.ReadOnly = true;
                    txt_cabinCost.ReadOnly = true;
                    txt_clinicalCost.ReadOnly = true;
                    txt_treatmentCost.ReadOnly = true;
                    txt_instrumentalCost.ReadOnly = true;
                    txt_diagnosesCost.ReadOnly = true;
                    txt_totalCost.ReadOnly = true;


                }
                else
                {
                    MessageBox.Show("Invalid Patient ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void ClearTextBox()
        {

            txt_patientName.Text = String.Empty;
            txt_cabinCost.Text = String.Empty;
            txt_clinicalCost.Text = String.Empty;
            txt_diagnosesCost.Text = String.Empty;
            txt_treatmentCost.Text = String.Empty;
            txt_instrumentalCost.Text = String.Empty;
            txt_totalCost.Text = String.Empty;
            txt_advancePaid.Text = String.Empty;
            txt_discount.Text = String.Empty;
            txt_due.Text = String.Empty;
            txt_netPayment.Text = String.Empty;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Payment & Delivery Receipt \n", new Font("Arial", 30, FontStyle.Bold), Brushes.GreenYellow, 80, 70);
            e.Graphics.DrawString("Patient ID- " + txt_patientId2.Text, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 150, 125);
            e.Graphics.DrawString("\nPatient Name- " + txt_patientName.Text +
            "\nTreatment Cost- " + txt_treatmentCost.Text + " Taka" +
            "\nCabine Cost- " + txt_cabinCost.Text + " Taka" +
            "\nClinical Cost- " + txt_clinicalCost.Text + " Taka" +
            "\nDiagnoses Cost- " + txt_diagnosesCost.Text + " Taka" +
            "\nInstrumental Cost- " + txt_instrumentalCost.Text + " Taka" +
            "\nTotal Cost- " + txt_totalCost.Text + " Taka" +
            "\nDiscount - " + txt_discount.Text + " %" +
            "\nNet-Payment Cost- " + txt_netPayment.Text + " Taka" +
            "\nAdvanced Paid- " + txt_advancePaid.Text + " Taka" +
            "\nDue - " + txt_due.Text + " Taka only"
        , new Font("Arial", 16, FontStyle.Regular), Brushes.Black, 150, 125);
        }

        private Bitmap aBitmap;
        private void btn_print_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

    }
}
