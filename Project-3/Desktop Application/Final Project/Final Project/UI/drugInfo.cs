using Final_Project.BLL;
using Final_Project.DAL.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class drugInfo : Form
    {
        public drugInfo()
        {
            InitializeComponent();
        }
        DrugManager aDrugManager = new DrugManager();
        private int ID;
        private void btn_search_Click(object sender, EventArgs e)
        {
            //Search Drug
            if (String.IsNullOrEmpty(txt_DrugIDSearch.Text))
            {
                MessageBox.Show("Please Insert Drug Id!", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ID = Convert.ToInt32(txt_DrugIDSearch.Text);
                Drug aDrug = aDrugManager.SearchDrugID(ID);
                if (aDrug != null)
                {
                    txt_NameOfDrugSearch.Text = aDrug.Name;
                    txt_CompanySearch.Text = aDrug.Company;
                    txt_GroupSearch.Text = aDrug.GroupName;
                    txt_CostSearch.Text = aDrug.Cost.ToString();
                    txt_AmountOdDrugSearch.Text = aDrug.AmountOfDrug.ToString();

                }
                else
                {
                    MessageBox.Show("Sorry to say, Not Entry Drug ID Yet Now!", " Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //Add Drug Information
            if (String.IsNullOrEmpty(txt_nameOfDrug.Text) || String.IsNullOrEmpty(txt_group.Text) || String.IsNullOrEmpty(txt_companyName.Text) || String.IsNullOrEmpty(txt_cost.Text) || String.IsNullOrEmpty(txt_amountOfDrug.Text))
            {
                MessageBox.Show("Please Insert Drug Id!", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Drug aDrug = new Drug();
                aDrug.Name = txt_nameOfDrug.Text;
                aDrug.GroupName = txt_group.Text;
                aDrug.Company = txt_companyName.Text;
                aDrug.Cost = Convert.ToDecimal(txt_cost.Text);
                aDrug.AmountOfDrug = Convert.ToInt32(txt_amountOfDrug.Text);

                if (aDrugManager.AddDrugs(aDrug) == 10)
                {
                    MessageBox.Show("Already Assign a Drug Our database!", " Dupicate Drug Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (aDrugManager.AddDrugs(aDrug) != null)
                {
                    txt_DrugID.BackColor = Color.Purple;
                    txt_DrugID.ForeColor = Color.White;
                    Drug ID = aDrugManager.FindDrugID(aDrug);
                    txt_DrugID.Text = ID.DrugId.ToString();
                    txt_DrugID.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Failds to Save Drug Information !", " Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //Update Drug
            Drug aDrug = new Drug();
            aDrug.DrugId = ID;
            aDrug.Name = txt_NameOfDrugSearch.Text;
            aDrug.Company = txt_CompanySearch.Text;
            aDrug.GroupName = txt_GroupSearch.Text;
            aDrug.Cost = Convert.ToDecimal(txt_CostSearch.Text);


            int addingAmount = Convert.ToInt32(txt_AmountOdDrugSearch.Text);
            Drug aDrugs = aDrugManager.SearchDrugID(aDrug.DrugId);
            int bb = aDrugs.AmountOfDrug;


            aDrug.AmountOfDrug = addingAmount + bb;




            DialogResult dialogResultYesNo = MessageBox.Show("Do you want to update database?", "Sure!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResultYesNo == DialogResult.Yes)
            {
                string message = aDrugManager.Update(aDrug);
                MessageBox.Show(message, " Update Confirmation !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void drugInfo_Load(object sender, EventArgs e)
        {
            txt_DrugID.ReadOnly = true;
        }
    }
}
