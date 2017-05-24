using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class instrumentalCost : Form
    {
        public instrumentalCost()
        {
            InitializeComponent();
        }
        PatientManager aPatientManager = new PatientManager();
        InstrumentManager aInstrumentManager = new InstrumentManager();
        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //Patient Id Search database

            if (String.IsNullOrEmpty(txt_patientId1.Text))
            {
                MessageBox.Show("Missing Patient ID", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ID = txt_patientId1.Text;
                Instrument aInstrument = aInstrumentManager.SearchID(ID);
                if (aInstrument != null)
                {
                    ClearTextBox();
                    txt_instrumentalCost.Text = aInstrument.Cost.ToString();
                    txt_description.Text = aInstrument.Description;

                }
                else
                {
                    MessageBox.Show("Invalid Patient ID", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void ClearTextBox()
        {
            txt_instrumentalCost.Text = String.Empty;
            txt_description.Text = String.Empty;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //Update database for Instruementsl Cost
            Instrument aInstrument = new Instrument();
            aInstrument.PatientId = txt_patientId1.Text;
            aInstrument.Cost = Convert.ToDecimal(txt_instrumentalCost.Text);
            aInstrument.Description = txt_description.Text;

            DialogResult dialogResultYesNo = MessageBox.Show("Do you want to Add database?", "Instrument Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResultYesNo == DialogResult.Yes)
            {
                string message = aInstrumentManager.Update(aInstrument);
                MessageBox.Show(message, "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
            }

        }

        private void button2_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2_ID.Text) || String.IsNullOrEmpty(textBox3_Cost.Text) ||
                String.IsNullOrEmpty(textBox1_Description.Text))
            {
                MessageBox.Show("Please Insert Drug Id!", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Instrument aInstrument = new Instrument();
                aInstrument.PatientId = textBox2_ID.Text;
                aInstrument.Cost = Convert.ToDecimal(textBox3_Cost.Text);
                aInstrument.Description = textBox1_Description.Text;

                if (aPatientManager.searchPatientID(aInstrument.PatientId) != null)
                {
                    DialogResult dialogResultYesNo = MessageBox.Show("Do you want to Add database?", "Instrument Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResultYesNo == DialogResult.Yes)
                    {
                        string message = aInstrumentManager.Add(aInstrument);
                        MessageBox.Show(message, "Confirmation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox3_Cost.Text = String.Empty;
                        textBox1_Description.Text = String.Empty;

                    }
                }
                else
                {
                    MessageBox.Show("Invalid Patient ID", "Wrrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }


    }
}
