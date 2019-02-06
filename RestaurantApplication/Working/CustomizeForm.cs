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
    public partial class CustomizeForm : Form
    {
        public Product productInForm = new Product();
        private ICustomizeForm callingForm;
        public int ammount = 1;

        public CustomizeForm(ICustomizeForm workingMenu)
        {
            InitializeComponent();
            callingForm = workingMenu;
        }

        public void SendData(Product product)
        {
            productInForm.Name = product.Name;
            productInForm.Price = product.Price;
            ammountTextBox.Text = ammount.ToString();

            productTextBox.Text = productInForm.DisplayText;
            newPriceTextBox.Text = product.Price.ToString();
        }

        private void newPriceButton_Click(object sender, EventArgs e)
        {
            decimal newPrice = 0;
            bool goodData = decimal.TryParse(newPriceTextBox.Text, out newPrice);

            if (goodData)
            {
                productInForm.Price = newPrice;
                productTextBox.Text = productInForm.DisplayText;
            }
            else
            {
                MessageBox.Show("You must insert a valid price for the product", "Wrong Data");
            }
        }

        private void addDetailButton_Click(object sender, EventArgs e)
        {
            string detail = detailTextBox.Text;

            if (detail.Length > 0 && detail.Length <= 20)
            {
                productInForm.Detail = detail;
                productTextBox.Text = productInForm.DisplayText;
            }
            else if (detail.Length > 20)
            {
                MessageBox.Show("You have a limit of 20 characters for the detail", "Limit exceeded");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            callingForm.CustomizeAddDone();
            this.Close();
        }

        private void CustomizeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            callingForm.CustomizeFormClosed();
        }

        private void ammountButton_Click(object sender, EventArgs e)
        {
            bool goodData = int.TryParse(ammountTextBox.Text, out ammount);

            if (goodData)
            {
                ammountTextBox.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("You must insert a valid price for the product", "Wrong Data");
            }
        }

        private void quitCustomizeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
