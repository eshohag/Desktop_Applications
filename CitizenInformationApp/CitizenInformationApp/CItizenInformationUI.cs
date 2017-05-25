using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitizenInformationApp
{
    public partial class CItizenInformationUI : Form
    {
        Dictionary<string,string>citizenInfo=new Dictionary<string, string>();
        private string nid;
        private string name;
        public CItizenInformationUI()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            nid = nidTextBox.Text;
            name = nameTextBox.Text;
            if (nid.Length == 4)
            {
                if (name != "")
                {             
                    if (citizenInfo.ContainsKey(nid))
                    {
                        MessageBox.Show("Your NID has Already Entered", "Existing", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {                   
                         //Charecter na Integer ta check korbe ei stage ey  NID Must Be Integer Hote hobe 
                        if (nid.Trim() == "")
                        {
                            return;
                        }

                        for (int i = 0; i < nid.Length; i++)
                        {
                            if (!char.IsNumber(nid[i]))
                            {
                                MessageBox.Show("Please enter a valid number", "Invalid NID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                nidTextBox.Text = "";
                                return;
                            }
                        }           
                        //ei stage ey Name must be Charcter hote hobe
                        if (name.Trim() == "")
                        {
                            return;
                        }
                           
                        for (int i = 0; i < name.Length; i++)
                        {
                            if (char.IsNumber(name[i]))
                            {
                                MessageBox.Show("Please enter a valid Name", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                nameTextBox.Text = "";
                                return;
                            }
                        }
                        //Shob check korar por akhon Array te Add korte dibe 
                        citizenInfo.Add(nid, name);
                        showListBox.Items.Add(nid);
                        showListBox.Items.Add(name);
                        nidTextBox.Clear();
                        nameTextBox.Clear();                                         
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Name", "Name", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
            }
            else
            {
                MessageBox.Show("Your length of digit exact 4 digit","Length",MessageBoxButtons.OK,MessageBoxIcon.Warning); 
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (nidRadioButton.Checked)
            {
                string findNid = findTextBox.Text;
                if (citizenInfo.ContainsKey(findNid))
                {
                    string foundName = citizenInfo[findNid];
                    findShowListBox.Items.Clear();
                    findShowListBox.Items.Add(foundName);
                }
                else
                {
                    MessageBox.Show("Your NID don't match our DataBase", "Missing NID", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
            }
            else if (nameRadioButton.Checked)
            {
                string findName = findTextBox.Text;
                if (citizenInfo.ContainsValue(findName))
                {
                    findShowListBox.Items.Clear();
                    findShowListBox.Items.Add(findName);
                   
                }
                  else
                {
                    MessageBox.Show("Your Name don't match our DataBase", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }

            }
            else
            {
                MessageBox.Show("Please Checked The Radio Button", "Radio Button", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }   
    }
}
