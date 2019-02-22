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
    public partial class PayPartial : Form
    {
        public IUsedTable tableActual = new UsedTable();
        public IUsedTable tablePartial = new UsedTable();
        private IPayPartial callingForm;

        public PayPartial(IPayPartial workingMenu)
        {
            InitializeComponent();
            callingForm = workingMenu;
        }

        public void SendData(IUsedTable table)
        {
            tableActual = table;

            tablePartial.Id = table.Id;
            tablePartial.NumberOfTable = table.NumberOfTable;
            tablePartial.AreaId = table.AreaId;
            
            UpdateLists();
        }

        private void UpdateLists()
        {
            decimal totalUnpaid = 0;
            decimal totalPartial = 0;

            foreach (Product product in tableActual.Products)
            {
                totalUnpaid += product.Price;
            }

            foreach (Product product in tablePartial.Products)
            {
                totalPartial += product.Price;
            }

            unpaidListBox.DataSource = null;
            unpaidListBox.DataSource = tableActual.Products;
            unpaidListBox.DisplayMember = "DisplayText";
            unpaidValueBox.Text = $"{totalUnpaid:C}";

            partialListBox.DataSource = null;
            partialListBox.DataSource = tablePartial.Products;
            partialListBox.DisplayMember = "DisplayText";
            partialValueBox.Text = $"{totalPartial:C}";

            if (tablePartial.Products.Count() > 0)
            {
                PaymentButton.Enabled = true;
            }
            else
            {
                PaymentButton.Enabled = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (unpaidListBox.SelectedItem != null)
            {
                Product moved = (Product)unpaidListBox.SelectedItem;
                tablePartial.Products.Add(moved);
                tableActual.Products.Remove(moved);

                UpdateLists(); 
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (partialListBox.SelectedItem != null)
            {
                Product moved = (Product)partialListBox.SelectedItem;
                tableActual.Products.Add(moved);
                tablePartial.Products.Remove(moved);

                UpdateLists();
            }
        }

        private void PayPartial_FormClosed(object sender, FormClosedEventArgs e)
        {
            callingForm.PayPartialFormClosed();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            callingForm.PayPartialPaymentDone();
            this.Close();
        }

        private void quitPayPartialButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
