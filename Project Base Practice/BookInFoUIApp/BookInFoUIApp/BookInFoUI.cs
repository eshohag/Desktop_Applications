using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInFoUIApp
{
    public partial class BookInFoUI : Form
    {
       Dictionary<string,string>books=new Dictionary<string, string>(); 
        public BookInFoUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string isBn =isbnTextBox.Text;
            string bookDetails = bookDetailsTextBox.Text;

            if (isBn.Length ==3)
            {
                if (books.ContainsKey(isBn))
                {
                    MessageBox.Show("ISBN already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (bookDetails != "")
                    {
                        books.Add(isBn, bookDetails);
                        MessageBox.Show("Information has been saved.", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        isbnTextBox.Clear();
                        bookDetailsTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Your book Details ","Missing Book Details",MessageBoxButtons.OK,MessageBoxIcon.Question); 
                    }          
                }
            }

            else
            {
                MessageBox.Show("ISBN must be 13 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string searchIsbanKey = searchIsbnTextBox.Text;
            if (books.ContainsKey(searchIsbanKey))
            {
                searchBookDetailsTextBox.Text = books[searchIsbanKey];
            }
            else
            {
                MessageBox.Show("ISBN does not exist", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }
    }
}
