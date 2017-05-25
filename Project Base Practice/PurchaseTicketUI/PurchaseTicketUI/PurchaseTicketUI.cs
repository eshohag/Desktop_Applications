using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseTicketUI
{
    public partial class PurchaseTicketUI : Form
    {
        private string nameCustomer;
        private int priceTicket;
        private int totalPrice;
        public PurchaseTicketUI()
        {
            InitializeComponent();
        }


        private void totalPriceButton_Click(object sender, EventArgs e)
        {
                  nameCustomer = nameTextBox.Text;
                 priceTicket = Convert.ToInt32(numberOfTextBox.Text);
                totalPrice = Multiply(priceTicket);
                nameTextBox.Clear();
                numberOfTextBox.Clear();
                MessageBox.Show(nameCustomer + ", Please Pay " + totalPrice + " Taka to parchease " + priceTicket +
                                " Ticket(s)");          
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            //string nameCustomer = nameTextBox.Text;
            //int priceTicket = Convert.ToInt32(numberOfTextBox.Text);
            //int totalPrice = Multiply(priceTicket);
            ////nameTextBox.Clear();
            //numberOfTextBox.Clear();
            MessageBox.Show("Customer Name: " + nameCustomer + "\n Unit Price: 10 \n Total Price: " + totalPrice);
        }

        private int Multiply(int priceTicket)
        {
           return priceTicket*10;
        }
    
    }
    
}
