using CodeLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApplication
{
    public partial class PayTotal : Form
    {
        public IUsedTable tableActual = new UsedTable();
        private IPayTotal callingForm;

        public PayTotal(IPayTotal workingMenu)
        {  
            InitializeComponent();
            callingForm = workingMenu;
        }

        public void SendData(IUsedTable table)
        {
            decimal total = 0;
            this.tableActual = table;

            foreach (Product product in table.Products)
            {
                total += product.Price;
            }

            totalListBox.DataSource = null;
            totalListBox.DataSource = table.Products;
            totalListBox.DisplayMember = "DisplayText";

            totalValueBox.Text = $"{total:C}";
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            callingForm.PayTotalPaymentDone();
            this.Close();  
        }

        private void PayTotal_FormClosed(object sender, FormClosedEventArgs e)
        {
            callingForm.PayTotalFormClosed();
        }

        private void quitPayTotalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
