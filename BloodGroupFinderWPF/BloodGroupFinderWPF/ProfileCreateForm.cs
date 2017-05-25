using BloodGroupFinderWPF.BLL;
using BloodGroupFinderWPF.DAL.Model;
using System;
using System.Windows.Forms;

namespace BloodGroupFinderWPF
{
    public partial class ProfileCreateForm : Form
    {
        BloodDonnerInfoManager aBloodDonnerInfoManager = new BloodDonnerInfoManager();
        public ProfileCreateForm()
        {
            InitializeComponent();
            bloodGroupComboBox.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ProfileCreate aProfileCreate = new ProfileCreate();
            aProfileCreate.Name = nameTextBox.Text;
            aProfileCreate.BloodGroup = bloodGroupComboBox.Text;
            aProfileCreate.ContactNo = contactNoTextBox.Text;
            aProfileCreate.Address = addressRichTextBox.Text;

            if (aProfileCreate.Name != String.Empty && aProfileCreate.BloodGroup != String.Empty && aProfileCreate.ContactNo != String.Empty && aProfileCreate.Address != String.Empty)    //Validation check 
            {
                if (aProfileCreate.BloodGroup.Length < 5)
                {
                    DialogResult dialogResultYesNo = MessageBox.Show("Do you want to Save Information?", "Blood Donner Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResultYesNo == DialogResult.Yes)
                    {
                        string message = aBloodDonnerInfoManager.Save(aProfileCreate);
                        if (message == "Succesfully Save")
                        {
                            GetClearData();
                            MessageBox.Show(message, "Blood Donner Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DonnerListForm aDonnerListForm = new DonnerListForm();
                            aDonnerListForm.Show();
                            this.Visible = false;
                            this.Hide();
                            this.Close();
                            this.Dispose();

                        }
                        else
                        {
                            MessageBox.Show(message, "Blood Donner Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Your Blood Group", "Blood Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void GetClearData()
        {
            nameTextBox.Text = String.Empty;
            bloodGroupComboBox.SelectedIndex = 0;
            contactNoTextBox.Text = String.Empty;
            addressRichTextBox.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm aMenuForm = new MenuForm();
            aMenuForm.Show();
            this.Visible = false;
            this.Hide();
            this.Close();
            this.Dispose();

        }
    }
}
