using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp
{
    public partial class BookInfoUI : Form
    {
        Dictionary<string, string> books = new Dictionary<string, string>();
        public BookInfoUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string isbn = isbnAddtextBox.Text;
            string bookDetails = bookDetailsAddTextBox.Text;
            if (isbn.Length != 13)
            {
                MessageBox.Show("ISBN must be 13 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (books.ContainsKey(isbn))
                {
                    MessageBox.Show("ISBN already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    isbnAddtextBox.Clear();
                    bookDetailsAddTextBox.Clear();
                    books.Add(isbn, bookDetails);
                    MessageBox.Show("Information has been saved.", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string isbn = isbnSearchTextBox.Text;
            if (!books.ContainsKey(isbn))
            {
                MessageBox.Show("ISBN does not exist", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                bookDetailsSearchTextBox.Text = books[isbn];
            }
        }
    }
}
