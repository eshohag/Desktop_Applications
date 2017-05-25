using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationCollectApp
{
    public partial class StudentInformationUI : Form
    {
        Dictionary<string, string> studentInfo = new Dictionary<string, string>();
        private string id;
        private string details;
        private string nameResult;
        public StudentInformationUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
             id = idTextBox.Text;
            details = detailsTextBox.Text;
            if (id.Length == 4)
            {
                if (studentInfo.ContainsKey(id))
                {
                    MessageBox.Show("Existing ID", "Already Entered ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (details != "")
                    {
                        studentInfo.Add(id, details);
                        //MessageBox.Show("Saved Your Information", "Save", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        idTextBox.Clear();
                        detailsTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Missing Details","Details",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                    }
                }            
            }
            else
            {
                MessageBox.Show("Your ID is Invalid ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            id = searchIdTextBox.Text;
            if (studentInfo.ContainsKey(id))
            {
                nameResult = studentInfo[id];
                searchIdTextBox.Text = nameResult;
            }
            else
            {
                searchIdTextBox.Text = "Nothing ";
            }
        }
        private void showAllButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = id;
            detailsTextBox.Text = nameResult;
            searchIdTextBox.Text = id;
        }
    }
}
